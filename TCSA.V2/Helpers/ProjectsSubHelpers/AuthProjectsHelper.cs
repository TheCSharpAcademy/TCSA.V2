using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.LangugageModels;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;

internal static class AuthProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 28,
                Title = "Authentication and Authorization",
                IconUrl = "icons8-safe-ok-480.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "authentication-and-authorization",
                Description = "Learn how to secure your app with ASP.NET Core Identity",
                Area = Area.Auth,
                Level = Level.Brown,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Intermediate,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="So far we’ve learned how to build a full-stack app but we’ll never be able to deploy it without securing it first. If you publish a form that calls a database and allow anyone to use it, it will eventually be found by bots designed to find database vulnerabilities. If you pay for your data server as you use it, the result will be a massive bill. Believe me, I learned the hard way. 😁"
                    },
                    new Paragraph
                    {
                        Body="In principle, creating a custom authentication and authorisation system is fairly easy. You can even try yourself. Simply create an ‘user’ table with login and password and create a registration form that will insert a new user and a login form that will check the user input against that table. Then if the user is logged in you can allow them to view your page. If not, redirect them to the login/registration area."
                    },
                    new Paragraph
                    {
                        Body = "The reality is a little bit more complex though, since any real A&A system will need to support functionalities like changing password, managing an account, confirming a registration, just to name a few. ASP.NET Identity offers scaffolding for dozens of these operations, shipping fully-functioning front and back-end solutions. And they’re customisable too! Let’s see how it works."
                    }
                },
                Requirements = new List<string>
                {
                    "In this project, you'll have two tasks.",
                    "In a first moment you'll create a new Web App project with Identity as part of it.",
                    "In a second moment you'll scaffold Identity into the Movies App you created before. If you haven't done the Movies app, you can scaffold it into a project of your choice. This is the only project you need to submit for review.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "You need to seed test data.",
                    "You need to use EF's EnsureCreated method so the database and tables are created automatically.",
                    "You need to add logging logic to your app and save logs to your database when errors occur.",
                    "You don't need to handle auth scenarios such as e-mail confirmation, password recovery, etc. These will be addressed in future projects."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a target='blank' href='https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio'>Introduction to Identity</a>",
                    "<a target='blank' href='https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0&tabs=visual-studio'>Scaffolding Identity into Existing App</a>",
                    "<a target='blank' href='https://learn.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line'>Logging in C# and .NET</a>"
                },
                Tips = new List<string>
                {
                    "After wiring Identity up, you need to apply it to the controller you want to protect.",
                    "You'll only submit one project for review, however it's important to complete both tasks. Creating an app with identity from the beginning. And then scaffolding identity into an existing app. These are two different beasts and it's important to have exposure to both."
                }
             },
             new Project
             {
                Id = 72,
                Title = "Product Management System",
                IconUrl = "icons8-products-96.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "product-management-system",
                Description = "Learn role-based authentication with ASP.NET Core Identity",
                Area = Area.Auth,
                Level = Level.Brown,
                ExperiencePoints = 100,
                Difficulty = Difficulty.Intermediate,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="A very common scenario in web development is having different sections authorized to different roles within an organization. In this app we'll learn how to secure an app based on the user's position in the system, using ASP.NET Core Identity."
                    },
                    new Paragraph
                    {
                        Body="On top of that we will provide functionalities such as e-mail confirmation and passwords resetting and recovery. These can be difficult to implement but the good news is that you can find solutions out of the box by using ASP.NET core scaffolding tools."
                    },
                    new Paragraph
                    {
                        Body = "But as always, let's talk less and code more. Roll up your sleeves!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is back-of-store app where users will manage products. Feel free to choose any industry",
                    "You can use any ASP.NET front-end solution (Razor Pages, MVC, Blazor)",
                    "You need to use ASP.NET Core Identity",
                    "Users should be able to add, delete, update and view products",
                    "Products should have at least the following products: IsActive, DateAdded, Price",
                    "You don't need to add relational data (i.e. product categories, orders)",
                    "The app needs to have an admin area that will only be accessible to users with the 'Admin' role",
                    "In the Admin area, admin staff will be able to add, update, delete and view staff",
                    "New staff should be able to register themselves. Registration should be confirmed by e-mail",
                    "Staff should be able to reset their password",
                    "Staff should be able to recover their forgotten password",
                    "You need to implement an e-mail service for account confirmation and password functionalities",
                    "You need to seed test data",
                    "You need to use EF's EnsureCreated method so the database and tables are created automatically",
                    "You need to add logging logic to your app and save logs to your database when errors occur",
                },
                ResourcesIntro = "On top of the resources available for the <a href='https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio'>Introduction to Identity</a> project, you can use:",
                Resources = new List<string>
                {
                    "<a target='blank' href='https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-7.0'>Role-based authorization in ASP.NET Core</a>",
                    "<a target='blank' href='https://learn.microsoft.com/en-us/aspnet/identity/overview/features-api/account-confirmation-and-password-recovery-with-aspnet-identity'>Account confirmation and password recovery with ASP.NET Identity</a>",
                     "<a target='blank' href='https://code-maze.com/aspnetcore-send-email/'>How to Send an Email in ASP.NET Core</a>",
                }
             },
             new Project
             {
                Id = 74,
                Title = "External Auth",
                IconUrl = "icons8-fingerprint-error-96.png",
                Slug = "external-auth",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Learn to authorize a self-hosted ASP.NET Identity app with an external service.",
                Area = Area.Auth,
                Level = Level.Brown,
                ExperiencePoints = 100,
                Difficulty = Difficulty.Intermediate,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="These days, most web and native applications offer registration using a third-party service. The most common are Gmail, Microsoft, Facebook and Twitter. Enabling users to sign in with their existing credentials is convenient and shifts many of the complexities of managing the sign-in process onto a third party provider."
                    }
                },
                Requirements = new List<string>
                {
                    "You can use one of the previous Auth projects apps for this project.",
                    "Users should be able to register/login into your website using Facebook, Gmail, Github, Windows and Twitter. All five are necessary for the project to be approved.",
                    "User should also be able to register using the existing registration form.",
                    "Existing users should be able to link their account to one of the services above.",
                },
                Resources = new List<string>
                {
                    "<a target='blank' href='https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/?view=aspnetcore-7.0&tabs=visual-studio'>External provider authentication in ASP.NET Core</a>",
                },
                Tips = new List<string>
                {
                    "Initially, wire up external auth to a brand new app. Once the integration with external services is understood in isolation, it might be easier to apply it to an existing project.",
                },
                 Challenges = new List<string>
                {
                    "You can add many other services as options for the user. <a target='blank' href='https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/other-logins?view=aspnetcore-7.0'>Check this list</a>.",
                     "You can use aditional claims from the external provider. <a target='blank' href='https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/additional-claims?view=aspnetcore-7.0'>Check this article</a>."
                }
             },
        };
    }
}
