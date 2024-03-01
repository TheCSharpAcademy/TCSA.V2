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
        };
    }
}
