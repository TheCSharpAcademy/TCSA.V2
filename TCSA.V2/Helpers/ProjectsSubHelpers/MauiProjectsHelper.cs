using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class MauiProjectsHelper
{
    internal static List<Project> GetProjects ()
    {
        return new List<Project>
        {
             new Project
            {
                Id = 43,
                Title = "Math Game",
                IconUrl = "icons8-maths-376.png",
                BannerUrl = "",
                Description = "Start your native app development journey building a simple game with the four basic mathematical operations",
                Area = Area.MAUI,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to .NET MAUI (Multi-platform App UI), the cross-platform framework for creating native mobile and desktop apps. Maybe you’ve heard of previous .NET solutions for native apps (Winforms, WPF, WinUI, Xamarin) and you might be wondering: Why MAUI? MAUI is the evolution from all those previous technologies, it’s the framework that has as an objective to provide a one-stop shop for anything todo with build applications in any device. "
                    },
                     new Paragraph
                    {
                        Body="Does that mean it’s not worth to learn those? The answer isn’t very simple. If you need to learn WPF for example for a job, then it’s better to be specific and learn that particular technology. Now for the long run it’s better to learn the latest solution. And the good news is that MAUI uses XAML as a mark-up and is commonly implemented with the MVVM (Model-View-ViewModel) design pattern. They’re both also used in WPF, WinUI and Xamarin, which means that the knowledge is easily transferrable amongst them."
                    },
                     new Paragraph
                    {
                        Body="But enough talk! Let’s build!"
                    }
                },
                Requirements = new List<string>
                {
                    "This application has only one requirement: You'll build a Math Game with MAUI (and no MVVM) with the help of the tutorial below:",
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/dotnet/maui/what-is-maui'>What is .NET MAUI?</a>",
                    "<a target='_blank' href='https://stackoverflow.com/questions/62729794/what-is-maui-and-what-are-differences-between-maui-and-xamarin'>Maui vs Xamarin</a>",
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/dotnet/maui/xaml/'>What is XAML?</a>",
                    "<a target='_blank' href='https://www.guru99.com/mvc-vs-mvvm.html'>MVC vs MVVM</a>"
                },
                ResourcesIntro = "Each video in the tutorial has many links in the description area. Here are some resources you can read before getting started:",
                Tips = new List<string>
                {
                    "If you've done any full-stack Web Dev, you'll be surprised with how easy the C# code is to develop a basic MAUI App. Your biggest challenge here will be to learn XAML. Make sure you don't rush through that.",
                    "Make a checklist of steps for the completion of the tutorial, along with a list of issues you encountered. Once you're done, repeat the project going through the lists.",
                    "Once you went through the project twice, tweak it with slightly different functionality and style."
                },
                Challenges = new List<string>
                {
                    "Try to implement levels of difficulty.",
                    "Add a timer to track how long the user takes to finish the game.",
                    "Add a function that let's the user pick the number of questions.",
                    "Create a 'Random Game' option where the players will be presented with questions from random operations"
                }
            },
             new Project
            {
                Id = 44,
                Title = "Books to Read",
                IconUrl = "icons8-bookshelf-512.png",
                BannerUrl = "",
                Description = "Build an app to keep track of reading activity using the MVVM pattern",
                Area = Area.MAUI,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 50,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="The objective of our second MAUI project is to get acquainted with the MVVM (Model-View-ViewModel) design pattern. The main purpose of MVVM is separation of concerns. With MVVM we will end up with smaller classes with less code. Using this pattern or not is a matter of personal style, but it’s widely adopted in enterprise because of the complexity of the domain. A large code base without separation of concerns in mind quickly turns into spaghetti: code that is less maintainable and testable. Smaller classes and methods with clear responsibility mean they’re easier to test. "
                    },
                     new Paragraph
                    {
                        Body="It does take a while to get used to MVVM, though. And it’s perfectly ok to feel lost at first. The learning curve can be steep, especially after doing so many projects using MVC. A mindset shift is needed. However it will pay off. MVVM is also used in Blazor and the previous .NET native solutions (WPF, Xamarin, WinUI), so this knowledge won’t be restricted to MAUI projects."
                    }
                },
                Requirements = new List<string>
                {
                    "As a preparation for this project, you should complete the Todo List tutorial by James Montemagno (link in the resources area)",
                    "This is a very simple app where you'll record data about books you want to read.",
                    "It should be similar to a todo list, but just for books.",
                    "Users should be able to perform all CRUD operations against the database.",
                    "To keep things simple and focus on MVVM, you'll have just one \"books\" table.",
                    "You should use the MVVM pattern.",
                    "You should use SQLite."


                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://www.youtube.com/watch?v=Hh279ES_FNQ&list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY'>Dotnet Maui for Beginners.</a>",
                    "<a target='_blank' href='https://stackoverflow.com/questions/2653096/why-use-mvvm'>Why Use MVVM?</a>"
                },
                ResourcesIntro = "With the Math’s Game project, you learned the basics of MAUI and XAML. Now you’ll need to add a design pattern to that knowledge. For that we will get the help of the most knowledgeable MAUI instructor out there: James Montemagno. Initially, you’ll follow his Beginners MAUI tutorial, where you’ll build a Todo List App with MVVM.",
                Tips = new List<string>
                {
                    "The Books Management app can be almost identical to the Todo List project by James Montemagno, with just a few tweaks.",
                    "Take your time learning MVVM. Understand every line of the code. Google everything you don't know. Write diagrams, make notes and lists."
                },
                Challenges = new List<string>
                {
                    "Add a \"photo\" property to the book detail. It will contain an URL to a picture of the book's cover.",
                    "Expand on the project fetching and using data from a books API.",
                    "Create a search functionality where I can query for titles or dates of books previously read (and whatever other filters you can think of).",
                    "Create a \"Reading now\" functionality where you can track your progress in a book you're currently reading"
                }
            },
             new Project
            {
                Id = 45,
                Title = "Monkeys Data",
                IconUrl = "icons8-see-no-evil-monkey-256.png",
                BannerUrl = "",
                Description = "Build an advanced Mobile UI to present data about Monkeys, using Geolocation to show which monkey is closest to you",
                Area = Area.MAUI,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Learning the MVVM pattern can be quite overwhelming, especially if you’re new to XAML and MAUI, so in this project we will get more MVVM practice while practicing our XAML skills and using native features for mobile apps. We will get help from James Montemagno, the amazing Microsoft Instructor focused on all things XAML. It’s a long tutorial but as always James makes it really easy to follow and enjoy. So let’s not waste any time!"
                    },
                     new Paragraph
                    {
                        Body="In this project you’ll log data about your sleep, either manually inputting your time in bed or using a timer to automatically log it. Dealing with time is always a challenge and great practice. Also, you’ll be using Angular Material, a powerful UI component library ubiquitous in enterprise Angular projects. This is a massive library that does take some time to learn, but once you master it, it becomes extremely easy to build interesting and great-looking UI components. You’ll be saying goodbye to Bootstrap! "
                    }
                },
                Requirements = new List<string>
                {
                    "This project has only one requirement: Follow and complete <a href='https://www.youtube.com/watch?v=DuNLR_NJv8U'>James Montemagno's Monkeys App Tutorial.</a>"
                },
                Challenges = new List<string>
                {
                    "Implement a function to add new Monkeys.",
                    "Create another app based on this tutorial but a different business case and styling."
                }
            },
             new Project
            {
                Id = 46,
                Title = "Warehouse Admin",
                IconUrl = "icons8-warehouse-512.png",
                BannerUrl = "",
                Description = "Track warehouse operations using a complex data model with Maui",
                Area = Area.MAUI,
                ExperiencePoints = 100,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In this project you’ll be using the knowledge from the three previous MAUI projects to create a Warehouse Management System, a common business case in enterprise applications, where it’s critical to maintain accurate data about logistical operations. We will aim to give the user interface a clean “corporate” look and generate various types of reports using a complex data system."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an app that will manage warehouse data about a multi-store retail business of your choice.",
                    "Your data schema will contain the following tables: Products, Stores, Employees, WarehouseSlot, Items, ItemMovements.",
                    "Users need to know where a product is at any given time.",
                    "Products can be in transit from store to warehouse and vice-versa.",
                    "Every time a product is in movement, a new record needs to be added in the \"ItemMovement\" table. Every itemMovement needs to have two employess associated with it. One in the shipping end and one in the receiving end.",
                    "An Item is an instance of a product. Products are unique, but there can be multiple items of the same product.",
                    "A warehouse slot needs to contain at least an \"Isle\" and a \"Slot Number\" columns.",
                    "Users should be able to see a history of item movements."
                },
                Tips = new List<string>
                {
                    "Layer the creation of your project: Start with showing a list products showing how many items are available in the inventory.",
                    "Then add the stores and show how many items are available per store. Start with only two stores to keep things simple.",
                    "Then add the item movements and so on.",
                    "This is a project that require some level of planning, especially in regards to data schema, but don't overdo it, you'll only understand some of the requirements as you start coding"
                },
                Challenges = new List<string>
                {
                    "Add authentication and authorization so that only logged in users are able to use the app",
                    "Add role-base authentication, with super users that are able to add products, stores, items and employees.",
                    "Create a detail page for each entity (i.e. click on an employee will show all its details and history of item movements",
                    "Expand the data schema with Customers and Orders table where you'll track sales(Warning: this adds tremendous complexity)",
                    "Feeling adventurous? Implement your app in a mobile device and use a barcode scanner to make handling of items faster."
                }
            },
        };
    }
}