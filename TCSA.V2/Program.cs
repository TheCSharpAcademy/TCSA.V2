using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Identity.Client;
using Octokit.Webhooks;
using Octokit.Webhooks.AspNetCore;
using Octokit.Webhooks.Models.PageBuildEvent;
using Serilog;
using TCSA.V2.Components;
using TCSA.V2.Components.Account;
using TCSA.V2.Controllers;
using TCSA.V2.Data;
using TCSA.V2.Helpers;
using TCSA.V2.Services;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Seq("http://localhost:5341")
    .CreateLogger();

builder.Services.AddLogging(loggingBuilder =>
{
  loggingBuilder.AddSeq(builder.Configuration.GetSection("Seq"));
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddScoped<IDataSeedService, DataSeedService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IUserActivityService, UserActivityService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ILeaderboardService, LeaderboardService>();
builder.Services.AddScoped<IPeerReviewService, PeerReviewService>();
builder.Services.AddScoped<ICountriesService, CountriesService>();
builder.Services.AddScoped<ICommunityService, CommunityService>();
builder.Services.AddScoped<ICodeWarsService, CodeWarsService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IRoadmapService, RoadmapService>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddScoped<HeartBeat>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.AddScoped<WebhookEventProcessor, MyWebhookEventProcessor>();

builder.Services.AddAuthentication(options =>
    {
      options.DefaultScheme = IdentityConstants.ApplicationScheme;
      options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddGitHub(o =>
    {
      o.ClientId = builder.Configuration["Values:GithubClientId"];
      o.ClientSecret = builder.Configuration["Values:GithubClientSecret"];
      o.CallbackPath = "/signin-github";
      // https://docs.github.com/en/developers/apps/building-oauth-apps/scopes-for-oauth-apps
      o.Scope.Add("read:user");

    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddHttpClient();
builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

builder.Services.Configure<LinkProviderOptions>(
    builder.Configuration.GetSection("LinkProvider"));

var app = builder.Build();

TCSA.V2.Helpers.ServiceProviderAccessor.ServiceProvider = app.Services;

using (var scope = app.Services.CreateScope())
{
  var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
  // dbContext.Database.EnsureDeleted();
  // dbContext.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
  app.UseMigrationsEndPoint();
}
else
{
  app.UseExceptionHandler("/Error", createScopeForErrors: true);
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.UseAntiforgery();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGitHubWebhooks();
});

app.MapAdditionalIdentityEndpoints();

app.Run();
