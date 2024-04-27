using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.LangugageModels;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;

public class ConsoleProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 53,
                Title = "Math Game",
                IconUrl = "icons8-maths-376.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "math-game",
                Description = "In your first project, you’ll create a math game to reinforce what you've learned in the Foundations area",
                Area = Area.Console,
                Level = Level.Green,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder= 1,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.MathGame",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In your first project you’ll build a very simple Math Game app. If this is your first time building a project indepentently, I recommend making use of the C# Academy's <a target='blank' href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> series from our C# Foundation area</a>.This series will guide you through the process of creating a console app from the ground up, while explaining crucial C# concepts. If you have already watched it, or if you have prior experience creating C# applications, this project will be a breeze. But it’s still helpful to reinforce your knowledge."
                    },
                    new Paragraph
                    {
                        Body="You'll find challenges at the end of this project and all other projects in The C# Academy. These challenges aren't requirements. Your project will still be approved and you'll gain the correspondent experience points. However, the challenges will reinforce what you've learned. Although you might not get extra points for completing them, you'll become a better developer each time you finish a challenge."
                    }
                },
                Requirements = new List<string>
                {
                    @"You need to create a Math game containing the 4 basic operations",
                    @"The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.",
                    @"Users should be presented with a menu to choose an operation",
                    @"You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.",
                    @"You don't need to record results on a database. Once the program is closed the results will be deleted."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'>Math Game Tutorial on Youtube</a>",
                },
                ResourcesIntro = "If you have previous C# experience, you might be able to complete this project without any help. If you don't, follow this tutorial: ",
                ResourcesConclusion = "You don't need to watch the second part of this tutorial (Building a .NET Maui app), to complete this project. Only the Console App is required",
                Tips = new List<string>
                {
                    "Don't forget to ALWAYS, I mean ALWAYS have your code saved on Github (or whatever source control you use). This way you won't lose your work, and you can always refer back to it in the future. You're building a library of your own!",
                    "Don't rush through the steps, even if this tutorial is easy for you. Make sure you understand EACH WORD of the code. Leave no stone unturned.",
                    "If there's anything you don't understand, hover over the code, and you'll get an explanation of what the term means. If you still can't understand it, google is your best friend. You'll find explanations about pretty much everything in forums like stackoveflow.com.",
                    "If this is your first project, I recommend doing it twice. You'll be surprised at how much your retention increases, and how many gaps were left in the first time.",
                    "Upon completion of your project, go to our <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> and brag about it! It's a very important step to complete a project and you should celebrate."
                },
                Challenges = new List<string>
                {
                    "Try to implement levels of difficulty.",
                    "Add a timer to track how long the user takes to finish the game.",
                    "Add a function that let's the user pick the number of questions.",
                    "Create a 'Random Game' option where the players will be presented with questions from random operations",
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If this is your first tutorial, you might be tempted to skip this step and start coding. Don’t do it or you’ll learn the hard way. One day after working for many hours on a difficult problem you won’t save your work on a source control repository and for whatever reason all of it will be lost."
                            },
                            new Paragraph
                            {
                                Body = "Get into the habit of saving every line of code you ever write. I promise it will save you from many headaches. All serious developers save their work on a backup repository. The most commonly used is Github. Create an account if you haven’t yet. "
                            },
                            new Paragraph
                            {
                                Body="1. In Visual Studio, go to Git > Create Git Repository<br>2. Enter your Login Details<br>3. Click on Create and Push. "
                            },
                            new Paragraph
                            {
                                Body="✅ Done! Your repository is good to go. Don’t forget to commit and push your changes after every step!"
                            }, new Paragraph
                            {
                                Body="You can take further step and learn how to integrate Github with Visual Studio watching this tutorial:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Review",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52/code-reviews' target='blank'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
                            }
                        }
                    },
                }
            },
             new Project
            {
                Id = 11,
                Title = "Calculator",
                IconUrl = "icons8-calculator-512.png",
                Slug = "calculator",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Level = Level.OliveGreen,
                Description = "This you’ll create a calculator with the help of Microsoft's Documentation",
                Area = Area.Console,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 10,
                DisplayOrder = 2,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.Calculator",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="For your second project you'll build a Console Calculator App with the help of Microsoft’s Documentation. This project shouldn't be more difficult than the first, but you'll learn important skills such as having multiple projects in a solution, writing to files, and debugging. It will also serve as practice in a very important skill: following written documentation. This is something you’ll be doing on a regular basis as a professional developer, so it’s essential that you’re comfortable applying text-based instructions when developing software."
                    }
                },
                Requirements = new List<string>
                {
                    @"Complete the following tutorial (parts 1 and 2): <a href='https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022'>Create a Calculator App (Microsoft Docs)</a>. You can find a link to part two at the bottom of the page."
                },
                RequirementsIntro = "This project has only one requirement:",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-mac'>Visual Studio For Mac</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0'>Visual Studio Code</a>"
                },
                ResourcesIntro = "The instructions for this project are based on Visual Studio for Windows. The code you will write will be the same regardless of the code editor, but the process of creating a new project will differ. Here are links about how to create a console app with different editors: ",
                Tips = new List<string>
                {
                    "Don't rush through the steps, even if this tutorial is easy for you. Make sure you understand EACH WORD of the code. Leave no stone unturned.",
                    "If there's anything you don't understand, hover over the code, and you'll get an explanation of what the term means. If you still can't understand it, google and chat gpt are your best friends. And you can find thorough explanations about pretty much everything in forums like stackoveflow.com.",
                    "Don't skip the debugging section in Part II. This is one of the most important skills you'll learn in this tutorial and it will be vital for future projects."
                },
                 Challenges = new List<string>
                {
                    "Create a functionality that will count the amount of times the calculator was used.",
                    "Store a list with the latest calculations. And give the users the ability to delete that list.",
                    "Allow the users to use the results in the list above to perform new calculations.",
                    "Add extra calculations: Square Root, Taking the Power, 10x, Trigonometry functions.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Code Review",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52/code-reviews' target='blank'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
                            }
                        }
                    }
                }

            },
             new Project
            {
                Id = 12,
                Title = "Habit Logger",
                IconUrl = "icons8-calendar-plus-96.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "habit-logger",
                Description = "Build a logger for a habit of choice. Learn how to interact with a database using SQLite and to get and validate user input",
                Area = Area.Console,
                Level = Level.OliveGreen,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 3,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.HabitTracker",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This is a very simple app that will teach you how to perform <a href='https://en.wikipedia.org/wiki/Create,_read,_update_and_delete'>CRUD operations</a> against a real database. These operations are the base of web-development and you’ll be using them throughout your career in any most applications. We think it’s very important to do it from the start of your journey, since everything that will happen from here is just adding complexity to CRUD operations. No matter how complex and fancy the app you’re building is, in the end it all comes down to executing CRUD calls to a database."
                    },
                    new Paragraph
                    {
                        Body="For that you’ll have to learn very simple <a href='https://en.wikipedia.org/wiki/SQL'>SQL commands</a>. I know it sounds scary, but you’ll be amazed about how little SQL knowledge you need to build a full-stack app. Don’t worry, we will take you by the hand and by the end you’ll have completed your first fully functioning CRUD app. The most common ways of calling a SQL database with C# are through <a href='https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/'>ADO.NET</a>, Dapper and Entity Framework. We will start by using ADO.NET, because it’s the closest to raw SQL."
                    },
                    new Paragraph
                    {
                        Body="If you think this project is too hard for you and you have no idea where to even start, you’re probably right. You might need an extra hand to build a real application on your own. If that’s the case, <a href='https://youtu.be/d1JIJdDVFjs'>watch the video tutorial for this project</a> and then come back and try it again on your own. It’s perfectly ok to feel lost, since most beginner courses don’t actually teach you how to build something. "
                    },
                    new Paragraph
                    {
                        Body="So let’s go!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you’ll register one habit.",
                    "This habit can't be tracked by time (ex. hours of sleep), only by quantity (ex. number of water glasses a day)",
                    "The application should store and retrieve data from a real database",
                    "When the application starts, it should create a sqlite database, if one isn’t present.",
                    "It should also create a table in the database, where the habit will be logged.",
                    "The app should show the user a menu of options.",
                    "The users should be able to insert, delete, update and view their logged habit.",
                    "You should handle all possible errors so that the application never crashes.",
                    "The application should only be terminated when the user inserts 0.",
                    "You can only interact with the database using raw SQL. You can’t use mappers such as Entity Framework.",
                    "Your project needs to contain a Read Me file where you'll explain how your app works. Here's a nice example:"
                },
                RequirementsConclusion = "<a href='https://github.com/thags/ConsoleTimeLogger'>Github project with an example of a tidy Read Me file.</a><br>Don't panic! I'll help! 😁",

                Tips = new List<string>
                {
                    "Test your SQL commands on DB Browser before using them in your program.",
                    "You can keep all of the code in one single class if you wish.",
                    "Use a switch statement for the user input menus.",
                    "Don't forget the user input's validation: Check for incorrect dates. What happens if a menu option is chosen that's not available? What happens if the users input a string instead of a number?"
                },
                 Challenges = new List<string>
                {
                    "Let the users create their own habits to track. That will require that you let them choose the unit of measurement of each habit.",
                    "Seed Data into the database automatically when the database gets created for the first time, generating a few habits and inserting a hundred records with randomly generated values. This is specially helpful during development so you don't have to reinsert data every time you create the database. ",
                    "Create a report functionality where the users can view specific information (i.e. how many times the user ran in a year? how many kms?) SQL allows you to ask very interesting things from your database."
                },
                 LearningIntro = "If you have learned the basics of C# following the <a href='article/8/foundations' target='blank'>C# Foundations</a> article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
                 LearningItems = new List<string>
                 {
                     "Taking user input from the console.",
                     "Printing messages on the console. ",
                     "Installing nuget packages (ASP.NET libraries that will help you write your program).",
                     "Basic control flow with 'if-else' and 'switch statements'",
                     "Connecting to a Sqlite database.",
                     "Basics of SQL(the language you use to communicate with the database). If you want to train some SQL before getting started, <a href='https://www.w3schools.com/sql/sql_exercises.asp'>here's an excellent place</a>."
                 },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Creating The Project",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This tutorial requires that you already have set up your .NET environment. If you haven’t yet, check <a href='article/7/setting-up' target='blank'>this article</a> out with the first steps. If you absolutely want to use another IDE, let me know."
                            },
                            new Paragraph
                            {
                                Body = "1. In Visual Studio, choose Create new project. If you’re using Visual Studio Code, let me know if you have difficulties creating the project.<br>2. Search for Console Application and click Next.<br>3. Choose a Project Name and a Location and click Next.<br>3. Choose the latest framework (Net 6 at the time of this tutorial) and click Create.<br>4. Run your application by clicking on the green play button on the top of the screen."
                            },
                            new Paragraph
                            {
                                Body = "A CLI (command line interface) will open and print ‘Hello World’ and the application will close itself. That means your application ASP.NET environment and your application are working properly."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Changing Your Working Directory",
                        ImgUrl = "icons8-folder-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This way .NET will build your project in your main folder. By default it builds your project in a bin folder and just to keep things simple we want to avoid that. That will create a Properties folder with a <b>launchsettings.json</b> file containing your configuration information. This is an important step only for applications that use Sqlite because you want the database to be created in the same folder of the application to avoid confusion."
                            },
                            new Paragraph
                            {
                                Body = "For that, click on the chevron next to the name of your app on the top menu, click on {nameoftheapp} Debug Properties and copy the path of your directory to the 'Working Directory' field. To find out what your path is, you can right click on your project in the Solution Explorer and on “Copy Full Path” or look it up in your Files Explorer. If you’re using Mac/Visual Studio Code, reach out and I’ll tell you how to do it. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-1.png"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Start Coding!",
                        ImgUrl = "icons8-coding-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Every time you start your app, it should check if there’s a database. If there isn’t, it will create one along with a table where you’ll store your data. If you delete your database externally, it will always create one. If the database exists, it will move to the next step: take the user input about what you want to do. Something like this:"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "habit-menu.png"
                            },
                            new Paragraph
                            {
                                Body = "In ASP.NET C# development, the use of SQL Server is very common. But we won’t be using it here. SQLite is a super lightweight database system and it’s important to get familiar with it before jumping into SQL server."
                            },
                            new Paragraph
                            {
                                Body = "You’ll need to tell your program to create a sqlite file. You’ll be able to visualise that file externally with the help of a small application. <a href='https://www.youtube.com/watch?v=HQKwgk6XkIA'>Here's a link to a basic sqlite tutorial</a>."
                            },
                            new Paragraph
                            {
                                Body = "That’s where your actual code begins! You’re on your own for a while. If you get stuck, keep trying, <a href='article/6/getting-help' target='blank'>remember the steps to debug your app/get unstuck</a>. And if you ultimately can’t do it, reach out to our <a href='https://discord.gg/JVnwYdM79C'>Discord Community</a> or myself and we will help!"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Video Tutorial",
                        ImgUrl = "external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you’re feeling totally lost, it’s perfectly ok to watch a video tutorial to get you going. Here you’ll learn to connect all the pieces to build a real application. Once you finish it, make sure you try it again on your own without the help of the video so you internalise the newly acquired knowledge. "
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/d1JIJdDVFjs"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If this is your first tutorial, you might be tempted to skip this step and start coding. Don’t do it or you’ll learn the hard way. One day after working for many hours on a difficult problem you won’t save your work on a source control repository and for whatever reason all of your work will be lost."
                            },
                            new Paragraph
                            {
                                Body = "Get into the habit of saving every line of code you ever write. I promise it will save you from many headaches. All serious developers save their work on a backup repository. The most commonly used is Github. Create an account if you haven’t yet. "
                            },
                            new Paragraph
                            {
                                Body="1. In Visual Studio, go to Git > Create Git Repository<br>2. Enter your Login Details<br>3. Click on Create and Push. "
                            },
                            new Paragraph
                            {
                                Body="✅ Done! Your repository is good to go. Don’t forget to commit and push your changes after every step!"
                            }, new Paragraph
                            {
                                Body="You can take further step and learn how to integrate Github with Visual Studio watching this tutorial:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Review",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52/code-reviews'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Next Step: Desktop App",
                        ImgUrl = "icons8-staircase-80.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>entire C# Foundation course</a>, you have already created a Math Game Desktop app using the amazing .NET MAUI. It will be great practice to build a desktop Habit Tracker App with the same functionality you’ve created for this console app. There will be some challenges, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on our <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> and we will help!"
                            }
                        }
                    },
                }
            },
             new Project
             {
                Id = 13,
                Title = "Coding Tracker",
                IconUrl = "icons8-smart-watch-96.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "coding-tracker",
                Level = Level.OliveGreen,
                Description = "Track your coding hours. Learn how to deal with dates, to use separation of concerns and use your first external library to enhance your application",
                Area = Area.Console,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 4,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.CodingTracker",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This app should be very similar to the <a href='article/12/habit-logger' target='blank'>Habit Tracker</a> you’ve previously completed. It will serve the purpose of reinforcing what you’ve learned with a bit of repetition and building on that knowledge with slightly more challenging requirements. "
                    },
                    new Paragraph
                    {
                        Body="This time you’ll have to deal with the complexity of handling Dates and Times, which is a real challenge in any application. You’ll also be using your first external library. Often times in professional environments programmers don’t reinvent the wheel and save time by using public solutions provided by other coders. That’s the beauty of the internet. You have access to an amazing coding community! "
                    },
                    new Paragraph
                    {
                        Body="In the first app we also didn’t have requirements for coding organization. This time you’ll have to use <a href='https://en.wikipedia.org/wiki/Separation_of_concerns'>separation of concerns</a>, one of the most important principles in modern programming. This is where you’ll start applying concepts of Object Oriented Programming. You’ll also need to use a “Model”  or “Entity”, to to represent the data you are dealing with. In this case, your coding sessions. So let’s get started!"
                    }
                },
                Requirements = new List<string>
                {
                    "This application has the same requirements as the previous project, except that now you'll be logging your daily coding time.",
                    "To show the data on the console, you should use the \"Spectre.Console\" library.",
                    "You're required to have separate classes in different files (ex. UserInput.cs, Validation.cs, CodingController.cs)",
                    "You should tell the user the specific format you want the date and time to be logged and not allow any other format.",
                    "You'll need to create a configuration file that you'll contain your database path and connection strings.",
                    "You'll need to create a \"CodingSession\" class in a separate file. It will contain the properties of your coding session: Id, StartTime, EndTime, Duration",
                    "The user shouldn't input the duration of the session. It should be calculated based on the Start and End times, in a separate \"CalculateDuration\" method.",
                    "The user should be able to input the start and end times manually.",
                    "You need to use Dapper ORM for the data access instead of ADO.NET. (This requirement was included in Feb/2024)",
                    "When reading from the database, you can't use an anonymous object, you have to read your table into a List of Coding Sessions."
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://spectreconsole.net/'>Spectre Console</a> documentation</a>.",
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Using Configuration Manager</a>",
                    "<a target='_blank' href='https://stackoverflow.com/questions/3719/how-to-validate-a-datetime-in-c'>Parsing DateTime in C#</a>",
                    "<a target='_blank' href='https://www.learndapper.com/'>Dapper Tutorial</a>.",
                },
                ResourcesIntro = "If you have learned the basics of C# following the <a href='article/8/foundations' target='blank'>C# Foundations</a> article, and completed the <a href='article/12/habit-logger' target='blank'>Habit Tracker</a> project, you should know all the basic techniques needed to complete this project. Here’s a list of extra resources you might need:",
                Tips = new List<string>
                {
                    "It's up to you the order in which you'll build, but we recommend you do it in this order: configuration file, model, database/table creation, CRUD controller (where the operations will happen), TableVisualisationEngine (where the consoleTableExt code will be run) and finally: validation of data.",
                    "Sqlite doesn't support dates. We recommend you store the datetime as a string in the database and then parse it using C#. You'll need to parse it to calculate the duration of your sessions.",
                    "Don't forget to push your changes to github every time you stop working.",
                    "Don't forget the user input's validation: Check for incorrect dates. What happens if a menu option is chosen that's not available? What happens if the users input a string instead of a number? Remember that the end date can't be before the start date."
                },
                 Challenges = new List<string>
                {
                    "Add the possibility of tracking the coding time via a stopwatch so the user can track the session as it happens.",
                    "Let the users filter their coding records per period (weeks, days, years) and/or order ascending or descending.",
                    "Create reports where the users can see their total and average coding session per period.",
                    "Create the ability to set coding goals and show how far the users are from reaching their goal, along with how many hours a day they would have to code to reach their goal. You can do it via SQL queries or with C#.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Creating a Configuration File",
                        ImgUrl = "external-configuration-computer-itim2101-lineal-color-itim2101-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In advanced applications, configuration properties are stored in an xml file. This practice makes it easier to configure your application in production. It’s not absolutely necessary now, but it’s not hard to learn and you should get used to it from the beginning of your coding journey. It makes your code cleaner and more organised. <a href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Check out the documentation</a> and if necessary search for “configuration file C#” on Youtube. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Creating a Desktop App",
                        ImgUrl = "icons8-desktop-computer-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you have watched the <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>entire C# Foundation course</a>, you have already created a Math Game Desktop app using the amazing .NET MAUI. It will be great practice to build a desktop Coding Tracker App with the same functionality you’ve created for this console app. There will be some challenges, especially if you want to create a timer, but you’ve already got all the skills necessary. And remember, if you get stuck, reach out on our <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> and we will help!"
                            }
                        }
                    }
                }
            },
             new Project
            {
                Id = 14,
                Title = "Flashcards",
                IconUrl = "icons8-quizlet-96.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "flashcards",
                Level = Level.Yellow,
                Description = "Building stacks of flashcards and a study functionality. Learn to deal with linked databases using SQL Server and to use Data Transfer Objects",
                Area = Area.Console,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.Flashcards",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="After the first two projects, you should be somewhat comfortable with how things work in C#. It’s time to make things slightly more complex. You’ll be using <b>SQL Server</b> for the first time. We could continue using SQLite, as it does everything needed for most small applications, but SQL Server is heavily used in the industry and the sooner we get familiar with it, the better."
                    },
                    new Paragraph
                    {
                        Body="This time the database will be a little more complex as well. We will have two tables linked by a foreign key. And for the first time we will be working with  <a href='https://www.codeproject.com/Articles/1050468/Data-Transfer-Object-Design-Pattern-in-Csharp' target='_blank'>DTOs (Data Transfer Objects)</a>, which will help us use the same object in different ways."
                    },
                    new Paragraph
                    {
                        Body="Time to get started!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where the users will create Stacks of Flashcards.",
                    "You'll need two different tables for stacks and flashcards. The tables should be linked by a foreign key.",
                    "Stacks should have an unique name.",
                    "Every flashcard needs to be part of a stack. If a stack is deleted, the same should happen with the flashcard.",
                    "You should use DTOs to show the flashcards to the user without the Id of the stack it belongs to.",
                    "When showing a stack to the user, the flashcard Ids should always start with 1 without gaps between them. If you have 10 cards and number 5 is deleted, the table should show Ids from 1 to 9.",
                    "After creating the flashcards functionalities, create a \"Study Session\" area, where the users will study the stacks. All study sessions should be stored, with date and score.",
                    "The study and stack tables should be linked. If a stack is deleted, it's study sessions should be deleted.",
                    "The project should contain a call to the study table so the users can see all their study sessions. This table receives insert calls upon each study session, but there shouldn't be update and delete calls to it."
                },
                Tips = new List<string>
                {
                    "Before starting to code, try creating tables and running a few CRUD queries in SQL Server to get familiar with SQL Server Studio.",
                    "For management of stacks, let the user choose the stack by name.",
                    "Think of the \"stacks\" and \"study\" areas almost as separate applications. The study area is merely using data from the stacks area."
                },
                LearningIntro = "If you have learned the basics of C# following the  <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE' target='_blank'>C# Foundations </a> article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
                LearningItems = new List<string>
                 {
                     "Using SQL Server.",
                     "Creating linked tables with SQL.",
                     "Using DTOs to create different versions of classes.",
                     "<a href='https://www.youtube.com/watch?v=bNetxDl40pM' target='_blank'>Pivoting Tables in SQL</a>"
                 },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Installing SQL Server",
                        ImgUrl = "icons8-sql-server-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This is the first project in the academy where we’ll be using SQL Server. <a href='https://docs.microsoft.com/en-us/sql/tools/visual-studio-code/sql-server-develop-use-vscode?view=sql-server-ver15'> You can work with SQL Server using Visual Studio.</a>. But I recommend you start using Microsoft SQL Server Management Studio. For this app, don’t use SQL Server EXPRESS, but only LOCAL DB. <a href='https://www.youtube.com/watch?v=QsXWszvjMBM'> Here’s a tutorial on how to install the studio</a>. And here’s a tutorial on <a href='https://www.youtube.com/watch?v=M5DhHYQlnq8'> how to connect to your localdb</a> "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Challenge",
                        ImgUrl = "icons8-courage-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want to expand on this project, here’s an idea. Try to create a report system where you can see the number of sessions per month per stack. And another one with the average score per month per stack. This is not an easy challenge if you’re just getting started with databases, but it will teach you all the power of SQL and the possibilities it gives you to ask interesting questions from your tables."
                            },
                            new Paragraph
                            {
                                Body = "Below’s a screenshot with an example of the finished report. You’ll need to learn about Pivoting Tables to complete this challenge. Reach out if you need help! "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "flashcards-8.png"
                            }
                        }
                    }
                },
                Screenshots = new List<string>
                {
                    "flashcards-1.png",
                    "flashcards-2.png",
                    "flashcards-3.png",
                    "flashcards-4.png",
                    "flashcards-5.png",
                    "flashcards-6.png",
                    "flashcards-7.png"
                }
            },
             new Project
            {
                Id = 15,
                Title = "Drinks Info",
                IconUrl = "drinks.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "drinks",
                Description = "Build a console app to consume an external API with HTTP Requests with C#",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.Drinks",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Often times developers work with third-party data. A very common way of accessing external vendor’s data is to make requests to their APIs (Application Programming Interface). Once we have access to their data, we can process in our application to suit our needs. Another common scenario is when an organisation has multiple independent applications that communicate amongst themselves. <a href='https://en.wikipedia.org/wiki/Microservices'>The so called microservices</a>."
                    },
                    new Paragraph
                    {
                        Body="In this application we will learn how to connect to an external API through HTTP requests using .NET’s class library. It‘s easier than you imagine! Luckily there are many public APIs out there. <a href='https://github.com/public-apis/public-apis'> Here’s a great list of public APIs for practice.</a>"
                    }
                },
                Requirements = new List<string>
                {
                    "You were hired by restaurant to create a solution for their drinks menu.",
                    "Their drinks menu is provided by an external company. All the data about the drinks is in the companies database, accessible through an API.",
                    "Your job is to create a system that allows the restaurant employee to pull data from any drink in the database.",
                    "You don't need SQL here, as you won't be operating the database. All you need is to create an user-friendly way to present the data to the users (the restaurant employees)",
                    "When the users open the application, they should be presented with the Drinks Category Menu and invited to choose a category. Then they'll have the chance to choose a drink and see information about it.",
                    "When the users visualise the drink detail, there shouldn't be any properties with empty values"
                },
                RequirementsConclusion = "Don't panic! We'll help! 😁",
                ResourcesIntro = "Here are the links for using HTTP calls with C# and to the Drinks API documentation:",
                Resources = new List<string>
                {
                    "<a href='https://www.thecocktaildb.com/api.php' target='_blank'>Cocktail Database</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient' target='_blank'>Microsoft Docs: Http Requests</a>",
                    "<a href='https://www.youtube.com/watch?v=fc7peZ-FHs4' target='_blank'>Video: Drinks Info App (FULL PROJECT)</a>"
                },
                Screenshots = new List<string>
                {
                    "drinks-1.png"
                }
            },
             new Project
            {
                Id = 16,
                Title = "Phone Book",
                IconUrl = "icons8-contact-book-512-150x150.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "phonebook",
                Description = "Now you have basic understanding of SQL, it’s time to learn the basics of Entity Framework with a CRUD Phone Book Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.Phonebook",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In the .NET ecosystem you’ll come across <a href='https://stackoverflow.com/questions/1279613/what-is-an-orm-how-does-it-work-and-how-should-i-use-one'>ORMs (Object-Relational Mappers)</a>, which helps you to deal with databases using objects. If you have searched for C# tutorials you’ve probably encountered technologies such as Dapper and Entity Framework. You’ll definitely be using one when you start working as a developer."
                    },
                    new Paragraph
                    {
                        Body="In this tutorial we’ll implement a very simple Phone Book so you can learn the basics of Entity Framework, the most popular ORM. Even though we at The C# Academy strongly believe C# students should learn raw SQL first and foremost, most .NET C# job applications demand Entity Framework. The good news is that EF’s basic operations are very simple to learn and you’ll be up and running very quickly. Let’s go!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record contacts with their phone numbers.",
                    "Users should be able to Add, Delete, Update and Read from a database, using the console.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "Your code should contain a base Contact class with AT LEAST {Id INT, Name STRING, Email STRING and Phone Number(STRING)}",
                    "You should validate e-mails and phone numbers and let the user know what formats are expected",
                    "You should use Code-First Approach, which means EF will create the database schema for you.",
                    "You should use SQL Server, not SQLite"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli'>Entity Framework Docs</a>",
                    "<a href='https://www.youtube.com/watch?v=tDiJdthMs1Q&list=PL4G0MUH8YWiDcv8EUWTbDxDlkSndfh-T0'>CRUD Console APP with EF on Youtube</a>"
                },
                ResourcesConclusion = "There are many other Youtube videos and blog articles about Entity Framework everything else you need. Don’t be ashamed to use Google!",
                Tips = new List<string>
                {
                    "Before starting the phone book app, finish the program in the Microsoft Documentation article without any changes and store in your Github repository for reference. Make sure you understand most of the code before you get started.",
                    "Don't forget to create a Github repository for your project from the beginning."
                },
                Challenges = new List<string>
                {
                    "Create a functionality that allows users to add the contact's e-mail address and send an e-mail message from the app.",
                    "Expand the app by creating categories of contacts (i.e. Family, Friends, Work, etc).",
                    "What if you want to send not only e-mails but SMS?"
                }
            },
             new Project
            {
                Id = 17,
                Title = "Shifts Logger",
                IconUrl = "icons8-nurse-256.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug="shifts-logger",
                Description = "Build an App for shift workers to log their hours. In this app you’ll learn how to build a Web API and consume it with a Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.ShiftsLogger",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="If you’ve been learning to code for more than five minutes, you probably heard about <a href='https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Client-side_web_APIs/Introduction'>'APIs'</a>. They’re at the core of back-end programming. In web development, their main job will be to communicate with databases using “endpoints”. From now on you’ll be creating APIs all the time and this acronym will forever be part of your vocabulary. "
                    },
                    new Paragraph
                    {
                        Body="In the <a href='project/15' target='blank'>Drinks Info App</a> we have created a program that consumed an external API. This time we will track a worker’s “shifts”. We’ll create an API and the console app that will consume it. When using Microsoft’s Documentation, often times you’ll come across Web APIs being developed with Entity Framework, which acts as layer between the “endpoints” and the actual database. "
                    },
                    new Paragraph
                    {
                        Body="This stack (Web API/EF) is very common in enterprise applications, but it’s important to know that  Web Apis can be developed using ADO.NET and Dapper. These data access solutions have the advantage of giving the developers more control over the SQL queries. In the end, all solutions are valid. Each has pros and cons and it comes down to personal preference. For this project, we will be using Entity Framework, as it takes care the basic CRUD operations we need as beginners. "
                    },
                    new Paragraph
                    {
                        Body="This project has as a requirement the use of Web APIs testing tools. In development you need a way to quickly test your endpoints without having to create a UI. These days, Swagger is already scaffolded into the .NET Core Web Api project so you can start using it as soon as you run your project. Postman is very complete external tool with an user interface that makes it very easy to store tests for later use, which saves a lot of development time. The learning curve for Postman is slightly steeper, but don’t skip it, it will pay off. "
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record a worker's shifts.",
                    "You need to create two applications: the Web API and the UI that will call it.",
                    "All validation and user input should happen in the UI app.",
                    "Your API's controller should be lean. Any logic should be handled in a separate \"service\".",
                    "You should use SQL Server, not SQLite",
                    "You should use the \"code first\" approach to create your database, using Entity Framework's migrations tool.",
                    "Your front-end project needs to have try-catch blocks around the API calls so it handles unexpected errors (i.e. the API isn't running or returns a 500 error.)"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Client-side_web_APIs/Introduction'>What are APIs?</a>",
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio'>Web API Docs</a>",
                      "<a href='https://learn.microsoft.com/en-us/shows/beginners-series-to-web-apis/what-are-web-apis-1-of-18--beginners-series-to-web-apis'>Web API Beginner's Series (Microsoft Learn)</a>",
                    "<a href='https://www.youtube.com/watch?v=IYWOWxw7dys'>Testing Web APIs with Swagger</a>",
                    "<a href='https://www.youtube.com/watch?v=FjgYtQK_zLE'>Postman Youtube Tutorial</a>"

                },
                Tips = new List<string>
                {
                    "If this is your first contact with .NET Web API, follow the tutorial closely using the Todo List data model and http-repl for testing. In a second moment, follow the tutorial one more time, this time following the project's requirements.",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "First, create the Web API project, then use Swagger and Postman to test it. Only then create the UI project.",
                    "You might be tempted to skip testing with Swagger and Postman. Don't make that mistake. These tools are essential for working with web apis in enterprise and your hiring managers will be unimpressed if you are not familiar with them.",
                    "Calculate the duration of the shift based on its start and end.",
                }
            },
             new Project
             {
                Id = 18,
                Title = "Exercise Tracker",
                IconUrl = "icons8-bench-press-96.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug="exercise-tracker",
                Description = "Learn the repository pattern, the most common design pattern for interaction with databases",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.ExerciseTracker",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="So far we have been developing our applications without thinking too much about their design. In software development, we’ll often use “general repeatable solutions to commonly occurring problems”, <a href='https://en.wikipedia.org/wiki/Software_design_pattern'>the so called design patterns</a>."
                    },
                    new Paragraph
                    {
                        Body="We will build an exercise tracker using the “Repository Pattern”, an almost universally used solution for data persistence. It creates a layer between business logic and data access, which helps us create more loosely-coupled, testable and maintainable applications. <b>You’ll be dealing with repositories on a daily-basis when you get your C# job!</b>"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record exercise data.",
                    "You should choose one type of exercise only. We want to keep the app simple so you focus on the subject you're learning and not on the business complexities.",
                    "You can choose raw SQL or Entity Framework for your data-persistence.",
                    "The model for your exercise class should have at least the following properties: {Id INT, DateStart DateTime, DateEnd DateTime, Duration TimeSpan, Comments string}",
                    "Your application should have the following classes: UserInput, ExerciseController, ExerciseService (where business logic will be handled) and ExerciseRepository. These classes might feel empty at first but they'll be needed in most applications as they grow.",
                    "You can choose between SQLite or SQLServer.",
                    "You need to use dependency injection to access the repository from the controller."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a target='blank' href='https://medium.com/@kerimkkara/implementing-the-repository-pattern-in-c-and-net-5fdd91950485'>Repository Pattern Docs</a>",
                    "<a target='blank' href='https://www.programmingwithwolfgang.com/repository-pattern-net-core/'>Repository Pattern Tutorial</a>",
                    "<a target='blank' href='https://www.youtube.com/watch?v=Jnv7hNNuTqs'>Repository Pattern with EF on Youtube</a>",
                    "<a target='blank' href='https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-usage'>Dependency Injection Tutorial</a>"
                },
                ResourcesConclusion = "There are many other Youtube videos and blog articles about the Repository Pattern. Google and ChatGPT are your best friends!",
                Tips = new List<string>
                {
                    "Don't forget to add validation to your app. ",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "You might come across the concept of Unit of Work in some tutorials. I suggest you don't use it, so you focus on learning how a single repository works.",
                    "Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern."
                },
                Challenges = new List<string>
                {
                    "To illustrate the separation provided by the repository pattern, create a different branch of your project where you'll replace Entity Framework by Dapper or ADO.NET in your repository. You'll notice that you won't need to touch your controller.",
                    "Create an application with two types of exercises (ex. weights and cardio), using EF for one and Raw SQL for the other"
                }
            },
             new Project
             {
                Id = 19,
                Title = "Sports Results Notifier",
                IconUrl = "icons8-sports-96.png",
                BannerUrl = "webcrawler.jpg",
                LanguageHeadings = new EnglishHeadings(),
                Slug="sports-results",
                Description = "Learn how to create a web crawler and send e-mails using C#",
                Area = Area.Console,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
                Level = Level.Orange,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.SportsResults",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="You’re getting close to the end of our beginner C# program. But before your graduation from this first phase you need to learn two very important tasks in programming: The ability to harvest data from non-api sources and the ability to send e-mails. Let’s create an application that will combine these two tasks."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should read sports data from a website once a day and send it to a specific e-mail address.",
                    "You don't need any interaction with the program. It will be a service that runs automatically.",
                    "The data should be collected from the Basketball Reference Website in the resources area.",
                    "You should use the Agility Pack library for scrapping."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://html-agility-pack.net/'>Agility Pack Docs</a>",
                    "<a target='_blank' href='https://www.c-sharpcorner.com/blogs/send-email-using-gmail-smtp'>Send An Email Using Gmail SMTP and C#</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=oMM0yzyi4Do'>Agility Pack Tutorial</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=wbBuB7-BaXw'>Another Agility Pack Tutorial</a>",
                    "<a target='_blank' href='https://www.basketball-reference.com/boxscores/'>Basketball Reference</a>"
                },
                ResourcesConclusion = "There are many other Youtube videos and blog articles about scrapping and sending an e-mail with C#. Google is your best friend! 🙂",
                Tips = new List<string>
                {
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "After the completion of this project, try to create your own scrapper from a different source and with a different business case.",
                    "Bear in mind that some websites don't authorise scrapping.",
                    "It's not simple to scrap data from websites generated dynamically with the help of Javascript frameworks. When you create your own project, be aware that it's easier to scrape from more traditional, simple, server-based ones."
                }
            },
             new Project
             {
                Id = 20,
                Title = "Excel Reader",
                IconUrl = "excel.png",
                Slug="excel-reader",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Learn how to read data from an Excel Sheet into a real database using SQL",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.ExcelReader",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now  that you have an initial foundation of C#, it’s time to tackle a very important task in programming. The ability to work with files.When working in a company, all sorts of documents will be generated using a variety of file types: .doc, .xls, .pdf, .csv, just to name a few of the most commonly used. "
                    },
                    new Paragraph
                    {
                        Body="Your job as a programmer is to create applications that will manipulate data “to and from” these files. In this project, we will transpose an excel table into an SQL database using a C# library."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application that will read data from an Excel spreadsheet into a database",
                    "When the application starts, it should delete the database if it exists, create a new one, create all tables, read from Excel, seed into the database.",
                    "You need to use EPPlus package",
                    "You shouldn't read into Json first.",
                    "You can use SQLite or SQL Server (or MySQL if you're using a Mac)",
                    "Once the database is populated, you'll fetch data from it and show it in the console.",
                    "You don't need any user input",
                    "You should print messages to the console letting the user know what the app is doing at that moment (i.e. reading from excel; creating tables, etc)",
                    "The application will be written for a known table, you don't need to make it dynamic.",
                    "When submitting the project for review, you need to include an xls file that can be read by your application."
                },
                ResourcesIntro = "The knowledge you gained from the previous three projects will be enough to complete this project.You’ll only need to find out how EPPlus Package works. <a href='https://www.youtube.com/watch?v=kBwmP-kLEEE'>Here's a good Youtube tutorial</a>. If it’s not enough search for further videos on Youtube and/or specific questions in StackOverflow 😁",
                Tips = new List<string>
                {
                    "Before anything else you’ll have to create an Excel table that will be stored in your main project folder. The more organised the easier it will be for your program to read it. The first row of your columns need to be the property names of your model class",
                    "Don't forget to create a Github repository for your project from the beginning.",
                    "Remember, this time you don’t need any user input. The only interaction your program will have with the user is to show the data from your database.",
                    "You could structure the program in three parts. One for database creation, one for reading from the file and return a list and the last to populate your database using the returned list"
                },
                Challenges = new List<string>
                {
                    "If you want to expand on this project, try to create a program that reads data from any excel sheet, regardless of the number of columns or the content of the header.",
                    "Add the ability to read from other types of files, i.e. csv, pdf, doc",
                    "Let the user choose the file that will be read, by inserting the path.",
                    "Add a functionality to write into files, you can also use EPPlus for that."
                }
            },
             new Project
             {
                Id = 21,
                Title = "Unit Testing",
                IconUrl = "icons8-test-tube-100.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug="unit-testing",
                Description = "The last piece of the puzzle before moving on to  front-end. Learn to test the business logic of your applications",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.UnitTests",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="We’re almost there! It’s been a long way and it’s almost time to celebrate your graduation from the Console Apps area. But there’s one final step: Unit Tests."
                    },
                    new Paragraph
                    {
                        Body="More likely than not (and hopefully) the organisation you’ll work will have systems that use automatic unit testing. They make sure everything is running properly before each deployment. The code covered by those tests won’t need to be tested manually every time a change is made, which is prone to errors and very expensive. A strong suite of unit tests helps developers write better code, more efficiently. So let's do it!"
                    }
                },
                Requirements = new List<string>
                {
                    "In this project, you'll create unit tests for the Coding Tracker App, the second project in the course",
                    "You'll need to create a CodingTracker.Tests project, parallel to your coding tracker and reference it in your csproj file",
                    "You'll only test the validation methods, making sure the app correctly prevents the user from giving incorrect inputs",
                    "You should use .NETs MSTest Library",
                    "You should test both correct and incorrect inputs"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://fortegrp.com/the-importance-of-unit-testing/'>The Importance of Unit Testing</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest'>MSTest Docs</a>",
                    "<a href='https://www.youtube.com/watch?v=HYrXogLj7vg'>Unit Testing C# Code on Youtube</a>"
                },
                Tips = new List<string>
                {
                    "Don't worry about integration or end-to-end tests, they're out of the scope of this project",
                    "Make sure the names of your tests are clear, even if they have to be long. \"WhenQuantityInputIsCorrect()\" is a good name, while \"QuantityTest\" doesn't have enough information.",
                    "In your test, you'll have to mock the tested service and call it's methods. Think of all possibilities of correct and incorrect inputs and test if the application handles them."
                }
            },
        };
    }
    internal static List<Project> GetProjectsInDutch()
    {
        var projects = GetProjects();

        return new List<Project>
        {
            new Project
             {
                Id = 53,
                Title = "Wiskundespel",
                IconUrl = projects.FirstOrDefault(p => p.Id == 53).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 53).BannerUrl,
                LanguageHeadings = new DutchHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 53).Slug,
                Description = "In je eerste project gaan je een wiskundespel maken om je kennis die je heeft opgebouwd in de Microsoft C# Foundations te versterken",
                Area = projects.FirstOrDefault(p => p.Id == 53).Area,
                Level = projects.FirstOrDefault(p => p.Id == 53).Level,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 53).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 53).Difficulty,
                DisplayOrder= projects.FirstOrDefault(p => p.Id == 53).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 53).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In je eerste project bouw je een heel eenvoudige wiskundespel-app. Als dit de eerste keer is dat je zelfstandig een project bouwt, raad ik je aan om gebruik te maken van de <a target='blank' href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> serie van C# Academy van ons C# Foundations</a>. Deze serie begeleidt je bij het maken van een console-app vanaf de basis, terwijl cruciale C#-concepten worden uitgelegd. Als je het al hebt bekeken, of als je al ervaring hebt met het maken van C#-applicaties, zal dit project een fluitje van een cent zijn. Maar het is nog steeds nuttig om jouw kennis te versterken."
                    },
                    new Paragraph
                    {
                        Body="Uitdagingen vind je aan het einde van dit project, en alle andere projecten in The C# Academy. Deze uitdagingen zijn geen vereisten. Jouw project wordt nog steeds goedgekeurd en je krijgt de bijbehorende xp-punten. De uitdagingen zullen echter versterken wat je hebt geleerd. Hoewel je misschien geen extra punten krijgt als je ze voltooit, word je elke keer dat je een uitdaging voltooit toch een betere ontwikkelaar."
                    }
                },
                Requirements = new List<string>
                {
                    @"Je moet een wiskundespel maken dat de 4 basisbewerkingen bevat",
                    @"Delingen mogen ALLEEN worden uitgevoerd op INTEGERS en de deeltal moeten van 0 tot 100 gaan. Voorbeeld: Uw app mag de deling 7/2 niet aan de gebruiker presenteren, omdat deze niet resulteert in een geheel getal.",
                    @"Gebruikers moeten een menu te zien krijgen waarin ze een bewerking kunnen kiezen",
                    @"Je moet eerdere spellen in een lijst opnemen en er moet een optie in het menu zijn waarmee de gebruiker de geschiedenis van eerdere spellen kan visualiseren.",
                    @"Je hoeft de resultaten niet in een database vast op te slagen. Zodra het programma wordt afgesloten, worden de resultaten verwijderd."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'>Wiskundespel Tutorial op Youtube (in Engels)</a>",
                },
                ResourcesIntro = "Als je eerdere C#-ervaring heeft, kan je dit project mogelijk zonder hulp voltooien. Als je dat niet doet, volg dan deze tutorial: ",
                ResourcesConclusion = "Je hoeft het tweede deel van deze tutorial (Een .NET Maui-app bouwen) niet te bekijken om dit project te voltooien. Alleen de Console-app is vereist",
                Tips = new List<string>
                {
                    "Vergeet niet om ALTIJD (ja, ALTIJD!) je code op Github te laten opslaan (of welk bronbeheer je ook gebruikt). Zo raakt je jouw werk niet kwijt en kan je er in de toekomst altijd naar teruggrijpen. Je bouwt je eigen bibliotheek op!",
                    "Overhaast de stappen niet, ook als deze tutorial makkelijk voor je. Zorg ervoor dat ke IEDER WOORD van de code begrijpt. Laat geen steen onberoerd.",
                    "Als je iets niet begrijpt, beweegt je de muis over de code en krijgt je uitleg over wat de term betekent. Als je het nog steeds niet begrijpt: Google is je beste vriend. Je vindt uitleg over vrijwel alles op forums zoals stackoverflow.com.",
                    "Als dit je eerste project is, raad ik aan om het twee keer te doen. Je zult verrast zijn hoeveel jouw retentie toeneemt en hoeveel hiaten er de eerste keer nog overbleven.",
                    "Ga na voltooiing van je project naar onze <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord-community</a> en schep erover op! Het is een zeer belangrijke stap om een project te voltooien en dat moet je vieren!"
                },
                Challenges = new List<string>
                {
                    "Probeer moeilijkheidsgraden te implementeren.",
                    "Voeg een timer toe om bij te houden hoe lang het duurt voordat de gebruiker het spel voltooit.",
                    "Voeg een functie toe waarmee de gebruiker het aantal vragen kan kiezen.",
                    "Creëer een 'Willekeurig spel'-optie waarbij de spelers vragen krijgen over willekeurige operaties",
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Bron controle",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als dit je eerste tutorial is, kom je misschien in de verleiding om deze stap over te slaan en te beginnen met coderen. Doe het niet, anders leer je het op de harde manier. Op een dag, nadat je vele uren aan een moeilijk probleem hebt gewerkt, kun je je werk niet meer opslaan in een bronbeheerrepository en om welke reden dan ook zal al het werk verloren gaan."
                            },
                            new Paragraph
                            {
                                Body = "Maak er een gewoonte van om elke regel code die je ooit schrijft, op te slaan. Ik beloof dat het je veel kopzorgen zal besparen. Alle serieuze ontwikkelaars slaan hun werk op in een back-uprepository. De meest gebruikte is GitHub. Maak een account aan als je dat nog niet hebt gedaan."
                            },
                            new Paragraph
                            {
                                Body="1. Ga in Visual Studio naar Git > Git-repository maken<br>2. Voer jouw inloggegevens in<br>3. Klik op Maken en Pushen."
                            },
                            new Paragraph
                            {
                                Body="✅ Klaar! Je repository is klaar om te gebruiken. Vergeet niet om jouw wijzigingen na elke stap vast te leggen en Pushen"
                            }, new Paragraph
                            {
                                Body="Je kunt nog een stap verder gaan en leren hoe je Github met Visual Studio kunt integreren door deze tutorial te bekijken:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Codebeoordeling",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als je wilt dat jouw code wordt beoordeeld door een lid van de C# Academy, in plaats van jouw eigen repository te maken, <a href='article/52/code-reviews' target='blank'>moet je dit artikel volgen</a>, waar je kan leren hoe je een fork kan maken vanuit onze basisrepository."
                            }
                        }
                    },
                }
            },
            new Project
            {
                Id = 11,
                Title = "Rekenmachine",
                IconUrl = projects.FirstOrDefault(p => p.Id == 11).IconUrl,
                Slug = projects.FirstOrDefault(p => p.Id == 11).Slug,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 11).BannerUrl,
                LanguageHeadings = new DutchHeadings(),
                Level = projects.FirstOrDefault(p => p.Id == 11).Level,
                Description = "We gaan een rekenmachine bouwen met behulp van Microsoft's Documentatie",
                Area = projects.FirstOrDefault(p => p.Id == 11).Area,
                Difficulty = projects.FirstOrDefault(p => p.Id == 11).Difficulty,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 11).ExperiencePoints,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 11).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 11).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In ons tweede project gaan we een rekenmachine console app bouwen met behulp van Microsoft's Documentatie. Dit project is op vlak van moeilijkheid gelijkaardig als ons eerste project, met het verschil dat we nu enkele belangrijke zaken aanleren zoals werken met meerdere projecten in een solution, bestanden wegschrijven en debuggen. Het is ook een goede oefening voor een heel belangrijke eigenschap: het volgen van geschreven documentatie. Dit is iets wat je op regelmatige basis zult moeten doen als een professionele developer, dus het is essentieel om vertrouwd te geraken met het toepassen van geschreven instructies wanneer we software ontwikkelen."
                    }
                },
                Requirements = new List<string>
                {
                    @"Voltooi volgende tutorial (deel 1 en 2): <a href='https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022'>Creëer een Rekenmachine applicatie (Microsoft Docs)</a>. Je vindt de link naar deel twee onderaan de pagina."
                },
                RequirementsIntro = "Dit project heeft slechts één vereiste:",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-mac'>Visual Studio voor Mac</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0'>Visual Studio Code</a>"
                },
                ResourcesIntro = "De instructies in dit project zijn gebaseerd op Visual Studio voor Windows. De code die je gebruikt blijft dezelfde ongeacht welke code editor je gebruikt. Maar hoe je een nieuw project aanmaakt, verschilt een beetje. Hier vind je links terug hoe je een console app aanmaakt in de verschillende editors: ",
                Tips = new List<string>
                {
                    "Haast je niet doorheen de tutorial, ook al is deze tutorial gemakkelijk voor jou. Zorg er altijd voor dat je IEDER WOORD verstaat uit je code. Dit is heel belangrijk.",
                    "Wanneer je iets niets begrijpt, ga dan op de code staan met je cursor, er zal een uitleg verschijnen bij elke term met uitleg. Begrijp je de code nog steeds niet dan zijn Google of ChatGPT je beste vrienden om meer uitleg te vinden. Je kan ook altijd uitgebreide uitleg vinden over zowat elk item op diverse forums zoals stackoverflow.com.",
                    "Sla zeker het debugging gedeelte niet over in deel twee. Dit is één van de meest belangrijke eigenschappen die je zal aanleren in deze tutorial en van vitaal belang in onze toekomstige projecten."
                },
                 Challenges = new List<string>
                {
                    "Creëer een functie die bijhoudt hoeveel keer de rekenmachine is gebruikt.",
                    "Creëer een lijst die de laatste berekeningen bewaart. En geef de gebruiker de mogelijkheid om deze lijst te verwijderen.",
                    "Sta de gebruiker toe om de berekeningen uit deze lijst te herbruiken om nieuwe berekeningen mee uit te voeren.",
                    "Voeg enkele extra berekeningsmogelijkheden toe: het nemen van de vierkantswortel, het nemen tot de n-de macht, x10, de Trigonometrie functies toepassen.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Code Review",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als je wil dat je code beoordeeld wordt door een lid van de C# Academy, werk dan niet vanuit een eigen repository maar <a href='article/52/code-reviews' target='blank'>volg dit artikel</a>, hierin leer je hoe je een fork maakt van onze basis repository waardoor we jouw project kunnen reviewen."
                            }
                        }
                    }
                }
            },
             new Project
            {
                Id = 12,
                Title = "Gewoontelogger",
                IconUrl = projects.FirstOrDefault(p => p.Id == 12).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 12).BannerUrl,
                LanguageHeadings = new DutchHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 12).Slug,
                Description = "Bouw een logger voor een gewoonte naar keuze. Leer hoe je met een SQLite database kunt communiceren en hoe je gebruikersinvoer kunt verkrijgen en valideren",
                Area = projects.FirstOrDefault(p => p.Id == 12).Area,
                Level = projects.FirstOrDefault(p => p.Id == 12).Level,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 12).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 12).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 12).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 12).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Dit is een heel eenvoudige app die je leert hoe je <a href='https://en.wikipedia.org/wiki/Create,_read,_update_and_delete'>CRUD-bewerkingen</a> kunt uitvoeren op een echte database. Deze bewerkingen vormen de basis van webontwikkeling en je zal ze gedurende jouw hele carrière in bijna elke app gebruiken. We denken dat het erg belangrijk is om dit vanaf het begin van je reis te doen, omdat alles wat vanaf hier zal gebeuren alleen maar de complexiteit aan CRUD-operaties toevoegt. Hoe complex en luxe de app die je bouwt ook is, uiteindelijk komt het allemaal neer op het uitvoeren van CRUD-aanroepen naar een database."
                    },
                    new Paragraph
                    {
                        Body="Daarvoor zul je heel eenvoudige <a href='https://en.wikipedia.org/wiki/SQL'>SQL-commando’s</a> moeten leren. Ik weet dat het eng klinkt, maar je zult versteld staan van hoe weinig SQL-kennis je nodig hebt om een full-stack-app te bouwen. Maak je geen zorgen, we nemen je bij de hand en tegen het einde heb je je eerste volledig functionerende CRUD-app voltooid. De meest gebruikelijke manieren om een SQL-database aan te roepen met C# zijn via <a href='https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/'>ADO.NET</a>, Dapper en Entity Framework. We zullen beginnen met het gebruik van ADO.NET, omdat dit het dichtst bij ruwe SQL ligt."
                    },
                    new Paragraph
                    {
                        Body="Als je denkt dat dit project te moeilijk voor je is en je hebt geen idee waar je moet beginnen, dan heb je waarschijnlijk gelijk. Het kan zijn dat je extra hulp nodig heeft om zelf een echte applicatie te bouwen. Als dat het geval is, <a href='https://youtu.be/d1JIJdDVFjs'>bekijk dan de video-tutorial voor dit project</a> en kom dan terug en probeer het zelf opnieuw. Het is prima om je verloren te voelen, aangezien de meeste beginnerscursussen je niet echt leren hoe je iets moet bouwen."
                    },
                    new Paragraph
                    {
                        Body="Laten we gaan!"
                    }
                },
                Requirements = new List<string>
                {
                    "Dit is een applicatie waarbij je één gewoonte registreert.",
                    "Deze gewoonte kan niet worden gevolgd op basis van de tijd (bijvoorbeeld het aantal uren slaap), maar alleen op basis van de hoeveelheid (bijvoorbeeld het aantal waterglazen per dag)",
                    "De applicatie moet gegevens opslaan en ophalen uit een echte database",
                    "Wanneer de applicatie start, zou deze een sqlite-database moeten maken, als deze niet aanwezig is.",
                    "Er moet ook een tabel in de database worden aangemaakt, waarin de gewoonte wordt geregistreerd.",
                    "De app moet de gebruiker een menu met opties tonen.",
                    "De gebruikers moeten hun geregistreerde gewoonte kunnen invoegen, verwijderen, bijwerken en bekijken.",
                    "Je moet alle mogelijke fouten afhandelen, zodat de applicatie nooit crasht.",
                    "De applicatie mag alleen worden beëindigd als de gebruiker 0 invoert.",
                    "Je mag alleen met de database communiceren met behulp van onbewerkte SQL. Je mag geen mappers zoals Entity Framework gebruiken.",
                    "Jouw project moet een README-bestand bevatten waarin je uitlegt hoe jouw app werkt. Hier is een mooi voorbeeld:"
                },
                RequirementsConclusion = "<a href='https://github.com/thags/ConsoleTimeLogger'>Github-project met een voorbeeld van een netjes README-bestand.</a><br>Geen paniek! Wij zal verder helpen! 😁",

                Tips = new List<string>
                {
                    "Test jouw SQL-opdrachten in DB Browser voordat je ze in jouw applicatie gebruikt.",
                    "Als je wilt, mag je alle code in één enkele klasse bewaren.",
                    "Gebruik een switch-instructie voor de gebruikersinvoermenu's.",
                    "Vergeet de validatie van de gebruikersinvoer niet: controleer op onjuiste datums. Wat gebeurt er als er een menuoptie wordt gekozen die niet beschikbaar is? Wat gebeurt er als de gebruikers een string invoeren in plaats van een getal?"
                },
                 Challenges = new List<string>
                {
                    "Laat de gebruikers hun eigen gewoonten creëren om bij te houden. Dat vereist dat je ze de meeteenheid van elke gewoonte laat kiezen.",
                    "Vul data automatisch bij in de database wanneer de database voor de eerste keer wordt aangemaakt, waarbij een paar gewoonten worden gegenereerd en honderd records met willekeurig gegenereerde waarden worden ingevoegd. Dit is vooral handig tijdens de ontwikkeling, zodat je niet elke keer dat je de database maakt, gegevens opnieuw hoeft in te voeren.",
                    "Creëer een rapportfunctionaliteit waar de gebruikers specifieke informatie kunnen bekijken (bijvoorbeeld: hoe vaak heeft de gebruiker in een jaar gelopen? Hoeveel km?) Met SQL kunt u zeer interessante dingen uit jouw database vragen."
                },
                 LearningIntro = "Als je de basisprincipes van C# heeft geleerd uit het <a href='article/8/foundations' target='blank'>C# Foundations</a> artikel, zal je alle basistechnieken moeten kennen die nodig zijn om dit project te voltooien. Hier is een lijst met de dingen die je nodig heeft om aan de vereisten te voldoen:",
                 LearningItems = new List<string>
                 {
                     "Gebruikersinvoer van de console inlezen.",
                     "Berichten in de console weergeven",
                     "Nuget-pakketten installeren (ASP.NET-bibliotheken die je helpen bij het schrijven van jouw applicatie).",
                     "Basisbesturingsstroom met 'if-else' en 'switch-statements'",
                     "Verbinding maken met een SQLite-database.",
                     "Basisprincipes van SQL (de taal die je gebruikt om met de database te communiceren). Als je wat SQL wilt trainen voordat je aan de slag gaat, <a href='https://www.w3schools.com/sql/sql_exercises.asp'>is dit een uitstekende plek</a>."
                 },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Het project creëren",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Voor deze zelfstudie is vereist dat je jouw .NET-omgeving al hebt ingesteld. Als je dat nog niet hebt gedaan, bekijk dan <a href='article/7/setting-up' target='blank'>dit artikel</a> met de eerste stappen. Als je absoluut een andere IDE wilt gebruiken, laat het me weten."
                            },
                            new Paragraph
                            {
                                Body = "1. Kies in Visual Studio Nieuw Project Maken. Als je Visual Studio Code gebruikt, kan je mij laten weten of je problemen hebt bij het maken van het project.<br>2. Zoek naar Console-applicatie en klik op Volgende.<br>3. Kies een projectnaam en een locatie en klik op Volgende.<br>3. Kies het nieuwste framework (Net 8 op het moment van deze tutorial) en klik op Maken.<br>4. Start jouw applicatie door op de groene afspeelknop bovenaan het scherm te klikken."
                            },
                            new Paragraph
                            {
                                Body = "Een CLI (command line interface) wordt geopend, 'Hello World' wordt afgedrukt en daarna zal de applicatie zichself afsluiten. Dat betekent dat jouw applicatie-ASP.NET-omgeving en jouw applicatie naar behoren werken."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Uw werkdirectory wijzigen",
                        ImgUrl = "icons8-folder-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Op deze manier bouwt .NET jouw project in uw hoofdmap. Standaard wordt jouw project in een bin-map gebouwd en om het eenvoudig te houden willen we dat vermijden. Er wordt dan een map Properties gemaakt met een <b>launchsettings.json</b>-bestand met daarin jouw configuratiegegevens. Dit is alleen een belangrijke stap voor toepassingen die Sqlite gebruiken, omdat je wil dat de database in dezelfde map van de toepassing wordt gemaakt om verwarring te voorkomen."
                            },
                            new Paragraph
                            {
                                Body = "Klik daarvoor op het punthaakje naast de naam van jouw app in het bovenste menu, klik op {nameoftheapp} Debug Properties en kopieer het pad van uw directory naar het veld 'Working Directory'. Om erachter te komen wat jouw pad is, kan je met de rechtermuisknop op jouw project klikken in de Solution Explorer en op \"Volledig pad kopiëren\" of het opzoeken in jouw Bestandenverkenner. Als je Mac/Visual Studio Code gebruikt, neem dan contact met mij op en ik zal je vertellen hoe je dit moet doen. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-1.png"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Begin met coderen!",
                        ImgUrl = "icons8-coding-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Elke keer dat je jouw app start, moet deze controleren of er een database is. Als dat niet het geval is, wordt er een gemaakt samen met een tabel waarin je jouw gegevens opslaat. Als je jouw database extern verwijdert, wordt er altijd een aangemaakt. Als de database bestaat, gaat deze naar de volgende stap: lees de gebruikersinvoer in en kies wat je wilt doen. Iets zoals dit:"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "habit-menu.png"
                            },
                            new Paragraph
                            {
                                Body = "Bij de ontwikkeling van ASP.NET C# is het gebruik van SQL Server heel gebruikelijk. Maar we zullen het hier niet gebruiken. SQLite is een superlicht databasesysteem en het is belangrijk om ermee vertrouwd te raken voordat je in de SQL-server springt."
                            },
                            new Paragraph
                            {
                                Body = "Je moet in jouw programma een sqlite-bestand laten maken. Je kan dat bestand extern visualiseren met behulp van een kleine applicatie. <a href='https://www.youtube.com/watch?v=HQKwgk6XkIA'>Hier is een link naar een eenvoudige SQLite-tutorial</a>."
                            },
                            new Paragraph
                            {
                                Body = "Dit is waar jouw daadwerkelijke code begint! Je bent een tijdje op jezelf aangewezen. Als je vastloopt, blijf het proberen, <a href='article/6/getting-help' target='blank'>onthoud de stappen om fouten in jouw app op te sporen/de blokkade op te lossen</a>. En als het je uiteindelijk niet lukt, neem dan contact op met onze <a href='https://discord.gg/JVnwYdM79C'>Discord Community</a> of met mezelf, dan helpen we je verder!"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Video uitleg",
                        ImgUrl = "external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als je de weg helemaal kwijt zijn geraakt, is het prima om een video-tutorial te bekijken om je weer op de weg te helpen. Hier leer je alle onderdelen met elkaar te verbinden om een echte applicatie te bouwen. Als je klaar bent, zorg er dan voor dat je het zelf opnieuw probeert, zonder de hulp van de video, zodat je de nieuw verworven kennis internaliseert."
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/d1JIJdDVFjs"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Bron controle",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als dit je eerste tutorial is, kom je misschien in de verleiding om deze stap over te slaan en te beginnen met coderen. Doe het niet, anders leer je het op de harde manier. Op een dag, nadat je vele uren aan een moeilijk probleem hebt gewerkt, kun je je werk niet meer opslaan in een bronbeheerrepository en om welke reden dan ook zal al het werk verloren gaan."
                            },
                            new Paragraph
                            {
                                Body = "Maak er een gewoonte van om elke regel code die je ooit schrijft, op te slaan. Ik beloof dat het je veel kopzorgen zal besparen. Alle serieuze ontwikkelaars slaan hun werk op in een back-uprepository. De meest gebruikte is GitHub. Maak een account aan als je dat nog niet hebt gedaan."
                            },
                            new Paragraph
                            {
                                Body="1. Ga in Visual Studio naar Git > Git-repository maken<br>2. Voer jouw inloggegevens in<br>3. Klik op Maken en Pushen."
                            },
                            new Paragraph
                            {
                                Body="✅ Klaar! Je repository is klaar om te gebruiken. Vergeet niet om jouw wijzigingen na elke stap vast te leggen en Pushen"
                            }, new Paragraph
                            {
                                Body="Je kunt nog een stap verder gaan en leren hoe je Github met Visual Studio kunt integreren door deze tutorial te bekijken:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Codebeoordeling",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als je wilt dat jouw code wordt beoordeeld door een lid van de C# Academy, in plaats van jouw eigen repository te maken, <a href='article/52/code-reviews' target='blank'>moet je dit artikel volgen</a>, waar je kan leren hoe je een fork kan maken vanuit onze basisrepository."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Volgende stap: Desktop-app",
                        ImgUrl = "icons8-staircase-80.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als je de <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>hele C# Foundation-cursus</a> hebt bekeken, heb je al een Math Game Desktop-app gemaakt met behulp van de geweldige .NET MAUI. Het is een goede oefening om een desktop Habit Tracker-app te bouwen met dezelfde functionaliteit die je voor deze console-app hebt gemaakt. Er zullen enkele uitdagingen zijn, maar je beschikt al over alle benodigde vaardigheden. En onthoud: als je vastloopt, neem dan contact op met onze <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord-community</a> en we zullen je helpen!"
                            }
                        }
                    },
                }
            },
             new Project
             {
                Id = 13,
                Title = "Codeer Logger",
                IconUrl = projects.FirstOrDefault(p => p.Id == 13).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 13).BannerUrl,
                LanguageHeadings = new DutchHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 13).Slug,
                Level = projects.FirstOrDefault(p => p.Id == 13).Level,
                Description = "Log het aantal uur dat je spendeert aan coderen. Leer omgaan met datums, hoe maak je gebruik van het opsplitsen van taken ('seperation of concerns'), en maak voor het eerst gebruik van een externe bibliotheek om je applicatie beter te maken.",
                Area = projects.FirstOrDefault(p => p.Id == 13).Area,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 13).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 13).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 13).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 13).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Deze app lijkt heel erg op de vorige app die we gemaakt hebben: <a href='article/12/habit-logger' target='blank'>Gewoontelogger</a>. Het is de bedoeling om hetgeen we geleerd hebben te versterken door middel van herhaling en het opnieuw toepassen van de opgedane kennis, maar dan met een klein beetje meer uitdaging. "
                    },
                    new Paragraph
                    {
                        Body="Deze keer gaan we moeten omgaan met de extra complexiteit die Datum en Tijd met zich meebrengen. Dit is in elke applicatie een echte uitdaging. Je zal ook voor het eerst gebruik moeten maken van een externe bibliotheek. In een professionele programmeeromgeving zal je dikwijls gebruik maken van oplossingen van andere programmeurs. Waarom zou je alles van begin af aan coderen wanneer het reeds publiekelijk beschikbaar is. Dat is het mooie aan het internet, we hebben hierdoor toegang tot een fantastische codeer gemeenschap."
                    },
                    new Paragraph
                    {
                        Body="In de eerste applicatie hadden we geen vereisten over de organisatie van onze code. Deze keer echter, ga je moeten gebruik maken van <a href='https://en.wikipedia.org/wiki/Separation_of_concerns'>separation of concerns</a>, één van de meest belangrijke principes in modern programmeren. Vanaf nu gaan we de concepten van Object Georiënteerd Programmeren toe passen. Je zal ook gebruik moeten maken van een 'Model' of 'Entity', om de data die je moet verwerken weer te geven. In dit geval je, codeer sessies. Laten we starten!"
                    }
                },
                Requirements = new List<string>
                {
                    "Deze applicatie heeft dezelfde vereisten als de vorige, behalve dat we deze keer onze dagelijkse tijd die we spenderen aan coderen gaan loggen.",
                    "Om onze data in de console weer te geven gaan we gebruik maken van de \"Spectre.Console\" library.",
                    "Het is vereist om onze verschillende classes in aparte bestanden te plaatsen (bv. UserInput.cs, Validation.cs, CodingController.cs)",
                    "Maak de gebruiker duidelijk in welk specifiek formaat datum en tijd opgegeven moeten worden. En sta geen afwijkingen op dit formaat toe.",
                    "Maak een configuratie bestand aan dat een link naar je databank en connectiestring bevat.",
                    "Maak een \"CodingSession\" class aan in een apart bestand. Het bevat alle eigenschappen van je code sessie: Id, StartTijd, EindTijd, Duratie",
                    "De gebruiker is niet toegestaan om de duratie van de sessie in te vullen. Deze moet berekend worden aan de hand van de Start en EindTijd, in een aparte \"CalculateDuration\" methode.",
                    "De gebruiker kan de start en eindtijd manueel ingeven.",
                    "Je moet gebruik maken van het Dapper ORM om de data te raadplegen in plaats van ADO.NET. (Deze vereiste is ingevoerd sinds februari 2024)",
                    "Wanneer je data van de databank ophaalt, kan je geen gebruik maken van een anoniem object, je moet de tabel lezen door middel van een List van CodingSessions."
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://spectreconsole.net/'>Spectre Console documentatie</a>.",
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Configuratie Manager gebruiken</a>",
                    "<a target='_blank' href='https://stackoverflow.com/questions/3719/how-to-validate-a-datetime-in-c'>Datum en tijd omzetten in C#</a>",
                    "<a target='_blank' href='https://www.learndapper.com/'>Dapper Handleiding</a>.",
                },
                ResourcesIntro = "Wanneer je de basis van C# geleerd hebt via <a href='article/8/foundations' target='blank'>C# Foundations</a>, en je de <a href='article/12' target='blank'>GewoonteLogger</a> app hebt gemaakt, dan zou je alle basis technieken moeten kennen om dit project tot een goed einde te brengen. Hier is een lijst met extra hulpbronnen die je mogelijk nodig hebt:",
                Tips = new List<string>
                {
                    "Je mag zelf kiezen in welke volgorde je de app bouwt, maar wij raden deze volgorde aan: configuratie bestand, model, databank/tabel creatie, CRUD controller (waar de verschillende handelingen plaats vinden), visualiseren van de tabel en tot slot: valideren van de data.",
                    "Sqlite ondersteunt geen datums. Wij raden aan om de datum in een string te bewaren in de databank en deze in C# om te zetten naar een datum. Je zal deze moeten omzetten naar een datum om de duratie te berekenen.",
                    "Vergeet niet van je wijzigingen regelmatig door te sturen naar GitHub. Zeker wanneer je stopt.",
                    "Vergeet de gebruikers input niet te valideren. Controleer op foutieve datums. Wat gebeurt er wanneer er een menuoptie gekozen wordt dat niet bestaat? Wat gebeurt er wanneer een gebruiker een string invoert, terwijl de app een nummer verwacht? De eindtijd kan niet voor de start tijd liggen."
                },
                 Challenges = new List<string>
                {
                    "Voeg de mogelijkheid toe om een codeersessie bij te houden door middel van een stopwatch zodat je een sessie kunt loggen terwijl ze plaats vindt.",
                    "De gebruiker kan zijn codeer sessie filteren per periode (op basis van weken, dagen, jaren) en dit oplopend en aflopend.",
                    "Genereer rapporten waar de gebruikers hun totale en gemiddelde tijd kunnen zien per periode.",
                    "Zorg dat een gebruiker een doel tijd kan opgeven. Toon hoe ver ze van hun doel zitten, samen met hoeveel uren per dag ze zouden moeten coderen om hun doel tijd te bereiken. Je kan dit via een SQL-query doen of via C#.",
                 },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Een configuratie bestand aanmaken",
                        ImgUrl = "external-configuration-computer-itim2101-lineal-color-itim2101-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In geavanceerde applicaties worden configuratie bestanden bewaart in een xml bestand. Op deze manier wordt het gemakkelijker om je applicatie te configureren voor productie. Het is niet absoluut noodzakelijk in dit project, maar het is niet moeilijk om te leren en zo geraak je ermee vertrouwd vanaf het begin. Het maakt je code schoner en meer georganiseerd. <a href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Bekijk deze documentatie</a> en indien nodig, zoek achter “configuration file C#” op YouTube. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Maak een Desktop App",
                        ImgUrl = "icons8-desktop-computer-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Als je de volledige <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'> C# Foundation course </a> hebt bekeken, dan heb je reeds de desktop versie van het Rekenspel gemaakt met .NET MAUI. Het is een goede oefening om deze Codeer Logger na te maken in MAUI. Er zullen wat uitdagingen zijn, zeker wanneer je een timer wil bouwen, maar je beschikt reeds alle kennis om dit tot een goed einde te brengen. En onthoud, wanneer je vast zit, je altijd kan rekenen op onze hulp via onze <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a>. Wij zullen altijd proberen je te helpen!"
                            }
                        }
                    }
                }
            }
        };
    }
    internal static List<Project> GetProjectsInKorean()
    {
        var projects = GetProjects();

        return new List<Project>
        {
             new Project
             {
                Id = 53,
                Title = "수학 퀴즈 게임",
                IconUrl = projects.FirstOrDefault(p => p.Id == 53).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 53).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 53).Slug,
                Description = "첫 번째 프로젝트에서는 기초 부분에서 이미 배운 내용을 복습하기 위해 '수학 퀴즈 게임'을 만들어 보겠습니다.",
                Area = projects.FirstOrDefault(p => p.Id == 53).Area,
                Level = projects.FirstOrDefault(p => p.Id == 53).Level,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 53).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 53).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 53).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 53).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="첫 번째 프로젝트로는 간단한 수학 게임 어플을 만들어 볼텐데요. 이런 프로젝트를 혼자서 해 보는 것이 처음이라면, 저희 C# 아카데미의 자료 내용 및 영상 튜토리얼을 참고해보세요. <a target='blank' href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> C# 기초 영역 시리즈</a>.이 시리즈에서는 중요한 C# 컨셉을 배울 수 있을 뿐만 아니라, 콘솔 어플을 만드는 과정을 처음부터 배울 수 있습니다. 영상 자료를 이미 보셨거나 C# 어플을 만들어 보신 경험이 있으시다면 이 프로젝트는 쉽게 느껴지실 수도 있지만 그래도 한 번 짚고 넘어가는게 도움이 될 것입니다."
                    },
                    new Paragraph
                    {
                        Body="이번 프로젝트를 비롯한 C# 아카데미에 있는 다른 모든 프로젝트의 끝 부분에는 도전해보실 수 있는 챌린지가 수록되어 있습니다. 이 챌린지들은 과제 완료의 필수 요소는 아닙니다. 챌린지 과제를 풀지 않고도 프로젝트를 완성하실 수 있고, 완성 후에는 그에 따른 경험치 포인트를 얻게 됩니다. 하지만 챌린지를 풀어보는 게 배운 내용을 복습하는 데 도움이 되실 겁니다. 비록 챌린지 과제를 푼다고 경험치 포인트들이 추가로 쌓이는 것은 아니지만, 챌린지들을 하나하나 풀어나갈 때마다 더욱 더 뛰어난 개발자로 성장할 수 있다는 것을 명심해주세요."
                    }
                },
                Requirements = new List<string>
                {
                    @"기초 사칙연산(덧셈, 뺄셈, 곱셈, 나눗셈)을 할 수 있는 수학 퀴즈 게임 어플을 만들어 보겠습니다",
                    @"0에서 100까지의 숫자에서 덧셈 뺄셈 곱셈 나눗셈을 물어보는 수학 퀴즈 게임 어플을 만드는 데, 나누기의 결과 값은 정수(Integer)로만 나올 수 있게 하고 피제수(나누어지는 수)는 0에서 100까지로 설정하셔야 입니다. 예: 7 나누기 2 의 값은 정수(integer)로 딱 안 떨어지기 때문에 만드시는 수학 게임 어플에서 문제로 내지 않아야 합니다.",
                    @"어플을 사용하는 유저에게 어떤 사칙연산을 풀지 고를 수 있는 메뉴가 있어야 합니다",
                    @"리스트(List)에 전에 풀은 퀴즈들의 데이터를 기록하고, 그 데이터를 유저가 시각화해서 볼 수 있는 기능이 메뉴 안에 있어야 합니다",
                    @"저장된 데이터를 따로 데이터베이스에 저장할 필요는 없습니다. 프로그램이 닫히면 데이터가 삭제되도록 하세요."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'>수학 게임 튜토리얼 유튜브 영상</a>",
                },
                ResourcesIntro = "C#을 사용해 보신 경험이 있다면, 이 프로젝트를 특별한 도움을 받지 않고도 완성할 수 있을 것입니다. 그렇지 않으시다면, 이 튜토리얼 영상을 참고 부탁드립니다: ",
                ResourcesConclusion = "이 프로젝트를 완료하기 위해서는 튜토리얼 영상에 제 2장 (.NET 마우이 어플을 사용하기)은 스킵하셔도 괜찮습니다. 콘솔 앱 부분만 보시면 됩니다",
                Tips = new List<string>
                {
                    "꼭 깃허브(혹은 현재 사용하시는 소스 컨트롤 엔진)에 자신이 코딩한 것을 저장하는 것을 절대 까먹으시면 안됩니다.꼭 입니다. 그래야 자신이 써놓은 코딩을 잃어버리는 일이 없고, 나중에 참고용으로 쓸 수 있기 때문입니다. 이런 식으로 나 자신의 코딩 데이터베이스를 하나하나 쌓아나가는 것이니까요!",
                    "혹시 이 튜토리얼이 쉽게 느껴지시더라도 하나하나 꼼꼼히 모든 단계를 밟아가며 프로젝트를 진행해주세요. 나오는 코딩 한 줄 한 줄 다 이해할 수 있도록 하고 다 하나하나 체크해보세요.",
                    "코딩하실 때 모르는 것이 있으면 마우스를 그 코딩에 갖다대보시면 코딩의 설명란이 뜹니다. 그래도 모르겠으시면 구글 검색을 해보세요. 웬만한 것은 스택오버플로우(stackoverflow) 같은 사이트에서 원하시는 설명을 찾을 수 있을 것입니다.",
                    "이제 처음으로 해 보는 프로젝트라면, 이 프로젝트를 다시 한 번 해보시는 것을 추천드립니다. 처음할 때는 잘 몰랐던 것을 2번째에는 잘 알 수 있고, 배운 내용을 정말 자신의 것으로 만들 수 있을 겁니다.",
                    "프로젝트를 완성하시면, 저희 <a target='_blank' href='https://discord.gg/JVnwYdM79C'>디스코드 커뮤니티</a>에 오셔서 자랑해보세요! 프로젝트를 완성 후에는 성취감을 나누며 함께 축하하는 자리를 갖는 것도 굉장히 중요합니다"
                },
                Challenges = new List<string>
                {
                    "난이도 설정을 추가해보세요",
                    "유저가 게임을 끝낼때까지 얼마나 걸리나 보는 타이머를 추가해보세요",
                    "유저가 게임에 나오는 문제의 개수를 정할 수 있게 기능을 추가해보세요",
                    "랜덤게임 옵션을 추가해서 사칙연상문제의 종류가 랜덤하게 나오도록 해보세요",
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "소스 컨트롤",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "이게 처음으로 하시는 튜토리얼이면, 소스 컨트롤은 나중에 하고 코딩에 바로 들어가시고 싶으실텐데요. 그러다가는 큰 사고를 겪게 됩니다. 하루종일 몇 시간씩 들여 코딩한게 제대로 된 소스 코드 리포지토리에 저장되지 않으면 다 날아가버릴 수도 있습니다. "
                            },
                            new Paragraph
                            {
                                Body = "코딩 한 줄 한 줄 적어나갈 때마다 항상 저장을 하는 습관을 가지세요. 장담하건데 나중에 머리 아픈 일이 줄어들겁니다. 실력있는 개발자는 모두 항상 자신의 코딩을 백업해 놓습니다. 가장 많이 쓰이는게 깃허브인데요. 회원가입을 아직 하지 않았다면 회원가입 해 놓으세요."
                            },
                            new Paragraph
                            {
                                Body="1. 비쥬얼 스튜디오에서, 깃 > 깃 리포지토리 만들기 <br>2. 아이디하고 비밀번호 입력<br>3. 만들고 푸쉬하기(create and push)를 클릭."
                            },
                            new Paragraph
                            {
                                Body="✅ 다 했습니다! 이제 리포지토리가 준비가 되었습니다. 매번 코딩하실 때마다 변경된 코딩을 커밋하고 푸쉬하기(commit and push) 하는 것을 잊지 마세요!"
                            }, new Paragraph
                            {
                                Body="이 튜토리얼에서는 깃허브를 비쥬얼스튜디오에 자동적으로 연동하는 방법을 배울 수 있습니다:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "코드 리뷰",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "나만의 리포지토리를 만드는 것이 아니라 C# 아카데미에 소속된 멤버에게서 코딩 리뷰를 받으시고 싶으시다면, <a href='article/52/code-reviews' target='blank'>여기를 클릭해주세요</a>, 저희 리뷰 리포지토리를 기반으로 포크(fork)를 만드는 법을 배우실 수 있습니다."
                            }
                        }
                    },
                }
            }
        };
    }
    internal static List<Project> GetProjectsInPortuguese()
    {
        var projects = GetProjects();

        return new List<Project>
        {
            new Project
             {
                Id = 53,
                Title = "Jogo de Matemática",
                IconUrl = projects.FirstOrDefault(p => p.Id == 53).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 53).BannerUrl,
                LanguageHeadings = new PortugueseHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 53).Slug,
                Description = "Nesse primeiro projeto, você ira criar um jogo de matemática que irá reforçar o que você aprendeu na área de Fundamentos.",
                Area = projects.FirstOrDefault(p => p.Id == 53).Area,
                Level = projects.FirstOrDefault(p => p.Id == 53).Level,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 53).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 53).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 53).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 53).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Se essa é a sua primeira vez construindo um projeto do zero e sem ajuda, eu recomendo usar a <a target='blank' href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> série de vídeos que disponibilizamos na área de fundações.</a> A série irá guiá-lo pelo processo de criação de uma aplicação de console do zero, explicando conceitos cruciais de C#. Se você já assistiu a série ou tem experiência prévia trablhando com C#, esse projeto será simples. Mas lembre-se, é sempre útil reforçar seus conhecimentos."
                    },
                    new Paragraph
                    {
                        Body="Você irá encontrar desafios no final deste projeto e em todos os outros projetos na Academia C#. Esses desafios não são requirementos. Desde que seu projeto siga os requiremntos, seu projeto será aprovado e você irá ganhar os pontos de experiência correspondentes. Contudo, esses desafios vão reforçar o que você aprendeu. Você talvez não ganhe pontos extra, mas completar os desafios vão torná-lo um desenvolvedor melhor."
                    }
                },
                Requirements = new List<string>
                {
                    @"Você precisa criar um jogo de matemática contendo 4 operações básicas.",
                    @"As divisões devem resultar APENAS EM INTEGERS e os dividendos devem variar de 0 a 100. Por exemplo: Sua aplicação não pode apresentar a divisão 7/2 ao usuário, porque resultaria em uma fração ao invés de um número inteiro.",
                    @"Usuários devem ser apresentados com um menu para escolher uma operação",
                    @"Você deve registrar os jogos anteriores em uma lista e incluir uma opção no menu para visualizar o histórico desses jogos.",
                    @"Você não precisa registrar os resultados em um banco de dados. Quando o programa fechar, esses resultados serão deletados."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'>Tutorial do Jogo de Matemática no Youtube</a>",
                },
                ResourcesIntro = "Se você tem experiência prévia com C# você provavelmente completará este projeto sem ajuda. Caso contrário, siga este tutorial.",
                ResourcesConclusion = "Você não precisa assistir a segunda parte do tutorial (Construindo uma aplicação .NET usando Maui) para completar o projeto. Só a parte relacionada ao Console é necessária.",
                Tips = new List<string>
                {
                    "Não se esqueça de SEMPRE salvar seu ccódigo no Github (Ou qualquer outro sistema de source control que você usa). Desse jeito você não irá perder seu trabalho e poderá usar seu código salvo como referência no futuro. Você está construindo sua própria biblioteca!",
                    "Tome seu tempo com cada passo, mesmo que o tutorial seja fácil para você. Tenha certeza que você entende CADA PALAVRA do seu código. Não fique com nenhuma dúvida.",
                    "Se existe algo que você não está entendendo, coloque seu mouse sobre o código, você irá receber uma explicação sobre o que os termos significam. Se você ainda não está entendendo, google é o seu melhor amigo. Você irá encontrar explicações sobre praticamente qualquer coisa em em fórums e sites como o stackoverflow.com",
                    "Se esse é o seu primeiro projeto, eu recomendo desenvolver ele duas vezes. Você ficará surpreso com o aumento da sua  retenção e com quantos detalhes você deixou passar na primeira vez.",
                    "Após completar o projeto, vá para o nosso <a target='_blank' href='https://discord.gg/JVnwYdM79C'>communidade do discord</a> e fale sobre ele! Completar um projeto é um passo importante e você deve celebrar ele."
                },
                Challenges = new List<string>
                {
                    "Tente implementar níveis de dificuldade.",
                    "Adicione um timer para contar o tempo que o usuário leva para terminar o jogo.",
                    "Adicione uma função que permite ao usuário selecionar o número de perguntas.",
                    "Crie a opção 'Jogo Aleatório' onde os jogadores irão receber perguntas de operações aleatórias.",
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Se esse é o seu primeiro tutorial, você talvez se sinta tentando a pular essa parte e começar a programar.Se você fizer isso, irá aprender do jeito difícil. Um dia, após trabalhar por várias horas em um problema difícil, você irá se esquecer de salvar seu trabalho em um repositório e por uma razão qualquer tudo poderá ser perdido."
                            },
                            new Paragraph
                            {
                                Body = "Pegue o hábito de salvar cada linha de código que você escrever. Eu prometo que fazer isso vai muitas dores de cabeça. Todos os desenvolvedores sérios salvam seu trabalho em um repositório de reserva. O mais comum é o Github. Crie uma conta se você ainda não o fez."
                            },
                            new Paragraph
                            {
                                Body="1. No Visual Studio, acesse Git > Criar um repositorio Git<br>2. Insira seus detalhes de login<br>3. Clique em 'Create and Push' "
                            },
                            new Paragraph
                            {
                                Body="✅ Pronto! Seu repositório está pronto. Não se esqueça de criar commits para suas mudanças após cada passo!"
                            }, new Paragraph
                            {
                                Body="Você pode ir um passo além e aprender como integrar o Github com o Visual Studio assistindo este tutorial:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Review",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Se você quer que seu código seja avaliado por um mebro da Academia C#, ao invés de criar seu próprio repositório, <a href='article/52/code-reviews' target='blank'>siga esse artigo</a>, onde você irá aprender a criar um fork do nosso diretório de revisões."
                            }
                        }
                    },
                }
            },
        };
    }
    internal static List<Project> GetProjectsInTurkish()
    {
        var projects = GetProjects();

        return new List<Project>
        {
            new Project
             {
                Id = 53,
                Title = "Matematik Oyunu",
                IconUrl = projects.FirstOrDefault(p => p.Id == 53).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 53).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 53).Slug,
                Description = "İlk projenizde Temeller alanında öğrendiklerinizi pekiştirmek için bir matematik oyunu oluşturacaksınız",
                Area = projects.FirstOrDefault(p => p.Id == 53).Area,
                Level = projects.FirstOrDefault(p => p.Id == 53).Level,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 53).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 53).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 53).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 53).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="İlk projenizde çok basit bir Matematik Oyunu uygulaması oluşturacaksınız. İlk kez kendi başınıza bir proje oluşturuyorsanız, <a target='blank' href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> C#  Temelleri bölümümüzdeki C# Academy serisinden </a>.yararlanmanızı öneririm. Bu seri, önemli C# kavramlarını açıklarken, sıfırdan bir konsol uygulaması oluşturma sürecinde size rehberlik edecektir. Daha önce izlediyseniz veya C# uygulamaları oluşturma konusunda önceden deneyiminiz varsa, bu proje size çocuk oyuncağı gelecektir. Yinede bilgilerinizi pekiştirmek faydalı olacaktır."
                    },
                    new Paragraph
                    {
                        Body="Bu projenin ve C# Akademisi'ndeki diğer tüm projelerin sonunda kodlama yarışması ile karşılaşacaksınız. Bu yarışmalar zorunlu değildir. Tamamlamasanızda projeniz yine de onaylanacak ve ilgili deneyim puanlarını kazanacaksınız. Ancak yarışmalar öğrendiklerinizi pekiştirecektir. Bunları tamamladığınızda ekstra puan alamayabilirsiniz, ancak her mücadeleyi tamamladığınızda daha iyi bir yazılımcı olacaksınız."
                    }
                },
                Requirements = new List<string>
                {
                    @"Dört temel işlemi içeren bir Matematik oyunu oluşturmanız gerekiyor",
                    @"Bölme işlemleri YALNIZCA TAM SAYILAR ile sonuçlanmalı ve bölünen 0'dan 100'e kadar olmalıdır. Örnek: 7/2 işlemi bir tam sayıyla sonuçlanmadığından uygulamanız kullanıcıya 7/2 işlemini sormamalıdır.",
                    @"Kullanıcılara yapılacak işlemi seçebilecekleri bir menü sunulmalıdır",
                    @"Oynanan oyunları bir Listeye kaydetmelisiniz ve menüde kullanıcının önceki oyunları görebilmesi için bir seçenek bulunmalıdır.",
                    @"Sonuçları bir veritabanına kaydetmenize gerek yok. Program kapatıldığında sonuçlar silinecektir."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'>Youtube'da Matematik oyunu dersi</a>",
                },
                ResourcesIntro = "Daha önce C# deneyiminiz varsa bu projeyi herhangi bir yardım almadan tamamlayabilirsiniz. Deneyiminiz yoksa, bu dersi izleyin: ",
                ResourcesConclusion = "Bu projeyi tamamlamak için bu eğitimin ikinci bölümünü (.NET Maui uygulaması oluşturma) izlemenize gerek yoktur. Yalnızca Konsol Uygulaması gereklidir",
                Tips = new List<string>
                {
                    "HER ZAMAN ama HER ZAMAN kodunuzu Github'a (veya kullandığınız benzer bir sürüm kontrol ortamına) kaydetmeyi unutmayın. Bu şekilde çalışmanızı kaybetmezsiniz ve gelecekte her zaman ona başvurabilirsiniz. Kendinize ait bir kütüphane inşa ediyorsunuz!",
                    "Bu eğitim sizin için kolay olsa bile bitirmek için acele etmeyin. Kodun HER KELİMESİNİ anladığınızdan emin olun. Altına bakılmadık taş bırakmayın.",
                    "Anlamadığınız bir şey varsa fare imlecini kodun üzerine getirin; terimin ne anlama geldiğine dair bir açıklama göreceksiniz. Hala anlayamıyorsanız Google en iyi dostunuzdur. Stackoveflow.com gibi forumlarda hemen hemen her şey hakkında açıklamalar bulabilirsiniz.",
                    "Bu ilk projenizse, iki kez yapmanızı öneririm. Akılda kalma miktarının ne kadar arttığına ve ilk seferde ne kadar boşluk kaldığına şaşıracaksınız.",
                    "Projenizi tamamladıktan sonra <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord topluluğumuza</a> gidin ve projenizden övgüyle bahsedin! Bir projeyi tamamlamak çok önemli bir adımdır ve kutlamanız gerekir."
                },
                Challenges = new List<string>
                {
                    "Zorluk dereceleri eklemeyi deneyin.",
                    "Kullanıcının oyunu nekadar sürede bitirdiğini gösteren zamanlayıcı ekleyin.",
                    "Kullanıcının soru sayısını belirleyebileceği bir fonksiyon ekleyin.",
                    "Oyuna, kullacıya rastgele işlemlerden oluşan sorular soran 'Rastgele İşlem' seçeneği ekleyin",
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Sürüm kontrolü",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Bu ilk eğitiminizse, bu adımı atlayıp kodlamaya başlamak isteyebilirsiniz. Bunu yapmayın yoksa bazı şeyleri zor yoldan öğrenirsiniz. Zor bir problem üzerinde saatlerce çalıştıktan sonra çalışmanızı bir sürüm kontrol deposuna kaydetmediyseniz, her ne sebeple olursa olsun bir gün kaybolacaktır."
                            },
                            new Paragraph
                            {
                                Body = "Yazdığınız her kod satırını kaydetme alışkanlığı edinin. İleride sizi birçok baş ağrısından kurtaracağına söz veriyorum. Tüm gerçek yazılımcılar çalışmalarını bir yedekleme havuzuna kaydeder. En yaygın kullanılanı Github'dur. Henüz yapmadıysanız bir hesap oluşturun. "
                            },
                            new Paragraph
                            {
                                Body="1. Visual Studio'da Git > Git Deposu Oluştur<br>2. Oturum Açma ayrıntılarınızı girin<br>3. Oluştur (create) ve Gönder(push)'e tıklayın. "
                            },
                            new Paragraph
                            {
                                Body="✅ İşe oldu! Deponuz kullanıma hazır. Her adımdan sonra değişikliklerinizi eklemeyi(commit) ve göndermeyi(push) unutmayın!"
                            }, new Paragraph
                            {
                                Body="Bir adım iler gitmek isterseniz, bu dersi izleyerek Github'u Visual Studio ile nasıl entegre edeceğinizi öğrenebilirsiniz.:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Kod değerlendirmesi",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "C# Akademisi'nin bir üyesi tarafından kodunuzun incelenmesini istiyorsanız <a href='article/52/code-reviews' target='blank'>bu makaleyi takip edin</a>; Temel inceleme havuzumuzdan nasıl çatal(fork) oluşturulacağını öğrenin."
                            }
                        }
                    },
                }
             },
            new Project
            {
                Id = 11,
                Title = "Hesap Makinası",
                IconUrl = projects.FirstOrDefault(p => p.Id == 11).IconUrl,
                Slug = projects.FirstOrDefault(p => p.Id == 11).Slug,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 11).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Level = projects.FirstOrDefault(p => p.Id == 11).Level,
                Description = "Bu projede Microsoft'un eğitim materyallerini kullanarak bir hesap makinası oluşturacaksınız.",
                Area = projects.FirstOrDefault(p => p.Id == 11).Area,
                Difficulty = projects.FirstOrDefault(p => p.Id == 11).Difficulty,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 11).ExperiencePoints,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 11).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 11).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="İkinci projeniz olarak Microsoft eğitim materyallerinin yardımıyla bir Konsol Hesap Makinası uygulaması oluşturacaksınız. Bu proje ilkinden daha zor olmamakla birlikte, aynı çözümde birden fazla projeye sahip olma, dosyaya yazma ve hata ayıklama gibi önemli becerileri öğreneceksiniz. Aynı zamanda yazılı talimatları takip etmek gibi çok önemli bir becerinin gelişmesine yardım edecektir. Bu, profesyonel bir geliştirici olarak herzaman yapacağınız bir şeydir. Bu nedenle, yazılım geliştirirken metin tabanlı talimatları rahatça uygulayabilmeniz çok önemlidir."
                    }
                },
                Requirements = new List<string>
                {
                    @"Verilen eğitimi tamamlayın (1. ve 2. kısımlar): <a href='https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022'>Hesap makinası uygulaması oluşturun (Microsoft Docs)</a>. Sayfanın sonunda 2. kısım için link bulabilirsiniz."
                },
                RequirementsIntro = "Bu projenin tek bir koşulu vardır:",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-mac'>Mac için Visual Studio</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0'>Visual Studio Code</a>"
                },
                ResourcesIntro = "Bu proje için verilen yönergeler Windows için  Visual Studio üzerindendir. Kod editörü ne olursa olsun yazacağınız kod aynı olacaktır ancak yeni bir proje oluşturma süreci farklılık gösterecektir. Farklı editörler ile konsol uygulamasının nasıl oluşturulacağıyla ilgili bağlantıları burada bulabilirsiniz: ",
                Tips = new List<string>
                {
                    "Bu eğitim sizin için kolay olsa bile bitirmek için acele etmeyin. Kodun HER KELİMESİNİ anladığınızdan emin olun. Altına bakılmadık taş bırakmayın.",
                    "Anlamadığınız bir şey varsa fare imlecini kodun üzerine getirin; terimin ne anlama geldiğine dair bir açıklama göreceksiniz. Hala anlayamıyorsanız Google en iyi dostunuzdur. Stackoveflow.com gibi forumlarda hemen hemen her şey hakkında açıklamalar bulabilirsiniz.",
                    "2. Kısımdaki hata ayıklama kısmını atlamayın. Bu projede öğreneceğiniz ve ileriki projelerde hayati öneme sahip olan en önemli becerilerden birisidir."
                },
                 Challenges = new List<string>
                {
                    "Hesap makinasının kaç kez kullanıldığını gösteren bir işlev ekleyin",
                    "En son hesaplamaları bir listeye kaydedin ve kullanıcıya bu listeyi silebileceği bir imkan sağlayın.",
                    "Kullanıcıya bu listedeki sonuçları yeni işlemlerde kullanabilmesi için imkan sağlayın",
                    "Ekstra hesaplamalar ekleyin: Karekök, üs alma, 10x, trigonometrik fonksiyonlar.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Kod değerlendirmesi",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "\"C# Akademisi'nin bir üyesi tarafından kodunuzun incelenmesini istiyorsanız <a href='article/52/code-reviews' target='blank'>bu makaleyi takip edin</a>; Temel inceleme havuzumuzdan nasıl çatal(fork) oluşturulacağını öğrenin."
                            }
                        }
                    }
                }
             },
         new Project
         {
             Id = 12,
             Title = "Alışkanlık Kaydedici",
             IconUrl = projects.FirstOrDefault(p => p.Id == 12).IconUrl,
             BannerUrl = projects.FirstOrDefault(p => p.Id == 12).BannerUrl,
             LanguageHeadings = new EnglishHeadings(),
             Slug = projects.FirstOrDefault(p => p.Id == 12).Slug,
             Description = "Tercih ettiğiniz bir alışkanlığınızı kaydedin. SQLite kullanarak bir veritabanı ile etkileşime geçmeyi ve kullanıcı girişlerini doğrulamayı öğrenin.",
             Area = projects.FirstOrDefault(p => p.Id == 12).Area,
             Level = projects.FirstOrDefault(p => p.Id == 12).Level,
             ExperiencePoints = projects.FirstOrDefault(p => p.Id == 12).ExperiencePoints,
             Difficulty = projects.FirstOrDefault(p => p.Id == 12).Difficulty,
             DisplayOrder = projects.FirstOrDefault(p => p.Id == 12).DisplayOrder,
             RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 12).RepositoryLink,
             Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Bu size gerçek bir veritabanı üzerinde <a href='https://en.wikipedia.org/wiki/Create,_read,_update_and_delete'>CRUD işlemlerini</a> uygulamayı öğreten çok basit bir uygulamadır. Bu işlemler web geliştirmenin temel işlemleridir ve tüm kariyeriniz boyunca geliştireceğiniz çoğu uygulamada bunları kullanıyor olacaksınız. Bu işlemleri şimdi yolun başında öğrenmenizin çok önemli olduğunu düşünüyoruz çünkü bu seviyeden sonraki tüm projeler bu işlemlere daha fazla karmaşıklık katmaktan ibaret olacak. Ne kadar karmaşık ve süslü uygulamalar yapıyor olursanız olun, sonuçta hepsi veritabanında bu işlemleri yürütmekten ibarek olacaktır."
                    },
                    new Paragraph
                    {
                        Body="Bunun için basit <a href='https://en.wikipedia.org/wiki/SQL'>SQL komutlarını</a> öğrenmeniz gerekiyor. Başta korkutucu görünebilir, ancak full-stack uygulama geliştirmek için ne kadar az bir SQL bilgisine ihtiyacınız olduğunu gördüğünüzde şaşıracaksınız. Endişelenmeyin, ilk tam fonksiyonel CRUD uygulamanızı tamamen bitirine kadar elinizden tutacağız. C# kullanarak SQL veri tabanına ulaşmak için <a href='https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/'>ADO.NET</a>, Dapper ve Entity Framework kullanılabilir. Saf SQL'e en yakın olan ADO.NET ile başlayacağız."
                    },
                    new Paragraph
                    {
                        Body="Eğer bu projenin çok zor oluğunu düşünüyorsanız ve nereden başlayacağınızı bilemiyorsanız, haklısınız. Tek başınıza gerçek bir uygulama oluşturmak için yardıma ihtiyacınız olabilir. Böyle düşünüyorsanız, <a href='https://youtu.be/d1JIJdDVFjs'>bu proje için hazrlanan eğitim videosunu izleyin</a> ve daha sonra geri gelerek tekrar tek başınıza yapmayı deneyin. Çoğu başlangıç seviyesi kurslar gerçekten bir uygulama geliştirmeyi öğretmediklerinden, kendinizi kaybolmuş hissedebilirsiniz. "
                    },
                    new Paragraph
                    {
                        Body="Evet, haydi başlayalım!"
                    }
                },
             Requirements = new List<string>
                {
                    "Bu bir alışkanlığınızı kaydedeceğiniz bir uygulamadır.",
                    "Bu alışkanlık için zaman takibi kullanamazsınız (ör: uyku süresi), sadece miktar kullanabilirsiniz (ör: günlük kaç bardak su içtiniz)",
                    "Uygulama, bilgileri gerçek bir veritabanına yazmalı ve oradan almalıdır.",
                    "Uygulama başlatıldığında, eğer mevcut bir Sqlite veritabanı yoksa, uygulama yeni bir tane oluşturmalıdır.",
                    "Ayrıca veritabanında alışkanlıkların kaydedileceği bir tablo da oluşturmalıdır",
                    "Uygulama kullanıcıya menü seçenekleri sunmalıdır.",
                    "Kullanıcı yeni kayıt oluşturabilmeli, kayıtları güncelleyebilmeli yada silebilmeli ve var olan kayıtları görüntüleyebilmelidir.",
                    "Uygulama hiç çökmeyecek şekilde tüm olası hatalarla başa çıkmalısınız",
                    "Uygulama sadece kullanıcı menüden tercih ettiğinde durmalıdır",
                    "Veritabanı ile sadece saf SQL komutları kullanarak etkileşebilirsiniz. Entity framework gibi mapper kullanamazsınız.",
                    "Projenizde uygulamanızın nasıl çalıştığını açıklayan Beni Oku (Read me) dosyası bulunmalıdır. Güzel bir örnek:"
                },
             RequirementsConclusion = "<a href='https://github.com/thags/ConsoleTimeLogger'>İyi düzenlenmiş bir Beni Oku dosyası bulunan bir proje.</a><br> Paniklemeyin, size yardım edeceğim! 😁",

             Tips = new List<string>
                {
                    "Uygulamada kullanmadan önce SQL sorgularınızı DB tarayıcısında test edin.",
                    "İsterseniz tüm kodu tek bir sınıfta toplayabilirsiniz.",
                    "Kullanıcı girişi menüsü için Switch/Case demeçlerini kullanabilirsiniz. ",
                    "Kullanıcı girişlerini doğrulamayı unutmayın: Yanlış tarihleri kontrol edin. Kullanıcı menüde olmayan bir seçenek girişi yaparsa ne olacak? Kullanıcı bir sayı yerine yazı girişi yaparsa ne olacak?"
                },
             Challenges = new List<string>
                {
                    "Kullanıcıya tercih ettiği alışkanlığı oluşturmasını sağlayın. Bu durum aynı zamanda her alışkanlık için ayrı ölçü birimi belirlemelerini gerektirecektir.",
                    "Veritabanı ilk kez oluşturulduğunda veri tabanına otomatik olarak rastgele verilerden oluşan yüz kayıt ekleyin. Bu uygulama her seferinde veri tabanına yeni veri ekleme ihtiyacını kaldırdığından, geliştirme sürecinde çok yararlıdır. ",
                    "Kullanıcının belli bilgileri görüntüleyebileceği raporlama işlevi ekleyin(Ör: Kullanıcı son bir senede ne kadar koştu? kaç km?) SQL veritabanından ilginç bilgiler sorgulamanıza olanak verir."
                },
             LearningIntro = "Eğer <a href='article/8' target='blank'>C# Temelleri</a> yazımızı takip edip C# için temel bilgileri öğrendiyseniz, bu projeyi tamamlamak için gerekli bilgilere sahip olmalısınız. Gereklilikleri yerine getirmek için ihtiyacınız olanların listesi:",
             LearningItems = new List<string>
                 {
                     "Konsoldan kullacı girişi almak.",
                     "Konsolda mesaj yazmak.",
                     "Nuget paketlerini kurmak (Uygulamanızı çalıştırmak için ASP.NET kütüphanelerine ihtiyacınız olacak).",
                     "'If-else' ve 'switch' belirteçleri ile basit akış kontrolü sağlamak.",
                     "Sqlite veritabanına bağlanmak.",
                     "SQL temel bilgileri(veritabanı ile iletişim kurduğunuz dil). Başlamadan önce biraz SQL çalışmak isterseniz <a href='https://www.w3schools.com/sql/sql_exercises.asp'>burası göz atmak için mükemmel</a>."
                 },
             Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Projeyi oluşturma",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Bu proje için .Net ortamı kurulumunu yapmış olmalısınız. Henüz yapmadıysanız <a href='article/7/setting-up' target='blank'>bu makaleyi</a> takip edin. Eğer mutlaka başka bir arayüz kullanmak isterseniz bana bilgi verin."
                            },
                            new Paragraph
                            {
                                Body = "1. Visual Studio da, Yeni Proje oluşturmayı seçin. Eğer Visual Studio Code kullanıyorsanız ve yeni proje oluşturmada sorun yaşıyorsanız bana bilgi verin.<br>2. Konsol Uygulamasını seçin ve sonrakine tıklayın.<br>3. Proje ismi, klasörü seçin ve sonrakine tıklayın.<br>3. En güncel çerçeveyi seçin (Bu rehber hazırlandığında Net 6 idi) ve oluştura tıklayın.<br>4. Ekranın üst orta kısmında yer alan üçgen yeşil çalıştır düğmesine basarak uygulamayı çalıştırın."
                            },
                            new Paragraph
                            {
                                Body = " CLI (komut satır arayüzü) açılacak ve ekranda ‘Hello World’ yazacak. Bu uygulamanızın ve ASP.NET ortamınızın düzgün çalıştığını gösterir."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Çalışma klasörünü değiştirme",
                        ImgUrl = "icons8-folder-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Varsayılan olarak projeniz bin klasöründe yapılandırılmaktadır, ancak işleri kolaylaştırmak için bunu değiştireceğiz. Bu şekilde .Net projenizi ana klasörünüzde yapılandıracaktır. Bu işlem konfigürasyon bilgilerinizi içeren <b>launchsettings.json</b> dosyasının bulunduğu Properties klasörü oluşturacaktır. Sqlite kullanan projelerde karışıklığı önlemek için veritabanının uygulama ile aynı klasörde olmasını isteriz. Bu nedenle bu işlem önemlidir."
                            },
                            new Paragraph
                            {
                                Body = "Üst menüde Debug (Hata ayaklıma) da Properties (özellikler) kısmına girin ve burada Working Directory(çalışma klasörü) ne projenizin bulunduğu klasörün tam yolunu yapıştırın. Tam klasör yolunu öğrenmek için sağda bulunan Solution Explorer (Çözüm gezgini) da projenize sağ tıklayıp tam yolu kopyala seçeneğini yada dosya gezginini kullanabilirsiniz. Mac/Visual studio code kullanıyorsanız yardım için bize ulaşabilirsiniz."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-1.png"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Kodlamaya başlayın!",
                        ImgUrl = "icons8-coding-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Uygulama her başlatıldığında bir veritabanı olup olmadığını kontrol etmelidir. Eğer yoksa verilerinizi saklayacağınız tablo ile birlikte veritabanı oluşturmalıdır. Vertabanını dışarıdan silerseniz, uygulama yenisini oluşturmalıdır. Veritabanı zaten varsa sonraki adıma geçmelidir: Kullanıcıdan ne yapmak istediğini sormak. Örnek olarak:"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "habit-menu.png"
                            },
                            new Paragraph
                            {
                                Body = " ASP.NET de C# ile yazılım geliştirmede , SQL Server kullanımı çok yaygındır. Ancak şu an bunu kullanmayacağız. SQLite çok sade yapıda bir veritabanı sistemidir ve SQL Server'a geçmeden bu sisteme aşina olmak oldukça önemlidir."
                            },
                            new Paragraph
                            {
                                Body = "Uygulamanıza bir sqlite dosyası oluşturmasını söylemeniz gerekecek. Bu dosya içeriğini dışarıdan görüntüleyebilmek için küçük bir uygulamaya ihtiyacınız olacak. <a href='https://www.youtube.com/watch?v=HQKwgk6XkIA'>Bu linkten Sqlite dersine ulaşabilirsiniz</a>."
                            },
                            new Paragraph
                            {
                                Body = "Burası gerçek kodlamanın başladığı yer! Bir süre kendi başınıza olacaksınız. Eğer takılırsanız, denemeye devam edin, <a href='article/6/getting-help' target='blank'>takıldığınızda nasıl hata ayıklaması yaptığınızı hatırlayın</a>. Yinede takıldığınız sorunu aşamazsanız  <a href='https://discord.gg/JVnwYdM79C'>Discord Topluluğumuz'a</a> yada bana ulaşırsanız yardımcı oluruz!"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Video Eğitim",
                        ImgUrl = "external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Eğer tamamen kaybolmuş hissediyorsanız, video eğitimi izlemeniz yararlı olacaktır. Burada bir uygulama geliştirmek için gerekli parçaları bir araya nasıl getireceğinizi göreceksiniz. Eğitimi bitirdikten sonra, öğrendiklerinizi içselleştirmek için projeyi mutlaka videoya bakmadan tekrar kendi başınıza tamamlayın. "
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/d1JIJdDVFjs"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Sürüm kontrolü",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Bu ilk eğitiminizse, bu adımı atlayıp kodlamaya başlamak isteyebilirsiniz. Bunu yapmayın yoksa bazı şeyleri zor yoldan öğrenirsiniz. Zor bir problem üzerinde saatlerce çalıştıktan sonra çalışmanızı bir sürüm kontrol deposuna kaydetmediyseniz, her ne sebeple olursa olsun bir gün kaybolacaktır."
                            },
                            new Paragraph
                            {
                                Body = "Yazdığınız her kod satırını kaydetme alışkanlığı edinin. İleride sizi birçok baş ağrısından kurtaracağına söz veriyorum. Tüm gerçek yazılımcılar çalışmalarını bir yedekleme havuzuna kaydeder. En yaygın kullanılanı Github'dur. Henüz yapmadıysanız bir hesap oluşturun. "
                            },
                            new Paragraph
                            {
                                Body="1. Visual Studio'da Git > Git Deposu Oluştur<br>2. Oturum Açma ayrıntılarınızı girin<br>3. Oluştur (create) ve Gönder(push)'e tıklayın. "
                            },
                            new Paragraph
                            {
                                Body="✅ İşe oldu! Deponuz kullanıma hazır. Her adımdan sonra değişikliklerinizi eklemeyi(commit) ve göndermeyi(push) unutmayın!"
                            }, new Paragraph
                            {
                                Body="Bir adım iler gitmek isterseniz, bu dersi izleyerek Github'u Visual Studio ile nasıl entegre edeceğinizi öğrenebilirsiniz.:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Kod değerlendirmesi",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "\"C# Akademisi'nin bir üyesi tarafından kodunuzun incelenmesini istiyorsanız <a href='article/52/code-reviews' target='blank'>bu makaleyi takip edin</a>; Temel inceleme havuzumuzdan nasıl çatal(fork) oluşturulacağını öğrenin."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Sonraki adım: Masaüstü uygulama",
                        ImgUrl = "icons8-staircase-80.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Eğer <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>C# temelleri eğitimini</a> izlediyseniz, muhteşem .NET MAUI ile bir matematik oyunu uygulaması oluşturmuşsunuzdur. Yazdığınız alışkanlık takip uygulaması ile aynı özelliklere sahip bir masaüstü versiyonunu yapmak iyi bir alıştırma olacaktır. Bazı zorluklar olacaktır ancak artık bunları aşmak için gerekli becerilere sahipsiniz. Ve unutmayın, eğer bir yerde takılacak olursanız, yardım için bize <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord topluluğumuzdan</a> ulaşabilirsiniz!"
                            }
                        }
                    }
             }
         }
        };
    }
    internal static List<Project> GetProjectsInRussian()
    {
        var projects = GetProjects();

        return new List<Project>
        {
             new Project
             {
                Id = 53,
                Title = "Math Game",
                IconUrl = projects.FirstOrDefault(p => p.Id == 53).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 53).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 53).Slug,
                Description = "В своем первом проекте вы создадите математическую игру (math game), чтобы закрепить то, чему вы научились в Foundations area",
                Area = projects.FirstOrDefault(p => p.Id == 53).Area,
                Level = projects.FirstOrDefault(p => p.Id == 53).Level,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 53).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 53).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 53).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 53).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="В своем первом проекте вы создадите очень простое приложение под названием Math Game app. Если вы впервые создаете проект самостоятельно, я рекомендую воспользоваться серией C# Academy <a target='blank' href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> из нашей области C# Foundation</a>. В этой серии вы пройдете через процесс создания консольного приложения с нуля, объясняя при этом важнейшие концепции C#. Если вы уже смотрели его или у вас есть предыдущий опыт создания приложений на C#, этот проект будет несложным. Но все равно полезно подкрепить свои знания."
                    },
                    new Paragraph
                    {
                        Body="Вы найдете сложные задачи в конце этого проекта и всех других проектов в Академии C#. Эти задачи не являются требованиями. Ваш проект все равно будет одобрен, и вы получите соответствующие баллы опыта. Однако задачи укрепят то, чему вы научились. Хотя вы, возможно, не получите дополнительных баллов за их выполнение, вы будете становиться лучшим разработчиком каждый раз, когда будете выполнять задачу."
                    }
                },
                Requirements = new List<string>
                {
                    @"Вам нужно создать математическую игру, содержащую 4 основные операции",
                    @"Результатом деления должны быть только ЦЕЛЫЕ числа, а делимые должны быть от 0 до 100. Пример: Ваше приложение не должно показывать пользователю деление 7/2, поскольку оно не приводит к целому числу.",
                    @"Пользователям должно быть представлено меню для выбора операции",
                    @"Вы должны записать предыдущие игры в список, и в меню должна быть опция, позволяющая пользователю просматривать историю предыдущих игр.",
                    @"Вам не нужно записывать результаты в базу данных. Как только программа закроется, результаты будут удалены."
                },
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'>Видеоурок по Math Game на Youtube</a>",
                },
                ResourcesIntro = "Если у вас есть предыдущий опыт работы с C#, вы, возможно, сможете завершить этот проект без чьей-либо помощи. Если у вас его нет, следуйте этому руководству:",
                ResourcesConclusion = "Вам не нужно смотреть вторую часть этого руководства (Создание приложения .NET Maui), чтобы завершить этот проект. Требуется только консольное приложение",
                Tips = new List<string>
                {
                    "Не забывайте ВСЕГДА, я имею в виду, ВСЕГДА сохранять свой код на Github (или любой другой системе управления версиями, которую вы используете). Таким образом, вы не потеряете свою работу и всегда сможете вернуться к ней в будущем. Вы создаете свою собственную библиотеку!",
                    "Не торопитесь выполнять шаги, даже если это руководство для вас простое. Убедитесь, что вы понимаете КАЖДОЕ СЛОВО кода. Не оставляйте камня на камне.",
                    "Если вы чего-то не понимаете, наведите курсор на код, и вы получите объяснение того, что означает этот термин. Если вы все еще не можете этого понять, Google - ваш лучший друг. Вы найдете объяснения практически обо всем на форумах, таких как stackoveflow.com.",
                    "Если это ваш первый проект, я рекомендую сделать это два раза. Вы будете удивлены тем, насколько увеличится ваше удержание и сколько пробелов было оставлено в первый раз.",
                    "По завершении вашего проекта зайдите в наше <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord канал</a> и похвастайтесь этим! Это очень важный шаг для завершения проекта, и вы должны отпраздновать."
                },
                Challenges = new List<string>
                {
                    "Попробуйте реализовать разные уровни сложности.",
                    "Добавьте таймер, чтобы отслеживать, сколько времени требуется пользователю, чтобы закончить игру.",
                    "Добавьте функциональность, которая позволяет пользователю выбирать количество вопросов.",
                    "Создайте опцию 'Случайная игра (Random Game)', в которой игрокам будут представлены вопросы из случайных операций",
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Управление исходным кодом",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если это ваш первый урок, у вас может возникнуть соблазн пропустить этот шаг и начать кодировать. Не делайте этого, иначе вам придется учиться на собственном горьком опыте. Однажды, после многочасовой работы над сложной задачей, вы не сохраните свою работу в репозитории системы управления версиями, и по какой-либо причине все это будет потеряно."
                            },
                            new Paragraph
                            {
                                Body = "Возьмите за привычку сохранять каждую строку кода, которую вы когда-либо писали. Я обещаю, что это избавит вас от многих головных болей. Все серьезные разработчики сохраняют свою работу в репозитории. Наиболее часто используемый - Github. Создайте учетную запись, если вы еще этого не сделали."
                            },
                            new Paragraph
                            {
                                Body="1. В Visual Studio перейдите в Git > Create Git Repository<br>2. Введите свои данные для входа в систему<br>3. Нажмите 'Create' и нажмите 'Push'."
                            },
                            new Paragraph
                            {
                                Body="✅ Сделано! Ваш репозиторий готов к работе. Не забывайте фиксировать и продвигать свои изменения после каждого шага!"
                            }, new Paragraph
                            {
                                Body="Вы можете сделать следующий шаг и узнать, как интегрировать Github с Visual Studio, просмотрев этот видеоурок:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Проверка кода",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если вы хотите, чтобы ваш код был проверен членом C# Academy, вместо создания собственного репозитория, <a href='article/52/code-reviews' target='blank'>читайте этой статье</a>, где вы узнаете, как создать fork из нашего базового репозитория."
                            }
                        }
                    },
                }
            },
             new Project
            {
                Id = 11,
                Title = "Калькулятор",
                IconUrl = projects.FirstOrDefault(p => p.Id == 11).IconUrl,
                Slug = projects.FirstOrDefault(p => p.Id == 11).Slug,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 11).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Level = projects.FirstOrDefault(p => p.Id == 11).Level,
                Description = "Для этого вы создадите калькулятор с помощью документации от Microsoft",
                Area = projects.FirstOrDefault(p => p.Id == 11).Area,
                Difficulty = projects.FirstOrDefault(p => p.Id == 11).Difficulty,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 11).ExperiencePoints,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 11).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 11).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Для вашего второго проекта вы создадите консольное приложение-калькулятор с помощью документации Microsoft. Этот проект не должен быть сложнее первого, но вы освоите важные навыки, такие как наличие нескольких проектов в решении, запись в файлы и отладка. Это также послужит практикой в очень важном навыке: следовании письменной документации. Это то, что вы будете делать регулярно как профессиональный разработчик, поэтому важно, чтобы вам было удобно применять текстовые инструкции при разработке программного обеспечения."
                    }
                },
                Requirements = new List<string>
                {
                    @"Выполните следующее руководство (части 1 и 2): <a href='https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022'>Создайте приложение для калькулятора (Microsoft Docs)</a>. Вы можете найти ссылку на вторую часть внизу страницы."
                },
                RequirementsIntro = "У этого проекта есть только одно требование:",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-mac'>Visual Studio для Mac</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0'>Visual Studio Code</a>"
                },
                ResourcesIntro = "Инструкции для этого проекта основаны на Visual Studio для Windows. Код, который вы напишете, будет одинаковым независимо от редактора кода, но процесс создания нового проекта будет отличаться. Вот ссылки о том, как создать консольное приложение в разных редакторах: ",
                Tips = new List<string>
                {
                    "Не торопитесь выполнять шаги, даже если это руководство для вас прост. Убедитесь, что вы понимаете КАЖДОЕ СЛОВО кода. Не оставляйте камня на камне.",
                    "Если вы чего-то не понимаете, наведите курсор на код, и вы получите объяснение того, что означает этот термин. Если вы все еще не можете этого понять, Google и ChatGPT - ваши лучшие друзья. И вы можете найти подробные объяснения практически обо всем на форумах, таких как stackoveflow.com.",
                    "Не пропускайте раздел отладки во второй части. Это один из самых важных навыков, которому вы научитесь в этом руководстве, и он будет жизненно важен для будущих проектов."
                },
                 Challenges = new List<string>
                {
                    "Создайте функциональность, которая будет подсчитывать количество раз, когда использовался калькулятор.",
                    "Сохраните список с последними расчетами. И дайте пользователям возможность удалить этот список.",
                    "Разрешите пользователям использовать результаты из приведенного выше списка для выполнения новых вычислений.",
                    "Добавьте дополнительные вычисления: квадратный корень, возведение в степень, 10x, тригонометрические функции"
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Проверка кода",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если вы хотите, чтобы ваш код был проверен членом C# Academy, вместо создания собственного репозитория, <a href='article/52/code-reviews' target='blank'>читайте этой статье</a>, где вы узнаете, как создать fork из нашего базового репозитория."
                            }
                        }
                    }
                }

            },
             new Project
            {
                Id = 12,
                Title = "Отслеживание привычек (Habit Logger)",
                IconUrl = projects.FirstOrDefault(p => p.Id == 12).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 12).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 12).Slug,
                Description = "Создайте логгер по привычке. Узнайте, как взаимодействовать с базой данных с помощью SQLite, а также получать и проверять вводимые пользователем данные",
                Area = projects.FirstOrDefault(p => p.Id == 12).Area,
                Level = projects.FirstOrDefault(p => p.Id == 12).Level,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 12).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 12).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 12).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 12).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Это очень простое приложение, которое научит вас, как выполнять <a href='https://en.wikipedia.org/wiki/Create,_read,_update_and_delete'>CRUD-операции</a> с реальной базой данных. Эти операции являются основой веб-разработки, и вы будете использовать их на протяжении всей своей карьеры в большинстве приложений. Мы считаем, что очень важно делать это с самого начала вашего пути, поскольку все, что будет происходить дальше, только усложняет операции CRUD. Независимо от того, насколько сложным и навороченным является приложение, которое вы создаете, в конечном итоге все сводится к выполнению CRUD-вызовов к базе данных."
                    },
                    new Paragraph
                    {
                        Body="Для этого вам придется выучить очень простые <a href='https://en.wikipedia.org/wiki/SQL'>SQL команды</a>. Я знаю, это звучит пугающе, но вы будете поражены тем, как мало знаний SQL вам нужно для создания полнофункционального приложения. Не волнуйтесь, мы возьмем вас за руку, и к концу вы завершите свое первое полностью функционирующее CRUD-приложение. Наиболее распространенные способы вызова базы данных SQL с помощью C# - это <a href='https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/'>ADO.NET</a>, Dapper и Entity Framework. Мы начнем с использования ADO.NET, потому что это наиболее близко к необработанному SQL."
                    },
                    new Paragraph
                    {
                        Body="Если вы считаете, что этот проект слишком сложен для вас, и вы понятия не имеете, с чего даже начать, вы, вероятно, правы. Возможно, вам понадобятся дополнительные руки, чтобы самостоятельно создать реальное приложение. Если это так, <a href='https://youtu.be/d1JIJdDVFjs'>посмотрите видеоурок по этому проекту</a>, а затем вернитесь и попробуйте еще раз самостоятельно. Совершенно нормально чувствовать себя потерянным, поскольку большинство курсов для начинающих на самом деле не учат вас, как что-то создавать."
                    },
                    new Paragraph
                    {
                        Body="Так что вперед!"
                    }
                },
                Requirements = new List<string>
                {
                    "Это приложение, в котором вы зарегистрируете одну привычку",
                    "Эту привычку нельзя отследить по времени (например, часам сна), только по количеству (например, количеству стаканов воды в день)",
                    "Приложение должно хранить и извлекать данные из реальной базы данных",
                    "Когда приложение запускается, оно должно создать базу данных sqlite, если таковой нет.",
                    "Оно также должно создать таблицу в базе данных, где будет регистрироваться привычка.",
                    "Приложение должно показывать пользователю меню опций.",
                    "Пользователи должны быть возможность вставлять, удалять, обновлять и просматривать свои зарегистрированные привычки.",
                    "Вы должны обработать все возможные ошибки, чтобы приложение никогда не выходило из строя.",
                    "Приложение должно завершаться только тогда, когда пользователь вводит 0.",
                    "Вы можете взаимодействовать с базой данных только с помощью простого SQL. Вы не можете использовать средства отображения, такие как Entity Framework.",
                    "Ваш проект должен содержать файл ReadMe, в котором вы объясните, как работает ваше приложение. Вот хороший пример:"
                },
                RequirementsConclusion = "<a href='https://github.com/thags/ConsoleTimeLogger'>Проект на Github с примером аккуратного файла ReadMe.</a><br>Не паникуй! Я помогу! 😁",
                Tips = new List<string>
                {
                    "Протестируйте свои SQL-команды в DB Browser, прежде чем использовать их в своей программе.",
                    "Вы можете сохранить весь код в одном классе, если хотите.",
                    "Используйте оператор switch для меню пользовательского ввода.",
                    "Не забывайте о проверке пользовательского ввода: проверьте наличие неверные даты. Что произойдет, если выбран пункт меню, который недоступен? Что произойдет, если пользователи введут строку вместо числа?"
                },
                 Challenges = new List<string>
                {
                    "Позвольте пользователям создавать свои собственные привычки для отслеживания. Для этого потребуется, чтобы вы позволили им выбрать единицу измерения каждой привычки.",
                    "Ввод данных в базу данных автоматически при первом создании базы данных, генерируя несколько привычек и вставляя сотню записей со случайно сгенерированными значениями. Это особенно полезно во время разработки, так что вам не придется повторно вставлять данные каждый раз при создании базы данных. ",
                    "Создайте функциональность отчета, в которой пользователи смогут просматривать конкретную информацию (например, сколько раз пользователь пробегал за год? сколько километров?) SQL позволяет вам запрашивать очень интересные вещи из вашей базы данных"
                },
                 LearningIntro = "Если вы изучили основы C#, следуя статье <a href='article/8/foundations' target='blank'>C# Foundations</a>, вы должны знать все основные приемы, необходимые для завершения этого проекта. Вот список того, что вам понадобится для выполнения этих требований:",
                 LearningItems = new List<string>
                 {
                     "Прием пользовательского ввода с консоли.",
                     "Печать сообщений на консоли.",
                     "Установка пакетов nuget (ASP.NET библиотеки, которые помогут вам написать вашу программу).",
                     "Базовый поток управления с операторами 'if-else' и 'switch'",
                     "Подключение к базе данных Sqlite.",
                     "Основы SQL (язык, который вы используете для взаимодействия с базой данных). Если вы хотите немного потренироваться в SQL перед началом работы, <a href='https://www.w3schools.com/sql/sql_exercises.asp'>вот отличное место</a>."
                 },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Создание проекта",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "В этом руководстве требуется, чтобы вы уже настроили среду разработки .NET. Если вы еще этого не сделали, ознакомьтесь с <a href='article/7/setting-up' target='blank'>этой статьей</a> с первыми шагами. Если вы абсолютно точно хотите использовать другую IDE, дайте мне знать."
                            },
                            new Paragraph
                            {
                                Body = "1. В Visual Studio выберите Создать новый проект. Если вы используете Visual Studio Code, дайте мне знать, если у вас возникнут трудности с созданием проекта.<br>2. Найдите консольное приложение (Console Application) и нажмите Далее.<br>3. Выберите название проекта и местоположение и нажмите Далее.<br>3. Выберите последнюю версию фреймворка (.NET 8 на момент написания этого руководства) и нажмите Создать.<br>4. Запустите свое приложение, нажав на зеленую кнопку воспроизведения в верхней части экрана."
                            },
                            new Paragraph
                            {
                                Body = "Откроется терминал (интерфейс командной строки) и напечатает 'Hello World', и приложение закроется само. Это означает, что ваше приложение ASP.NET среда и ваше приложение работают должным образом."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Изменение вашего рабочего каталога",
                        ImgUrl = "icons8-folder-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Таким образом.NET создаст ваш проект в вашей основной папке. По умолчанию он создает ваш проект в папке bin, и просто для простоты мы хотим избежать этого. Это создаст папку свойств с файлом <b>launchsettings.json</b>, содержащим информацию о вашей конфигурации. Это важный шаг только для приложений, использующих Sqlite, поскольку вы хотите, чтобы база данных создавалась в той же папке приложения, чтобы избежать путаницы."
                            },
                            new Paragraph
                            {
                                Body = "Для этого нажмите на шеврон рядом с названием вашего приложения в верхнем меню, выберите Свойства отладки ({название приложения} Debug Properties) и скопируйте путь к вашему каталогу в поле 'Рабочий каталог (Working Directory)'. Чтобы узнать, каков ваш путь, вы можете щелкнуть правой кнопкой мыши по своему проекту в обозревателе решений и выбрать 'Скопировать полный путь (Copy Full Path)' или посмотреть его в проводнике файлов (Files Explorer). Если вы используете Mac/Visual Studio Code, свяжитесь со мной, и я расскажу вам, как это сделать."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-1.png"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "working-directory-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Начинайте кодировать!",
                        ImgUrl = "icons8-coding-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "всякий раз, когда вы запускаете свое приложение, оно должно проверять наличие базы данных. Если ее нет, оно создаст ее вместе с таблицей, в которой вы будете хранить свои данные. Если вы удаляете свою базу данных извне, она всегда будет создаваться. Если база данных существует, она перейдет к следующему шагу: примите вводимые пользователем данные о том, что вы хотите сделать. Что-то вроде этого:"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "habit-menu.png"
                            },
                            new Paragraph
                            {
                                Body = "В ASP.NET Разработке на C# SQL Server используется очень часто. Но мы не будем использовать его здесь. SQLite - это сверхлегкая система баз данных, и важно ознакомиться с ней, прежде чем переходить к SQL server."
                            },
                            new Paragraph
                            {
                                Body = "Вам нужно будет указать вашей программе создать файл sqlite. Вы сможете визуализировать этот файл извне с помощью небольшого приложения. <a href='https://www.youtube.com/watch?v=HQKwgk6XkIA'>Вот ссылка на базовый учебник по sqlite</a>."
                            },
                            new Paragraph
                            {
                                Body = "Вот где начинается ваш настоящий код! На какое-то время вы предоставлены сами себе. Если вы застряли, продолжайте пытаться, <a href='article/6/getting-help' target='blank'>запомните шаги по отладке вашего приложения / открепитесь</a>. И если вы в конечном итоге не сможете этого сделать, обратитесь к нашему <a href='https://discord.gg/JVnwYdM79C'>сообществу Discord</a> или ко мне, и мы поможем!"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Видеоурок",
                        ImgUrl = "external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если вы чувствуете себя совершенно потерянным, вполне нормально посмотреть видео-урок, который поможет вам в работе. Здесь вы научитесь соединять все части для создания реального приложения. Как только вы закончите, обязательно попробуйте еще раз самостоятельно, без помощи видео, чтобы усвоить вновь приобретенные знания."
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/d1JIJdDVFjs"
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Управление исходным кодом",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если это ваш первый урок, у вас может возникнуть соблазн пропустить этот шаг и начать кодировать. Не делайте этого, иначе вам придется учиться на собственном горьком опыте. Однажды, после многочасовой работы над сложной задачей, вы не сохраните свою работу в репозитории системы управления версиями, и по какой-либо причине все это будет потеряно."
                            },
                            new Paragraph
                            {
                                Body = "Возьмите за привычку сохранять каждую строку кода, которую вы когда-либо писали. Я обещаю, что это избавит вас от многих головных болей. Все серьезные разработчики сохраняют свою работу в репозитории. Наиболее часто используемый - Github. Создайте учетную запись, если вы еще этого не сделали."
                            },
                            new Paragraph
                            {
                                Body="1. В Visual Studio перейдите в Git > Create Git Repository<br>2. Введите свои данные для входа в систему<br>3. Нажмите 'Create' и нажмите 'Push'."
                            },
                            new Paragraph
                            {
                                Body="✅ Сделано! Ваш репозиторий готов к работе. Не забывайте фиксировать и продвигать свои изменения после каждого шага!"
                            }, new Paragraph
                            {
                                Body="Вы можете сделать следующий шаг и узнать, как интегрировать Github с Visual Studio, просмотрев этот видеоурок:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Проверка кода",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если вы хотите, чтобы ваш код был проверен членом C# Academy, вместо создания собственного репозитория, <a href='article/52/code-reviews' target='blank'>читайте этой статье</a>, где вы узнаете, как создать fork из нашего базового репозитория."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Следующий шаг: Настольное приложение",
                        ImgUrl = "icons8-staircase-80.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если вы просмотрели <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>весь курс C# Foundation</a>, вы уже создали настольное приложение для Math Game\t, используя удивительный .NET MAUI. Будет отличной практикой создать настольное приложение для отслеживания привычек с той же функциональностью, которую вы создали для этого консольного приложения. Возникнут некоторые трудности, но у вас уже есть все необходимые навыки. И помните, если вы застряли, свяжитесь с нашим <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>сообществом Discord</a>, и мы поможем!"
                            }
                        }
                    },
                }
            },
             new Project
             {
                Id = 13,
                Title = "Отслеживатель кодирования (Coding Tracker)",
                IconUrl = projects.FirstOrDefault(p => p.Id == 13).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 13).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 13).Slug,
                Level = projects.FirstOrDefault(p => p.Id == 13).Level,
                Description = "Отслеживайте время, затраченное на написание кода. Узнайте, как работать с датами, использовать разделение задач и использовать свою первую внешнюю библиотеку для улучшения вашего приложения",
                Area = projects.FirstOrDefault(p => p.Id == 13).Area,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 13).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 13).Difficulty,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 13).DisplayOrder,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 13).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Это приложение должно быть очень похоже на <a href='project/13/coding-tracker' target='blank'>Отслеживание привычек</a>, который вы ранее заполнили. Это послужит цели закрепить то, что вы узнали, с помощью небольшого повторения и развить эти знания с немного более сложными требованиями."
                    },
                    new Paragraph
                    {
                        Body="На этот раз вам придется столкнуться со сложностью обработки дат и времени, что является реальной проблемой в любом приложении. Вы также будете использовать свою первую внешнюю библиотеку. Часто в профессиональных средах программисты не заново изобретать колесо и экономят время, используя общедоступные решения, предоставляемые другими программистами. В этом прелесть Интернета. У вас есть доступ к удивительному сообществу программистов!"
                    },
                    new Paragraph
                    {
                        Body="В первом приложении у нас также не было требований к организации кода. На этот раз вам придется использовать <a href='https://en.wikipedia.org/wiki/Separation_of_concerns'>разделение задач (separation of concerns)</a>, один из важнейших принципов современного программирования. Именно здесь вы начнете применять концепции объектно-ориентированного программирования. Вам также нужно будет использовать “Модель (Model)” или “Сущность (Entity)” для представления данных, с которыми вы имеете дело. В данном случае, ваши сеансы кодирования. Итак, давайте начнем!"
                    }
                },
                Requirements = new List<string>
                {
                    "Это приложение имеет те же требования, что и предыдущий проект, за исключением того, что теперь вы будете регистрировать свое ежедневное время кодирования.",
                    "Чтобы отобразить данные на консоли, вы должны использовать \"Spectre.Консоль\" библиотека.",
                    "Вам требуется иметь отдельные классы в разных файлах (напр. userInput.cs, Validation.cs, CodingController.cs)",
                    "Вы должны указать пользователю конкретный формат, в котором вы хотите регистрировать дату и время, и не разрешать какой-либо другой формат.",
                    "Вам нужно будет создать файл конфигурации, который будет содержать путь к базе данных и строки подключения.",
                    "Вам нужно будет создать класс \"CodingSession\" в отдельном файле. Он будет содержать свойства вашей сессии кодирования: идентификатор, время начала, время окончания, продолжительность",
                    "Пользователь не должен вводить продолжительность сессии. Оно должно быть рассчитано на основе времени начала и окончания отдельным методом \"CalculateDuration\".",
                    "Пользователь должен иметь возможность вводить время начала и окончания вручную.",
                    "Вам нужно использовать Dapper ORM для доступа к данным вместо ADO.NET. (Это требование было включено в феврале/2024)",
                    "При чтении из базы данных вы не можете использовать анонимный объект, вы должны считывать свою таблицу в список сеансов кодирования"
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://spectreconsole.net/'>Документация по Spectre Console</a>.",
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Использование Configuration Manager</a>",
                    "<a target='_blank' href='https://stackoverflow.com/questions/3719/how-to-validate-a-datetime-in-c'>Парсинг даты и времени в C#</a>",
                    "<a target='_blank' href='https://www.learndapper.com/'>Руководство по Dapper</a>.",
                },
                ResourcesIntro = "Если вы изучили основы C#, следуя статье <a href='article/8/foundations' target='blank'>C# Foundations</a> и завершили проект <a href='project/12/habbit-logger' target='blank'>Отслеживание привычек</a>, вы должны знать все основные методы, необходимые для завершения этого проекта. Вот список дополнительных ресурсов, которые могут вам понадобиться:",
                Tips = new List<string>
                {
                    "Вам решать, в каком порядке вы будете создавать, но мы рекомендуем вам делать это в следующем порядке: файл конфигурации, модель, создание базы данных/таблицы, CRUD-контроллер (где будут выполняться операции), TableVisualisationEngine (где будет выполняться код spectreconsole) и, наконец: проверка данных.",
                    "Sqlite не поддерживает даты. Мы рекомендуем вам сохранить datetime в виде строки в базе данных, а затем разбирать его с помощью C#. Вам нужно будет разбирать его, чтобы рассчитать продолжительность ваших сеансов.",
                    "Не забывайте отправлять свои изменения на github каждый раз, когда вы прекращаете работать",
                    "Не забывайте о проверке пользовательского ввода: проверьте, нет ли неправильных дат. Что произойдет, если выбран пункт меню, который недоступен? Что произойдет, если пользователи введут строку вместо числа? Помните, что дата окончания не может быть раньше даты начала."
                },
                 Challenges = new List<string>
                {
                    "Добавьте возможность отслеживания времени кодирования с помощью stopwatch, чтобы пользователь мог отслеживать сеанс по мере его прохождения.",
                    "Позвольте пользователям фильтровать свои записи кодирования по периодам (неделям, дням, годам) и/или упорядочивать по возрастанию или убыванию.",
                    "Создавайте отчеты, в которых пользователи могут видеть их общая и средняя сессия кодирования за период.",
                    "Создайте возможность устанавливать цели кодирования и показывать, как далеко пользователи находятся от достижения своей цели, а также сколько часов в день им пришлось бы кодировать, чтобы достичь своей цели. Вы можете сделать это с помощью SQL-запросов или с помощью C#.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Создание конфигурационного файла",
                        ImgUrl = "external-configuration-computer-itim2101-lineal-color-itim2101-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "В продвинутых приложениях свойства конфигурации хранятся в xml-файле. Эта практика упрощает настройку вашего приложения в рабочей среде. Сейчас в этом нет абсолютной необходимости, но освоить ее несложно, и вам следует привыкнуть к ней с самого начала вашего пути программирования. Это делает ваш код более чистым и организованным. <a href='https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file'>Ознакомьтесь с документацией</a> и, при необходимости, найдите “файл конфигурации C#” на Youtube."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Создание настольного приложения",
                        ImgUrl = "icons8-desktop-computer-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если вы просмотрели <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE'>весь курс C# Foundation</a>, вы уже создали настольное приложение для Math Game Desktop, используя удивительный .NET MAUI. Будет отличной практикой создать настольное приложение для отслеживания кодирования с той же функциональностью, которую вы создали для этого консольного приложения. Возникнут некоторые трудности, особенно если вы хотите создать таймер, но у вас уже есть все необходимые навыки. И помните, если вы застряли, свяжитесь с нашим <a target='_blank' href='https://discord.gg/JVnwYdM79C'>сообществом Discord</a>, и мы поможем!"
                            }
                        }
                    }
                }
            },
             new Project
            {
                Id = 14,
                Title = "Флэш-карты",
                IconUrl = projects.FirstOrDefault(p => p.Id == 14).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 14).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 14).Slug,
                Level = projects.FirstOrDefault(p => p.Id == 14).Level,
                Description = "Создание пачки (stacks) флэш-карты и функционала для изучения. Научитесь работать с реляционными  базами данных с помощью SQL Server и использовать объекты передачи данных (Data Transfer Objects)",
                Area = projects.FirstOrDefault(p => p.Id == 14).Area,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 14).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 14).Difficulty,
                RepositoryLink = GetProjects().FirstOrDefault(p => p.Id == 14).RepositoryLink,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="После первых двух проектов вы должны быть в некоторой степени знакомы с тем, как все работает в C#. Пришло время немного усложнить задачу. Вы будете использовать <b>SQL Server</b> в первый раз. Мы могли бы продолжать использовать SQLite, поскольку он делает все необходимое для большинства небольших приложений, но SQL Server широко используется в отрасли, и чем раньше мы с ним познакомимся, тем лучше."
                    },
                    new Paragraph
                    {
                        Body="На этот раз база данных также будет немного сложнее. У нас будут две таблицы, связанные внешним ключом. И впервые мы будем работать с <a href='https://www.codeproject.com/Articles/1050468/Data-Transfer-Object-Design-Pattern-in-Csharp' target='_blank'>DTOs (Data Transfer Objects)</a>, которые помогут нам использовать один и тот же объект по-разному."
                    },
                    new Paragraph
                    {
                        Body="Пора начинать!"
                    }
                },
                Requirements = new List<string>
                {
                    "Это приложение, в котором пользователи будут создавать пачки (stacks) флэш-карты.",
                    "Вам понадобятся две разные таблицы для stacks (пачек) и flashcards (флэш-карт). Таблицы должны быть связаны внешним ключом.",
                    "Stacks должны иметь уникальное имя.",
                    "Каждая флэш-карта должна быть частью пачки. Если стек удален, то же самое должно произойти и с флэш-картой.",
                    "Вы должны использовать DTO, чтобы показывать флэш-карты пользователю без идентификатора стека, к которому они принадлежат",
                    "При показе стека пользователю идентификаторы флэш-карт всегда должны начинаться с 1 без пробелов между ними. Если у вас 10 карточек и номер 5 удален, в таблице должны отображаться идентификаторы от 1 до 9.",
                    "После создания функциональных возможностей флэш-карты создайте \"Study Session\" (Учебная сессия), где пользователи будут изучать пачки. Все учебные сессии должны быть сохранены с указанием даты и оценки.",
                    "Таблицы study area и stacks должны быть связаны. Если stacks удален, его учебные сессии должны быть удалены.",
                    "Проект должен содержать обращение к учебной таблице, чтобы пользователи могли видеть все свои учебные сессии. Эта таблица получает вызовы insert при каждой учебной сессии, но к ней не должно быть обращений update и delete."
                },
                Tips = new List<string>
                {
                    "Прежде чем приступить к написанию кода, попробуйте создать таблицы и выполнить несколько CRUD-запросов в SQL Server, чтобы ознакомиться с SQL Server Studio.",
                    "Для управления stacks позвольте пользователю выбрать stack по имени.",
                    "Подумайте о \"stacks\" и \"study\" области применения почти как отдельные приложения. Область study просто использует данные из области stacks."
                },
                LearningIntro = "Если вы изучили основы C#, следуя статье <a href='https://www.youtube.com/watch?v=o81wpRuOGjE&list=PL4G0MUH8YWiAMypwveH2LlLK_o8Jto9CE' target='_blank'>C# Foundations </a>, вы должны знать все основные приемы, необходимые для завершения этого проекта. Вот список того, что вам понадобится для выполнения этих требований:",
                LearningItems = new List<string>
                 {
                     "Использование SQL Server.",
                     "Создание связанных таблиц с помощью SQL.",
                     "Использование DTO для создания разных версий классов.",
                     "<a href='https://www.youtube.com/watch?v=bNetxDl40pM' target='_blank'>Pivoting Tables in SQL</a>"
                 },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Установка SQL Server",
                        ImgUrl = "icons8-sql-server-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Это первый проект в академии, где мы будем использовать SQL Server. <a href='https://docs.microsoft.com/en-us/sql/tools/visual-studio-code/sql-server-develop-use-vscode?view=sql-server-ver15'> Вы можете работать с SQL Server с помощью Visual Studio.</a>. Но я рекомендую вам начать с Microsoft SQL Server Management Studio. Для этого приложения не используйте SQL Server EXPRESS, а только локальную базу данных. <a href='https://www.youtube.com/watch?v=QsXWszvjMBM'> Вот руководство по установке studio</a>. И вот руководство по <a href='https://www.youtube.com/watch?v=M5DhHYQlnq8'> как подключиться к вашей локальной базе данных</a>"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Дополнительные задачи",
                        ImgUrl = "icons8-courage-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Если вы хотите расширить этот проект, вот идея. Попробуйте создать систему отчетов, в которой вы сможете видеть количество сеансов в месяц для каждой пачек. И еще один со средним баллом за месяц для каждой пачек. Это непростая задача, если вы только начинаете работать с базами данных, но она научит вас всей мощи SQL и возможностям, которые он дает вам для того, чтобы задавать интересные вопросы из ваших таблиц."
                            },
                            new Paragraph
                            {
                                Body = "Ниже приведен скриншот с примером готового отчета. Вам нужно будет узнать о сводных таблицах (Pivoting Tables), чтобы выполнить это задание. Обращайтесь, если вам нужна помощь!"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "flashcards-8.png"
                            }
                        }
                    }
                },
                Screenshots = new List<string>
                {
                    "flashcards-1.png",
                    "flashcards-2.png",
                    "flashcards-3.png",
                    "flashcards-4.png",
                    "flashcards-5.png",
                    "flashcards-6.png",
                    "flashcards-7.png"
                }
            },
             new Project
            {
                Id = 15,
                Title = "Информация о напитках",
                IconUrl = projects.FirstOrDefault(p => p.Id == 15).IconUrl,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 15).BannerUrl,
                LanguageHeadings = new EnglishHeadings(),
                Slug = projects.FirstOrDefault(p => p.Id == 15).Slug,
                Level = projects.FirstOrDefault(p => p.Id == 15).Level,
                Description = "Создайте консольное приложение для использования внешнего API с HTTP-запросами на C#",
                Area = projects.FirstOrDefault(p => p.Id == 15).Area,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 15).ExperiencePoints,
                Difficulty = projects.FirstOrDefault(p => p.Id == 15).Difficulty,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Часто разработчики работают с данными сторонних разработчиков. Очень распространенным способом доступа к данным внешних данных является отправка запросов к их API (Application Programming Interface). Как только мы получим доступ к их данным, мы сможем обрабатывать их в нашем приложении в соответствии с нашими потребностями. Другой распространенный сценарий - это когда в организации есть несколько независимых приложений, которые взаимодействуют между собой. <a href='https://en.wikipedia.org/wiki/Microservices'>Так называемые микросервисы</a>."
                    },
                    new Paragraph
                    {
                        Body="В этом приложении мы узнаем, как подключиться к внешнему API с помощью HTTP-запросов, используя библиотеки классов .NET. Это проще, чем вы можете себе представить! К счастью, существует множество общедоступных API. <a href='https://github.com/public-apis/public-apis'> Вот отличный список общедоступных API для практики.</a>"
                    }
                },
                Requirements = new List<string>
                {
                    "Ресторан нанял вас для разработки решения для их меню напитков",
                    "Их меню напитков предоставляется сторонней компанией. Все данные о напитках находятся в базе данных компаний, доступной через API.",
                    "Ваша задача - создать систему, которая позволит сотруднику ресторана извлекать данные из любого напитка в базе данных.",
                    "Здесь вам не нужен SQL, так как вы не будете работать с базой данных. Все, что вам нужно, - это создать удобный способ представления данных пользователям (сотрудникам ресторана).",
                    "Когда пользователи открывают приложение, им должно быть представлено меню категории напитков и предложено выбрать категорию. Тогда у них будет возможность выбрать напиток и просмотреть информацию о нем",
                    "Когда пользователи визуализируют детали напитка, не должно быть никаких свойств с пустыми значениями."
                },
                RequirementsConclusion = "Не пугайтесь! Мы поможем! 😁",
                ResourcesIntro = "Вот ссылки на использование HTTP-вызовов с помощью C# и на документацию Drinks API:",
                Resources = new List<string>
                {
                    "<a href='https://www.thecocktaildb.com/api.php' target='_blank'>Cocktail Database</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient' target='_blank'>Документы Microsoft: Http Requests</a>",
                    "<a href='https://www.youtube.com/watch?v=fc7peZ-FHs4' target='_blank'>Видео: Drinks Info App (ПОЛНЫЙ ПРОЕКТ)</a>"
                },
                Screenshots = new List<string>
                {
                    "drinks-1.png"
                }
            }
        };
    }
    internal static List<Project> GetProjectsInPolish()
    {
        var projects = GetProjects();

        return new List<Project>
        {
             new Project
            {
                Id = 11,
                Title = "Kalkulator",
                IconUrl = projects.FirstOrDefault(p => p.Id == 11).IconUrl,
                Slug = projects.FirstOrDefault(p => p.Id == 11).Slug,
                BannerUrl = projects.FirstOrDefault(p => p.Id == 11).BannerUrl,
                LanguageHeadings = new PolishHeadings(),
                Level = projects.FirstOrDefault(p => p.Id == 11).Level,
                Description = "Stworzysz kalkulator korzystając z pomocy dokumentacji Microsoftu",
                Area = projects.FirstOrDefault(p => p.Id == 11).Area,
                Difficulty = projects.FirstOrDefault(p => p.Id == 11).Difficulty,
                ExperiencePoints = projects.FirstOrDefault(p => p.Id == 11).ExperiencePoints,
                DisplayOrder = projects.FirstOrDefault(p => p.Id == 11).DisplayOrder,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="W drugim projekcie stworzysz Kalkulator z dokumentacji Microsoftu. Nie powinien on być trudniejszy od poprzedniego, ale nauczysz się przydatnych umiejętności, takich jak zarządzanie wieloma projektami w jednym rozwiązaniu, zapisywanie do plików i debugowanie. Poćwiczysz też coś bardzo ważnego: pracę z dokumentacją. Jako programista będziesz to robić regularnie, dlatego tak ważne jest, żebyś czuł się pewnie korzystając z dokumentacji przy tworzeniu oprogramowania."
                    }
                },
                Requirements = new List<string>
                {
                    @"Ukończ poniższy samouczek (część 1 i 2): <a href='https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022'>Stwórz kalkulator (Dokumentacja Microsoftu)</a>. Link do części drugiej znajdziesz na dole strony."
                },
                RequirementsIntro = "Projekt ma tylko jedno wymaganie:",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-mac'>Visual Studio dla komputerów Mac</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0'>Visual Studio Code</a>"
                },
                ResourcesIntro = "Instrukcje dotyczące tego projektu są oparte na programie Visual Studio dla systemów Windows. Kod, który napiszesz, będzie taki sam niezależnie od edytora kodu, ale proces tworzenia nowego projektu będzie się różnił. Poniżej znajdują się linki dotyczące tworzenia aplikacji konsolowej za pomocą różnych edytorów: ",
                Tips = new List<string>
                {
                    "Nie spiesz się, nawet jeśli ten samouczek jest dla ciebie łatwy. Upewnij się, że rozumiesz KAŻDE słowo. Dokładnie wszystko przeanalizuj!",
                    "Jeśli jest coś czego nie rozumiesz, najedź kursorem nad fragment kodu, a wyświetli ci się wyjaśnienie danego terminu. A jeśli nadal będziesz miał wątpliwości to twoimi najlepszymi przyjaciółmi są Google i Chat GPT. Na forach takich jak stackoverflow.com znajdziesz też wyjaśnienie praktycznie wszystkiego.",
                    "Nie pomijaj sekcji dotyczącej debugowania w części drugiej. To jedna z najważniejszych umiejętności, której się nauczysz w tym samouczku i będzie ona kluczowa w przyszłych projektach."
                },
                 Challenges = new List<string>
                {
                    "Stwórz funkcję, która będzie zliczała ile razy użyto kalkulatora.",
                    "Przechowuj listę z ostatnimi obliczeniami. Użytkownicy powinni mieć możliwość usunięcia tej listy.",
                    "Pozwól użytkownikom wykorzystać wyniki z powyższej listy do nowych obliczeń.",
                    "Dodaj nowe działania: Pierwiastkowanie, Potęgowanie, 10x, Funkcje trygonometryczne.",
                },
                 Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Przegląd kodu",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Jeśli chcesz, aby twój kod był sprawdzony przez członka The C# Academy, zamiast tworzyć własne repozytorium, <a href='article/52/code-reviews' target='blank'>zapoznaj się z tym artykułem</a>. Dowiesz się w nim jak utworzyć tzw. fork naszego repozytorium bazowego do przeglądu kodu."
                            }
                        }
                    }
                }

            },
        };
    }
}
