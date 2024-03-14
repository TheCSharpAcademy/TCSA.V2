using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCSA.V2.Models;

namespace TCSA.V2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<DashboardProject> DashboardProjects { get; set; }
        public virtual DbSet<AppUserActivity> UserActivity { get; set; }
        public virtual DbSet<UserReview> UserReviews { get; set; }
        public virtual DbSet<ApplicationUser> AspNetUsers { get; set; }
        public virtual DbSet<CommunityIssue> Issues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserReview>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.CodeReviewProjects)
                .HasForeignKey(ur => ur.AppUserId)
                .IsRequired();

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(x => x.Issues)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.AppUserId);
        }
    }
}
