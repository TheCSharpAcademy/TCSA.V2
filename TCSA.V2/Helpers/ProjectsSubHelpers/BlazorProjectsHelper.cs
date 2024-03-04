using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class BlazorProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 39,
                Title = "Wardrobe Inventory",
                IconUrl = "icons8-wardrobe-392.png",
                BannerUrl = "",
                Slug = "wardrobe-inventory",
                Description = "Get started with Blazor by building an inventory for your clothes. With pictures!",
                Area = Area.Blazor,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to Blazor!! The current .NET solution for web-development that Microsoft created to compete with React (Meta) and Angular (Google). You might be thinking, why learn Blazor where most jobs want React/Angular? And that’s a good point. In fact I wouldn’t start with Blazor in the front-end before knowing one of the big JS frameworks. But once you have one of those covered, having Blazor in your resume might give you the edge you need to land that dream-job. And make no mistake! Even though there are LESS Blazor jobs out there, they definitely exist. And not many people are fighting for them."
                    },
                     new Paragraph
                    {
                        Body="Blazor lets you build user interfaces without using Javascript. Both client and server code is written in C#, allowing you to share code and libraries. It’s just a joy to work with. Up to 2022, there were two types of Blazor projects: Blazor Web Assembly, and Blazor Server. But recently Microsoft creates Blazor Hybrid, which allows you to use Blazor components to build the UI for apps with WPF and most importantly, MAUI. Wow!! Let’s get started??"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should store and retrieve wardrobe data..",
                    "You should use a Blazor Webassembly project.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "Since we'll only have basic CRUD operations, you should use Entity Framework.",
                    "Your database should have a single table. The objective is to focus on learning Blazor, so we should avoid the complexities of relational data.",
                    "Users of your app need to be able to upload pictures of wardrobe items.",
                    "You CAN'T USE Javascript interop. The objective is to stay away from JS, even though it's still possible to use it."
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio'>Microsoft Docs: Blazor</a>",
                    "<a target='_blank' href='https://www.c-sharpcorner.com/article/blazor-what-it-is-why-should-we-use-it/'>Why use Blazor?</a>",
                    "<a target='_blank' href='https://www.c-sharpcorner.com/blogs/create-a-net-6-app-on-blazor-wasm-for-crud-operations-with-ef-core'>Blazor CRUD Tutorial</a>"
                },
                ResourcesConclusion = "Since this is your first Blazor  project, I recommend you first complete the Blazor Todo App from Microsoft Learn. It’s a very simple project that will give you a basic understanding of how Blazor works. And don’t forget to reach out on our <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> if you have questions!",
                Tips = new List<string>
                {
                    "You only need a single project. Contrary to using Angular and React, you don't need to create two separate projects, since the front-end end and the back-end will be covered by Blazor.",
                    "In this project, you're not allowed to use Javascript Interop. But a nice challenge after the completion of the project would be to integrate it to your project: <a target='_blank' href='https://docs.microsoft.com/en-us/aspnet/core/blazor/javascript-interoperability/?view=aspnetcore-6.0'>Javascript Interop Explained</a>, <a target='_blank' href='https://www.youtube.com/watch?v=p4MD6ycpQpY'>Javascript Interop Youtube Tutorial</a>"
                }
            },
            new Project
            {
                Id = 40,
                Title = "Memory Game",
                IconUrl = "icons8-memory-512.png",
                BannerUrl = "",
                Slug = "memory-game",
                Description = "Build a simple memory game where users will train their brain and track results",
                Area = Area.Blazor,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="The objective of this project is to provide extra practice so you can consolidate your knowledge of Blazor. The data model won’t be very complex. But manipulating the state of the UI will be slightly complex. "
                    },
                     new Paragraph
                    {
                        Body="We will build a simple memory game where the users are presented with a group of paired cards facing down and they can turn the cards up to try to match them with their pair. Once a pair is matched, it becomes inactive. The game is finished when all pairs are matched. "
                    }
                },
                Requirements = new List<string>
                {
                    "Your memory game should have a timer.",
                    "Once a game is finished it should record the date it was played and the time it took to finish in a \"games\" table.",
                    "You should have just one level of difficulty.",
                    "Your game should have 9 cards.",
                    "The app should have two main components: the game and the games list.",
                    "You shouldn't need a database for the game functionality. All the information about the cards can be in lists in the code base.",
                    "Since it only requires basic operations, use Entity Framework for recording game history."
                },
                ResourcesConclusion = "You should be able to complete this project with the same resources found in the <a href='article/39' target='blank'>Blazor Wardrobe Inventory</a> project.",
                Tips = new List<string>
                {
                    "Split the development in three phases: game functionality, games history, styling.",
                    "When developing the functionality, have a simple game with 4 or 6 cards for faster testing.",
                    "During development, use characters on your cards. Bring in icons or images in the styling phase."
                },
                Challenges = new List<string>
                {
                    "Add difficulty levels to your game: more cards.",
                    "Add a game against the clock: How many cards can the user match in a minute?",
                    "Add a search functionality to the games list",
                    "Add a reports area where you'll query the database and show: How many games played per week/month/year and average score"
                }
            },
            new Project
            {
                Id = 41,
                Title = "Food Journal",
                IconUrl = "icons8-ingredients-480.png",
                BannerUrl = "",
                Slug = "food-journal",
                Description = "Log your food habits in your first CRUD Blazor App",
                Area = Area.Blazor,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In your previous Blazor Apps, you’ve worked with fairly simple data models. The objective of the Food Journal project is to increase complexity with relational data, which always adds complexity to development of forms and collecting the user input. It also adds complexity to filters and report systems. Our goal won’t be to learn extra Blazor Features, but to use what was previously learned with a more challenging business case. So let’s get moving!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application to track meals.",
                    "Your data schema should have at least a \"Meals\" and a \"Foods\" table, in a many-to-many relationship.",
                    "You should have a MealType enumeration (Breakfast, Lunch, Dinner, Snack), which will be recorded in the meals table.",
                    "Your app should have a vibrant color palette.",
                    "There should be a feature that allows the users to quickly record frequent meals.",
                    "There should be a search functionality (per date, per food, per meal type)",
                    "There should be a report feature with queries such as how many times the user had a certain food per period of time."
                },
                Tips = new List<string>
                {
                    "Tracking every meal requires incredible discipline. Your app needs to make recording meals very easy. Make each meal and food a button to make the process very agile.",
                    "If possible use icons to represent the foods, as it makes the app more pleasing to use. You can find excellent icons on icons8.com."
                },
                Challenges = new List<string>
                {
                    "Add macronutrients categorization.",
                    "Add a \"cheat meal\" feature to record how many times the user ate junk food or candies.",
                    "Add goals such as: drinking 20 liters of water in a week, or avoiding chocolate for 7 days.",
                    "To enrich your app, try to fetch food data from a free Api: <a target='_blank' href='https://apilist.fun/category/food'>6 Free Food APIs</a> project."
                }
            },
            new Project
            {
                Id = 42,
                Title = "Sports Statistics",
                IconUrl = "icons8-football-team-480.png",
                BannerUrl = "",
                Slug = "sports-statistics",
                Description = "Build an application to track the performance of a sports team in real time",
                Area = Area.Blazor,
                ExperiencePoints = 100,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="You were hired by a sports club to build a software that will keep track of their teams statistics. They’ve tried several different apps but none was exactly what they wanted so decided to budget for an in-house developer. You’re lucky that your Blazor skills are now soaring and you’re ready to deliver. So far you have learned almost everything needed to fulfil the projects requisites. We will only add the ability to show data charts to help their coaches visualize the players performances. Let’s get started!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application that will track and generate reports about a sports team's performance.",
                    "The app will have a page divided two areas: The UI where the in-game data will be tracked and an area showing the current statistics.",
                    "The app will have a reports area in a different page showing the players statistics across multiple games. Coaches should be able to se detailed players information per game and per season. This area should contain barcharts with the players performance.",
                    "The UI needs to contain a list of players with 5 parameters that will be tracked (i.e. passes, shots, rebounds, blocks, interceptions, in basketball.",
                    "Data should be tracked with the click of a button. (i.e. a rebound button clicked on Dennis Rodman's row will track a rebound at a given time in the game).",
                    "The reports area should be updated immediately upon a button being clicked."
                },
                ResourcesIntro="You should have all skills necessary to complete this project, except for adding charts . Here are a couple of resources to get you started.",
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://www.c-sharpcorner.com/article/learn-to-draw-simple-asp-net-core-blazor-bar-chart-using-canvas-extensions/'>Simple Bar Chart in Blazor</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=ft9t3P1riOM'>High chart in Blazor</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=p4MD6ycpQpY'>Blazor JS Interop (Youtube)</a>"
                },
                Tips = new List<string>
                {
                    "If you haven't used Blazor + JS Interop before this might be a could opportunity to start. You don't need JS for most things in Blazor, but it might come in handy at times. Create a small project to practice it.",
                    "If you get stuck implementing Angular Material in your project, take a step back and build a couple of simple purely front-end projects from Youtube tutorials."
                },
                Challenges = new List<string>
                {
                    "Add the possibility of tracking the area of the playing field where an action happened, with a click on the fields area.",
                    "Add an Admin area where players can be added.",
                    "Add Authentication and Authorization so only logged in users can use the app.",
                    "Add role-based authorization with roles like: \"view only\", \"admin\", and \"superuser\""
                }
            },
        };
    }
}
