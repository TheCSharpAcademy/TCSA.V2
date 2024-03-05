using TCSA.V2.Data;
using TCSA.V2.Models;

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
                Slug = "math-game",
                Description = "In your first project, you’ll create a math game to reinforce what you've learned in the Foundations area",
                Area = Area.Console,
                Level = Level.Green,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder= 1,
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
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52' target='blank'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
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
                Level = Level.OliveGreen,
                Description = "This you’ll create a calculator with the help of Microsoft's Documentation",
                Area = Area.Console,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 10,
                DisplayOrder = 2,
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
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52' target='blank'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
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
                Slug = "habit-logger",
                Description = "Build a logger for a habit of choice. Learn how to interact with a database using SQLite and to get and validate user input",
                Area = Area.Console,
                Level = Level.OliveGreen,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 3,
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
                 LearningIntro = "If you have learned the basics of C# following the <a href='article/8' target='blank'>C# Foundations</a> article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
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
                                Body = "This tutorial requires that you already have set up your .NET environment. If you haven’t yet, check <a href='article/7' target='blank'>this article</a> out with the first steps. If you absolutely want to use another IDE, let me know."
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
                                Body = "That’s where your actual code begins! You’re on your own for a while. If you get stuck, keep trying, <a href='article/6' target='blank'>remember the steps to debug your app/get unstuck</a>. And if you ultimately can’t do it, reach out to our <a href='https://discord.gg/JVnwYdM79C'>Discord Community</a> or myself and we will help!"
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
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
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
                Slug = "coding-tracker",
                Level = Level.OliveGreen,
                Description = "Track your coding hours. Learn how to deal with dates, to use separation of concerns and use your first external library to enhance your application",
                Area = Area.Console,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 4,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This app should be very similar to the <a href='article/12' target='blank'>Habit Tracker</a> you’ve previously completed. It will serve the purpose of reinforcing what you’ve learned with a bit of repetition and building on that knowledge with slightly more challenging requirements. "
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
                ResourcesIntro = "If you have learned the basics of C# following the <a href='article/8' target='blank'>C# Foundations</a> article, and completed the <a href='article/12' target='blank'>Habit Tracker</a> project, you should know all the basic techniques needed to complete this project. Here’s a list of extra resources you might need:",
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
                Slug = "flashcards",
                Level = Level.Yellow,
                Description = "Building stacks of flashcards and a study functionality. Learn to deal with linked databases using SQL Server and to use Data Transfer Objects",
                Area = Area.Console,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug = "drinks",
                Description = "Build a console app to consume an external API with HTTP Requests with C#",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug = "phonebook",
                Description = "Now you have basic understanding of SQL, it’s time to learn the basics of Entity Framework with a CRUD Phone Book Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug="shifts-logger",
                Description = "Build an App for shift workers to log their hours. In this app you’ll learn how to build a Web API and consume it with a Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug="exercise-tracker",
                Description = "Learn the repository pattern, the most common design pattern for interaction with databases",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
                Slug="sports-results",
                Description = "Learn how to create a web crawler and send e-mails using C#",
                Area = Area.Console,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
                Level = Level.Orange,
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
                    "Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern.",
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
                Description = "Learn how to read data from an Excel Sheet into a real database using SQL",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
                Slug="unit-testing",
                Description = "The last piece of the puzzle before moving on to  front-end. Learn to test the business logic of your applications",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
        return new List<Project>
        {
             new Project
             {
                Id = 53,
                Title = "Wiskundespel",
                IconUrl = "icons8-maths-376.png",
                BannerUrl = "",
                Slug = "math-game",
                Description = "In je eerste project gaan je een wiskundespel maken om je kennis die je heeft opgebouwd in de Microsoft C# Foundations te versterken",
                Area = Area.Console,
                Level = Level.Green,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder= 1,
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
                                Body = "Als je wilt dat jouw code wordt beoordeeld door een lid van de C# Academy, in plaats van jouw eigen repository te maken, <a href='article/52' target='blank'>moet je dit artikel volgen</a>, waar je kan leren hoe je een fork kan maken vanuit onze basisrepository."
                            }
                        }
                    },
                }
            },
            /* new Project
            {
                Id = 11,
                Title = "Calculator",
                IconUrl = "icons8-calculator-512.png",
                Slug = "calculator",
                BannerUrl = "",
                Level = Level.OliveGreen,
                Description = "This you’ll create a calculator with the help of Microsoft's Documentation",
                Area = Area.Console,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 10,
                DisplayOrder = 2,
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
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52' target='blank'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
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
                Slug = "habit-logger",
                Description = "Build a logger for a habit of choice. Learn how to interact with a database using SQLite and to get and validate user input",
                Area = Area.Console,
                Level = Level.OliveGreen,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 3,
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
                 LearningIntro = "If you have learned the basics of C# following the <a href='article/8' target='blank'>C# Foundations</a> article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
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
                                Body = "This tutorial requires that you already have set up your .NET environment. If you haven’t yet, check <a href='article/7' target='blank'>this article</a> out with the first steps. If you absolutely want to use another IDE, let me know."
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
                                Body = "That’s where your actual code begins! You’re on your own for a while. If you get stuck, keep trying, <a href='article/6' target='blank'>remember the steps to debug your app/get unstuck</a>. And if you ultimately can’t do it, reach out to our <a href='https://discord.gg/JVnwYdM79C'>Discord Community</a> or myself and we will help!"
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
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
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
                Slug = "coding-tracker",
                Level = Level.OliveGreen,
                Description = "Track your coding hours. Learn how to deal with dates, to use separation of concerns and use your first external library to enhance your application",
                Area = Area.Console,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 4,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This app should be very similar to the <a href='article/12' target='blank'>Habit Tracker</a> you’ve previously completed. It will serve the purpose of reinforcing what you’ve learned with a bit of repetition and building on that knowledge with slightly more challenging requirements. "
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
                ResourcesIntro = "If you have learned the basics of C# following the <a href='article/8' target='blank'>C# Foundations</a> article, and completed the <a href='article/12' target='blank'>Habit Tracker</a> project, you should know all the basic techniques needed to complete this project. Here’s a list of extra resources you might need:",
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
                Slug = "flashcards",
                Level = Level.Yellow,
                Description = "Building stacks of flashcards and a study functionality. Learn to deal with linked databases using SQL Server and to use Data Transfer Objects",
                Area = Area.Console,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug = "drinks",
                Description = "Build a console app to consume an external API with HTTP Requests with C#",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug = "phonebook",
                Description = "Now you have basic understanding of SQL, it’s time to learn the basics of Entity Framework with a CRUD Phone Book Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug="shifts-logger",
                Description = "Build an App for shift workers to log their hours. In this app you’ll learn how to build a Web API and consume it with a Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug="exercise-tracker",
                Description = "Learn the repository pattern, the most common design pattern for interaction with databases",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
                Slug="sports-results",
                Description = "Learn how to create a web crawler and send e-mails using C#",
                Area = Area.Console,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
                Level = Level.Orange,
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
                    "Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern.",
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
                Description = "Learn how to read data from an Excel Sheet into a real database using SQL",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
                Slug="unit-testing",
                Description = "The last piece of the puzzle before moving on to  front-end. Learn to test the business logic of your applications",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
            },*/
        };
    }
    internal static List<Project> GetProjectsInKorean()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 53,
                Title = "수학 퀴즈 게임",
                IconUrl = "icons8-maths-376.png",
                BannerUrl = "",
                Slug = "math-game",
                Description = "첫 번째 프로젝트에서는 기초 부분에서 이미 배운 내용을 복습하기 위해 '수학 퀴즈 게임'을 만들어 보겠습니다.",
                Area = Area.Console,
                Level = Level.Green,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder= 1,
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
                                Body = "나만의 리포지토리를 만드는 것이 아니라 C# 아카데미에 소속된 멤버에게서 코딩 리뷰를 받으시고 싶으시다면, <a href='article/52' target='blank'>여기를 클릭해주세요</a>, 저희 리뷰 리포지토리를 기반으로 포크(fork)를 만드는 법을 배우실 수 있습니다."
                            }
                        }
                    },
                }
            },
             
            /*
            new Project
            {
                Id = 11,
                Title = "Calculator",
                IconUrl = "icons8-calculator-512.png",
                Slug = "calculator",
                BannerUrl = "",
                Level = Level.OliveGreen,
                Description = "This you’ll create a calculator with the help of Microsoft's Documentation",
                Area = Area.Console,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 10,
                DisplayOrder = 2,
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
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52' target='blank'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
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
                Slug = "habit-logger",
                Description = "Build a logger for a habit of choice. Learn how to interact with a database using SQLite and to get and validate user input",
                Area = Area.Console,
                Level = Level.OliveGreen,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 3,
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
                 LearningIntro = "If you have learned the basics of C# following the <a href='article/8' target='blank'>C# Foundations</a> article, you should know all the basic techniques needed to complete this project. Here’s a list of the things you’ll need to fulfil the requirements:",
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
                                Body = "This tutorial requires that you already have set up your .NET environment. If you haven’t yet, check <a href='article/7' target='blank'>this article</a> out with the first steps. If you absolutely want to use another IDE, let me know."
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
                                Body = "That’s where your actual code begins! You’re on your own for a while. If you get stuck, keep trying, <a href='article/6' target='blank'>remember the steps to debug your app/get unstuck</a>. And if you ultimately can’t do it, reach out to our <a href='https://discord.gg/JVnwYdM79C'>Discord Community</a> or myself and we will help!"
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
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
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
                Slug = "coding-tracker",
                Level = Level.OliveGreen,
                Description = "Track your coding hours. Learn how to deal with dates, to use separation of concerns and use your first external library to enhance your application",
                Area = Area.Console,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder = 4,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This app should be very similar to the <a href='article/12' target='blank'>Habit Tracker</a> you’ve previously completed. It will serve the purpose of reinforcing what you’ve learned with a bit of repetition and building on that knowledge with slightly more challenging requirements. "
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
                ResourcesIntro = "If you have learned the basics of C# following the <a href='article/8' target='blank'>C# Foundations</a> article, and completed the <a href='article/12' target='blank'>Habit Tracker</a> project, you should know all the basic techniques needed to complete this project. Here’s a list of extra resources you might need:",
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
                Slug = "flashcards",
                Level = Level.Yellow,
                Description = "Building stacks of flashcards and a study functionality. Learn to deal with linked databases using SQL Server and to use Data Transfer Objects",
                Area = Area.Console,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug = "drinks",
                Description = "Build a console app to consume an external API with HTTP Requests with C#",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug = "phonebook",
                Description = "Now you have basic understanding of SQL, it’s time to learn the basics of Entity Framework with a CRUD Phone Book Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug="shifts-logger",
                Description = "Build an App for shift workers to log their hours. In this app you’ll learn how to build a Web API and consume it with a Console App",
                Area = Area.Console,
                Level = Level.Yellow,
                ExperiencePoints = 20,
                Difficulty = Difficulty.Intermediate,
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
                Slug="exercise-tracker",
                Description = "Learn the repository pattern, the most common design pattern for interaction with databases",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
                Slug="sports-results",
                Description = "Learn how to create a web crawler and send e-mails using C#",
                Area = Area.Console,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
                Level = Level.Orange,
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
                    "Keep your application simple (only one table). Complexity is your enemy at the moment, since you want to focus solely on learning the pattern.",
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
                Description = "Learn how to read data from an Excel Sheet into a real database using SQL",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
                Slug="unit-testing",
                Description = "The last piece of the puzzle before moving on to  front-end. Learn to test the business logic of your applications",
                Area = Area.Console,
                Level = Level.Orange,
                ExperiencePoints = 30,
                Difficulty = Difficulty.Advanced,
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
            
             */
        };
    }

    internal static List<Project> GetProjectsInPortuguese()
    {
        return new List<Project>
        {
            new Project
             {
                Id = 53,
                Title = "Jogo de Matemática",
                IconUrl = "icons8-maths-376.png",
                BannerUrl = "",
                Slug = "math-game",
                Description = "Nesse primeiro projeto, você ira criar um jogo de matemática que irá reforçar o que você aprendeu na área de Fundamentos.",
                Area = Area.Console,
                Level = Level.Green,
                ExperiencePoints = 10,
                Difficulty = Difficulty.Beginner,
                DisplayOrder= 1,
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
                                Body = "Se você quer que seu código seja avaliado por um mebro da Academia C#, ao invés de criar seu próprio repositório, <a href='article/52' target='blank'>siga esse artigo</a>, onde você irá aprender a criar um fork do nosso diretório de revisões."
                            }
                        }
                    },
                }
            },
        };
    }
}
