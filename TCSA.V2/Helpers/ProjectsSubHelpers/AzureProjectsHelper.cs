using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;

internal static class AzureProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 47,
                Title = "Deploying a Simple App",
                IconUrl = "icons8-web-392.png",
                BannerUrl = "",
                Description = "Start with Azure creating an account and deploying a simple app without a database",
                Slug = "deploying-simple-app",
                Area = Area.Azure,
                Level = Level.Blue,
                ExperiencePoints = 75,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In this day and age it’s absolutely essential to have experience with cloud-computing. The “cloud” allows us to access software and data from anywhere at any time, powered by the internet. These technologies have spread very fast amongst big companies since the mid-2000s and now they’re ubiquitous in organizations of all sizes. That means experience with cloud-computing is a requirement in the majority of programming jobs ads. The biggest player in cloud-computing is AWS (from Amazon), with 32% of market share (as of 2020), against Azure’s 20%. And it’s totally ok to choose AWS as your cloud-provider, but we’re sticking to Azure since it’s Microsoft’s solution and it integrates seamlessly with .NET’s tools."
                    },
                    new Paragraph
                    {
                        Body="The amount of services offered by cloud companies is enormous and ever-growing. It’s easy to get lost. The good news is that we don’t need to know too much to declare we “have experience with it”. Basically we need to be able to deploy static websites and full stack apps connected to a database and handle authentication. "
                    },
                     new Paragraph
                     {
                         Body="In the C# Academy, the cloud area is initially split in four projects. In the first we will learn how to deploy a simple app with no database back-end, just to get familiar with Azure Dashboard and integration with VS2022. In the second, we will expand on this knowledge by adding a SQL Server, which can be slightly more complexity. And on the third we will deploy a .NET Web API along with a React front-end, a very common stack in enterprise. As a bonus, we will learn the basics of Azure Functions, “a serverless solution that allows you to write less code, maintain less infrastructure, and save on costs”. So let’s jump into it!"
                     }
                },
                Requirements = new List<string>
                {
                    "This project has only one requirement: To publish a .NET Web App To Azure.",
                    "You can choose any type of .NET app: Razor Pages, MVC or Blazor.",
                    "You can use an existing app, provided it doesn't need a database connection.",
                    "You won't need authentication or authorization.",
                    "You should publish your app to an 'Azure App Service'."
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://www.investopedia.com/terms/c/cloud-computing.asp'>Cloud Computing Overview</a>",
                    "<a target='_blank' href='https://learn.microsoft.com/en-us/training/paths/microsoft-azure-fundamentals-describe-cloud-concepts/'>Microsoft Azure Fundamentals</a>",
                    "<a target='_blank' href='https://account.microsoft.com/account?lang=en-hk'>Creating a Microsoft Account</a>",
                    "<a target='_blank' href='https://azure.microsoft.com/en-us/free/'>Creating an Azure Account</a>",
                    "<a target='_blank' href='http://shorturl.at/blo34'>Azure Deployment</a>"
                },
                ResourcesIntro = "There’s a lot to learn in Azure and it’s easy to get lost. At this stage we suggest you read about Azure to get some context and then get into the specifics of how to deploy an app:",
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Video Tutorial",
                        ImgUrl = "icons8-video-tutorial-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Provided you have a Microsoft and and Azure accounts (see links above in case you don’t), you can follow this super quick tutorial where you’ll learn how to deploy to Azure using Visual Studio 2022: "
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/TcghUb1NPCw"
                            }
                        }
                    }
                }
            },
            new Project
            {
                Id = 48,
                Title = "Deploying a full-stack .NET app",
                IconUrl = "icons8-full-stack-512.png",
                BannerUrl = "",
                Slug = "deploying-full-stack-app",
                Description = "Deploy a crud app from the .NET ecosystem along with a database server",
                Area = Area.Azure,
                Level = Level.Blue,
                ExperiencePoints = 75,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now that we know how to get around in Azure and <a href='project/48' target='_blank'>deploy a static website</a>, it's time to take a step further and learn how to deploy a full-stack .NET solution, including creating an SQL Server in Azure."
                    },
                    new Paragraph
                    {
                        Body="While it might seem like a scary task, you'll be surprised at how streamlined the process is. Visual Studio is fully integrated with Azure. Creating an SQL Server in the cloud is also relatively simple and once that is done, all we need to do is to update the connection string so our app can find the production database, as opposed to your local server. Let's do this!"
                    }
                },
                Requirements = new List<string>
                {
                    "You'll have to deploy the <a href='project/25' target = '_blank'>Movies App</a> To Azure",
                    "You'll have to create an SQL server in azure",
                    "You'll have to make sure that the controller of the Azure app is calling the SQL server in Azure."
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://learn.microsoft.com/en-us/azure/app-service/app-service-web-tutorial-dotnet-sqldatabase' target='_blank'>Tutorial: Deploy an ASP.NET app to Azure with Azure SQL Database</a>",
                    "<a target='_blank' href='https://learn.microsoft.com/en-us/azure/azure-sql/database/single-database-create-quickstart?view=azuresql&tabs=azure-portal' target='_blank'>Quickstart: Create a single database - Azure SQL Database</a>"
                },
                Tips = new List<string>
                {
                    "Use your local SQL server when developing the app.",
                    "Azure SQL Server is a paid service. If you are getting started, you can use your <a href='https://azure.microsoft.com/en-us/free/' target='_blank'>200$ credit</a>. If you don't have that credit, you still won't have to pay anything, as long as you delete the database after finishing your project.",
                    "Make sure you pay attention to the pricing when configuring your database in Azure. If you're unsure about how much you've chosen to pay, delete the cloud SQL Server",
                    "You'll need two different deployments in two different resources: The app will be in an App Service, and the database in an SQL Server.",
                    "If this is your first time deploying a database, make sure you finish the first tutorial in the resources area. In it, we deploy a small todo-list app with database to Azure. Only then start working on your movie app deployment.",
                    "After creating your database and using it's connection string in appsettings.json, you'll need to execute an 'update-database' entity framework command, the same way you did in your local server, so that the data schema is applied to your Azure database."
                },
                Challenges = new List<string>
                {
                    "Try securing your application so that only registered and logged-in users have access to the movies info and operations.",
                    "If you have finished other MVC applications, try publishing them as well.",
                    "Publish a Blazor app to Azure. If you don't have experience with it yet, check out our <a href='#blazor-area'>Blazor Area.</a>",
                }
            },
            new Project
            {
                Id = 49,
                Title = "Deploy a full-stack .NET + JS Framework app",
                IconUrl = "icons8-website-468.png",
                BannerUrl = "",
                Description = "Deploy a full-stack app using a JS framework along with a .NET Web API",
                Area = Area.Azure,
                Level = Level.Blue,
                ExperiencePoints = 75,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Although this is The C# Academy and we love working within the .NET ecossystem, we can't ignore that that the world of front-end is dominated by Javascript frameworks, especially React and Angular. Newer contenders such as Vue and Svelte are options to the two giants although there isn't much hype around them."
                    },
                    new Paragraph
                    {
                        Body="Your job in this project will be to deploy a CRUD app to azure using a .NET Web API and a front-end framework of your choice. It can be React, Angular, but if you prefer working with other technologies, it's totally up to you. If you've been working your away through our projects, and have completed a JS framework section, you already have a project ready to go."
                    },
                     new Paragraph
                    {
                        Body="So let's get into it!"
                    }
                },
                Requirements = new List<string>
                {
                    "You'll have to deploy a full-stack app to Azure",
                    "You'll have to create an SQL server in azure",
                    "You'll have to create two app services: one for the Web API and one for the front-end app",
                    "Your app needs to have all 4 CRUD functionalities",
                    "Your app needs to have Authentication and Authorization. Non-authorized users should have Read permissions, but only authorized users should have Write Permissions."
                },
                Tips = new List<string>
                {
                    "You'll need to add CORS rules both on Azure and on the Web API",
                    "App services and SQL server are paid services on Azure. If you don't have an Azure Free Trial Subscription, let us know on Discord so we can prioritize your project review. In the best case scenario we will review your project quickly and you can delete all services and not pay a dime. If for whatever reason this process takes more than a few days you might need to pay a few cents (worst case scenario).",
                    "When setting up your SQL Server, choose the lowest possible database configuration to decrease the risks of getting charged. If you forget to delete the services and get charged you can still e-mail Azure and they'll waiver your debts (only once).",
                    "Do not, under any circumstances, deploy an app with SQL server without authorization & authentication. Bots will find your app pretty quickly and bombard it with requests, which might get you a massive bill. You'll still have it waivered, but it's a big scare (happened to me: I had a 500USD bill waivered)."
                },
                Resources = new List<string>
                {
                     "<a href='https://jasonwatmore.com/post/2020/01/08/angular-net-core-sql-on-azure-how-to-deploy-a-full-stack-app-to-microsoft-azure' target='_blank'>Deploying Angular App to Azure </a>(it applies for any other JS framework)",
                      "<a href='https://www.youtube.com/watch?v=cfc_snq9lBg' target='_blank'>Deploying Angular App to Azure </a>(Youtube)",

                },
                Challenges = new List<string>
                {
                    "Use Azure Key Vault and Azure Secrets to get User's Credentials",
                    "DevOps: Set up a CI/CD pipeline in Azure using Docker/Kubernetes"
                },
                Difficulty = Difficulty.Advanced
            },
            new Project
            {
                Id = 50,
                Title = "Azure Functions",
                IconUrl = "icons8-cloud-connection-480.png",
                BannerUrl = "",
                Slug = "azure-functions",
                Description = "Get started with serverless computing creating backend services directly on the cloud",
                Area = Area.Azure,
                Level = Level.Blue,
                Difficulty = Difficulty.Beginner,
                ReleaseDate = DateTime.Now.AddDays(28)
            },
        };
    }
}
