using TCSA.V2.Models;
using TCSA.V2.Models.LanguageModels;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class AngularProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 31,
                Title = "Tour of Heroes",
                IconUrl = "icons8-superwoman-480.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "tour-of-heroes",
                Description = "Learn the basics of Angular by building a purely front-end app using the documentation",
                Area = Area.Angular,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Angular.TourOfHeroes",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to the world of front-end frameworks! You should be excited, you’re about to take your first step in learning one of most required technologies of our time. Most job applications require knowledge of a Javascript front-end solutions, tried and tested tools for building scalable, interactive web applications."
                    },
                    new Paragraph
                    {
                        Body="The good news is that if you’ve been through the MVC area, learning the basics of Angular will be a breeze. It does most of the heavy lifting that Javascript does in MVC, so you’ll be building sooner than you imagine. "
                    },
                    new Paragraph
                    {
                        Body="Make no mistake, Angular and React are massive. There’s a fair amount of complexity and the learning curve is definitely steep. So be patient, you won’t become an expert overnight. However, these frameworks are very welcoming to beginners. Building simple apps with them is somewhat straightforward, so be careful not to get caught into unnecessary complexities early on. Let’s build a few simple apps first. And what better way to start than building a Coffee app? ☕🤩"
                    }
                },
                RequirementsIntro="From Angular’s documentation page: 'The <b>Tour of Heroes</b> application that you build helps a staffing agency manage its stable of heroes. The application has many of the features you’d expect to find in any data-driven application. The finished application acquires and displays a list of heroes, edits a selected hero’s detail, and navigates among different views of heroic data.'",
                Requirements = new List<string>
                {
                    "This project has only one requirement: You should complete the \"Tour of Heroes\" app in Angular's documentation page."
                },
                ResourcesIntro = "All you need for this project is the beginners tutorial provided by the Angular team:",

                Resources = new List<string>
                {
                    "<a target='_blank' href='https://angular.io/tutorial'>Angular Docs: Tour of Heroes Beginner’s Tutorial</a>"
                },
                ResourcesConclusion = "Since this is your first Angular project, we will keep it very simple. There won’t be any .NET or C# this time, you’ll focus on Angular only. And the documentation will provide everything you need for your first app.",
                Tips = new List<string>
                {
                    "Don't rush, everything here will be new, so take your time to understand each line of code.",
                    "Make notes. Here are three types of notes you can take: 1. Lists of steps to build things; 2. Concepts you're first learning about; 3. Things you find interesting and likely to use in the future. Keep your notes short.",
                    "If you feel you didn't retain much, you could redo the app and/or modify it and/or create a different app based on the gained knowledge. Tweaking projects goes a long way for content retention."
                }
            },
            new Project
            {
                Id = 32,
                Title = "Coffee Tracker",
                IconUrl = "icons8-coffee-mug-128.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "Coffee Tracker",
                Description = "Track your coffee consumption with a C# Web Api and Angular",
                Area = Area.Angular,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 50,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Angular.CoffeeTracker",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now that you’re familiar with Angular, let’s combine it with .NET! And what a powerful combination that is. The limit of what you can build using these two is only the limit of your imagination. We will be creating two separate applications: An Angular front-end and a C# Web Api. The front-end will call the api, similarly to what you’ve done before in our Shifts Logger project."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record your consumption of coffee.",
                    "You can choose something else to track, in case you're not a coffee person.",
                    "You should create two projects: A.NET WebApi and an Angular app.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "You should have a filter functionality, so I can select records per date.",
                    "Your database should have a single 'Records' table.The objective is to focus on Angular, so we should avoid the complexities of relational data.",
                    "You CANNOT use Angular Material."

                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio'>Microsoft Docs: Web Api</a>",
                    "<a target='_blank' href='https://angular.io/tutorial'>Angular Docs: Tour of Heroes Beginner’s Tutorial</a>",
                    "<a target='_blank' href='https://www.itsolutionstuff.com/post/angular-12-crud-application-tutorial-exampleexample.html'>Angular CRUD Tutorial</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=S5dzfuh3t8U'>Angular + C# Web Api Youtube Tutorial</a>",
                    "<a target='_blank' href='https://stackoverflow.com/questions/65082452/cors-is-not-working-with-net-core-api-and-angular-frontend'>Dealing With CORS (Cross Origin Resource Sharing)</a>"
                },
                ResourcesConclusion = "Since this is your first full-stack Angular project, make sure you look up everything you don’t know. Try not to let any keyword, method or concept left-behind. This is the moment to build your foundation. And don’t forget to reach out on our <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> if you have questions!",
                Tips = new List<string>
                {
                    "Your main objective is to call your API from the Angular App. Everything else is just moving data around and styling.",
                    "There are two ways to approach the construction of this app: Finishing the API first and then building the UI, or building each method end-to-end (ex: GetAllRecords method in the back-end plus list of records in the front-end). Choose one and stick to it.",
                    "Don't use Angular Material (a library for styling) in this project. Angular alone can be challenging enough and adding a rich library early on might overwhelm you. Also, you'll appreciate Angular Material more if you built applications without it first."
                }
            },
            new Project
            {
                Id = 33,
                Title = "Sleep Tracker",
                IconUrl = "icons8-sleeping-512.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "sleep-tracker",
                Description = "Build on your Angular foundation with an app to log and generate reports about your sleep",
                Area = Area.Angular,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Angular.SleepTracker",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Your second Angular project has the objective of solidifying the knowledge you gained from the Coffee Tracker. Even though Angular is a beginner-friendly framework, it’s still a lot to take in, and if you’re coming from a C# background, there are a few things to get used to. But don’t worry! You will still be challenged. We’re building on the first project with two extra challenges."
                    },
                     new Paragraph
                    {
                        Body="In this project you’ll log data about your sleep, either manually inputting your time in bed or using a timer to automatically log it. Dealing with time is always a challenge and great practice. Also, you’ll be using Angular Material, a powerful UI component library ubiquitous in enterprise Angular projects. This is a massive library that does take some time to learn, but once you master it, it becomes extremely easy to build interesting and great-looking UI components. You’ll be saying goodbye to Bootstrap! "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record sleep time.",
                    "You should create two projects: A .NET WebApi and an Angular app.",
                    "You need to use Angular Material.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "You should have a filter functionality, so I can show records per type and / or date.",
                    "Your database should have a single 'Records' table.The objective is to focus on Angular, so we should avoid the complexities of relational data.",
                    "This app needs to have a timer that will log your sleep once stopped and saved.",
                    "Users should also be able to input their sleep time using a form.",
                    "Your list of sleep records should have pagination, so you're not loading all records every time you visualise the list."


                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://material.angular.io/'>Angular Material Docs</a>",
                    "<a target='_blank' href='https://material.angular.io/guide/getting-started'>Getting Started With Angular Material</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=jGbP620NahE'>Angular Material CRUD Tutorial</a>"
                },
                ResourcesConclusion = "Angular Material can be tricky at first, but trust us, you’ll learn to love it and once you master it, you will never look back. But as always, reach out in our <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> if you get stuck!",
                Tips = new List<string>
                {
                    "When building your timer, I suggest you have a pause, play, stop and save buttons for better user experience.",
                    "If you get stuck implementing Angular Material in your project, take a step back and build a couple of simple purely front-end projects from Youtube tutorials."

                }
            },
            new Project
            {
                Id = 34,
                Title = "Quiz Game",
                IconUrl = "icons8-quiz-game-contestants-480.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "quiz-game",
                Description = "Build a highly interactive Quiz Game with Angular and Angular Material",
                Area = Area.Angular,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 100,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Angular.QuizGame",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now you’ve completed two projects with Angular and hopefully you’re starting to get comfortable with it. This next project will have a slightly more complex design and will stimulate your creativity while reinforcing your knowledge of Angular. We’ll once again practice a more complex data relationship scenario. This project will keep you busy for a while, but you’ll learn a lot from it. "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you will create and play quiz games.",
                    "You should create two projects: A .NET WebApi and an Angular app.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose only use Entity Framework, no other ORM is allowed.",
                    "Your database should have three tables: Question, Quiz, Game.",
                    "A question needs to have a Quiz associated with it, hence a foreign key is needed.",
                    "A game needs to have a Quiz associated with it, hence a foreign key is needed.",
                    "If a quiz is deleted, all questions and games associated with it need to be deleted.",
                    "You need to use pagination, which means you can't show any lists or tables longer than the height of the screen.",
                    "You need to use Angular Material"
                },
                Resources = new List<string>
                {
                    "<a href='https://blog.devart.com/types-of-relationships-in-sql-server-database.html#:~:text=So%2C%20what%20is%20one%2Dto,one%20record%20in%20table%201.'>Relationships in SQL</a>",
                    "<a href='https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx'>One-to-many relationship Entity Framework</a>",
                    "<a href='https://material.angular.io/components/table/overview'>Tables and Pagination in Angular Material</a>"
                },
                ResourcesIntro = "The resourced from the previous Angular projects can be used for the completion of this project, plus these: ",
                Tips = new List<string>
                {
                    "This project has loose design requirements, so search for quiz game designs on Google for inspiration, when you're planning your app.",
                    "Try to work with a couple of UI elements you haven't used before, for practice. In Angular Material's Documentation, if you click on Components, you'll see a large list of components on the left side of the screen. Grab one or two that you think can fit the project.",
                    "This is a very strong portfolio project, so make sure you pay attention to details, don't leave any stone unturned and ask for feedback in our community.",
                    "Take your project a step further by creating interesting features such as: A timer for your games, which the users can use. Or reports such as: games played per week, favourite games, etc. Let your creativity loose!"

                }
            },
        };
    }
}