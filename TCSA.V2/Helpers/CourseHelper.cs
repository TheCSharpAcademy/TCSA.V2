using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public class CourseHelper
{
    public static List<Course> GetCourses()
    {
        return new List<Course>
        {
            new Course
            {
                Id = 1,
                Title = "Introduction to Object Oriented Programming",
                Description = "Learn the most used programming paradigm in web development!",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 500025,
                        CourseDisplayId = 0,
                        Title = "Introduction",
                        Slug = "oop-introduction",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "It's a pleasure to teach you Object Oriented Programming! Not only it's an elegant approach to software development, but it's especially nice in C#. You'll have a great time while learning powerful concepts in the context of a project!" },
                                }
                            },
                            new Block
                            {
                                Title = "Who's this course for?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "This course isn't for absolute beginners in C#. You'll struggle if you don't know basic topics such as basic C# syntax (variables, loops, methods, data types, basic data structures, control flow),  how to navigate Visual Studio or Visual Studio Code and how to create a console apps, to mention a few. If you're an absolute beginner, we recommend you go back to this article and build a solid foundation first." },
                                    new Paragraph {
                                       Body = "This course doesn't cover all topics in OOP. It's an Intro course. We will be releasing an advanced course within the next few weeks. However you will still benefit from this course if you have previous knowledge of OOP but not a lot of practice. If you have extensive professional experience, you might still be able to close some knowledge gaps." }
                                }
                            },
                            new Block
                            {
                                Title = "What We Recommend?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "<b>Study each chapter carefully</b>: Make quick notes with important observations and remaining doubts. Don't rush through things. Make sure you understand what each key word does. Ask follow-up questions from Chat GPT. Use it as an assistant. Its biggest strength is the ability to explain concepts in different ways in a conversational style." },
                                    new Paragraph {
                                       Body = "<b>Make Notes</b>: Using your preferred note-taking system, write down what you took from each chapter. What do you understand better? What topic is still not clear? Reflecting upon what you've learned is one of the best ways to retain knowledge." },
                                    new Paragraph {
                                       Body = "<b>Review the Code</b>: At the end of each practical chapter you'll find a <b>View Code</b> button, where you can see all of the project's code up to that point in the course. If you run into issues, compare your code to ours before asking for help. It could be a typo or somethign you forgot to add." }
                                }
                            },
                            new Block
                            {
                                Title = "Give Feedback",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you find any typos, broken links, misplaced or wrong information or any other issues, let us know! We're only humans and bound to making mistakes. Reach out on our Discord Community, using the #feedback channel. We appreciate your help!" },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500000,
                        CourseDisplayId = 1,
                        Title = "What Is OOP?",
                        Slug = "getting-started-with-csharp",
                        Description = "Learn the fundamentals of C# programming language.",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Welcome to the world of <b>Object-Oriented Programming (OOP)</b> in C#! Your programming life will never be the same. In this chapter, we'll explore what OOP is, why it's important, and how it makes your code more organized, readable, and maintainable. By the end of this course you'll be more confident in your coding skills and more prepared to tackle any software development project." },
                                    new Paragraph { Body = "Imagine you have two workshops. <b>One is clean and tidy</b>, with tools neatly arranged on shelves, labeled drawers for screws and nails, and a well-organized space where you can quickly find what you need. <b>The other is chaotic</b>, with tools scattered across the floor, screws mixed with nails in random boxes, and materials piled up in no particular order." },
                                    new Paragraph { Body = "Which workshop would you prefer to work in? The tidy one allows you to be more productive—you can easily locate your tools, everything has its place, and the space just makes sense. The messy workshop, on the other hand, <b>slows you down</b>. You waste time searching for what you need, and the chaos makes it harder to complete your projects efficiently." },
                                    new Paragraph { IsPicture = true, PictureUrl = "c1-ch1-oop-office.png"},
                                    new Paragraph { Body = "In OOP, you break down a complex problem into smaller, manageable parts. Each part is a \"tool\" that can be reused, improved, or replaced without affecting the entire program. With OOP, your projects become more scalable and easier to debug because you can pinpoint issues more quickly." },
                                    new Paragraph { Body = "In the chapters ahead, you'll learn how to use OOP principles in C# to create well-organized, clean, and efficient code. Just like in the tidy workshop, <b>everything will have its place</b>, making it easier for you to build and maintain your projects." }
                                }
                            },
                            new Block
                            {
                                Title = "If not OOP, Then What?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph 
                                    { 
                                        Body = "Two alternatives to object-oriented programming (OOP) are <b>procedural </b> and <b> functional</b> programming. Functional programming emphasizes the use of <b>pure functions</b> and immutable data, focusing on the what of computation rather than the how. It encourages the use of functions as first-class citizens, allowing them to be passed around as arguments, returned from other functions, and stored in variables. Functional programming is particularly adept at <b>handling complex data transformations</b> and <b>concurrent programming</b>, as its immutable data structures eliminate issues related to shared state and side effects, making programs easier to reason about and test."
                                    },
                                    new Paragraph 
                                    { 
                                        Body = "In contrast, procedural programming <b>organizes code into procedures</b> that manipulate data through a series of step-by-step instructions. This approach typically involves a more imperative style, where the programmer explicitly defines the sequence of operations to be executed. While procedural programming can lead to straightforward implementations, it often struggles with scalability and maintainability in larger applications, as the tight coupling between data and procedures can lead to duplicated code and difficulty managing complexity. Object-oriented programming (OOP) addresses these issues by <b>encapsulating</b> data and behavior within objects. OOP facilitates code that is more intuitive and easier to maintain, as it <b>aligns closely with real-world concepts</b>, making it the most popular choice for many software development projects."
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500001,
                        CourseDisplayId = 2,
                        Title = "About this course",
                        Slug = "getting-started-with-csharp",
                        Description = "About this Cou",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In this course, we will be building a <b>Library Management System</b> to help demonstrate the concepts of Object-Oriented Programming (OOP) in C#. This project will serve as a practical, hands-on way to apply OOP principles and understand how they work in real-world scenarios." },
                                    new Paragraph { Body = "Learning OOP with theory alone can be difficult and abstract. It’s one thing to read about classes, objects, and inheritance, but it's another to actually use them to solve a real-world problem. That’s why building a project like the Library Management System is so important." }
                                }
                            },
                            new Block
                            {
                                Title = "Why Learn With Projects?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Projects provide context. They allow you to see how all the pieces fit together and how the concepts you learn are applied in actual coding tasks. A project:" },
                                    new Paragraph
{
    Body = @"
<ul>
    <li>➡️ <strong>Gives Purpose to Concepts:</strong> Rather than just memorizing definitions, you’ll see how classes, methods, and objects work together to form a functioning system.</li>
    <li>➡️ <strong>Encourages Problem Solving:</strong> When building a project, you’ll encounter challenges that force you to think critically and apply your knowledge.</li>
    <li>➡️ <strong>Develops Real-World Skills:</strong> By the end of the course, you won’t just understand OOP—you’ll have practical experience applying it to a full project.</li>
    <li>➡️ <strong>Boosts Confidence:</strong> Completing a project gives you something tangible to showcase, and it will boost your confidence as you see your progress.</li>
</ul>
"
},

                                    new Paragraph { Body = "The Library Management System will simulate a simplified library where you can manage books, magazines, and newspapers. The system will allow you to add, edit, and delete library items, view details of each item, keep track of different types of items (books, magazines, newspapers) with specific properties for each." }
                                }
                            },
                            new Block
                            {
                                Title = "Outcomes",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Through this project, you'll see how OOP allows us to:" },
                                    new Paragraph
{
    Body = @"
<ul>
    <li>➡️ Create reusable components (like different types of library items).</li>
    <li>➡️ Group related data and behavior into classes.</li>
    <li>➡️ Leverage inheritance to avoid repeating code.</li>
    <li>➡️ Use encapsulation to protect and manage data efficiently.</li>
</ul>
"
},
                                    new Paragraph { Body = "In the next chapters, we'll start small by creating classes for different types of library items and gradually expand the system to introduce more complex functionality. Along the way, you'll be applying OOP concepts such as classes, objects, inheritance, polymorphism, and more." },
                                    new Paragraph { Body = "By the end of this course, not only will you have a strong understanding of OOP, but you'll also have a complete Library Management System that you can continue to build upon." },
                                    new Paragraph { Body = "Let's get started! 🤓" },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500002,
                        CourseDisplayId = 3,
                        Title = "Creating the Course Project",
                        Slug = "oop-course-project",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Before we start learning OOP we need to build the course's project. Let's start by spinning up a Console app. If you've never created a console app before this course isn't for you. <a href='https://thecsharpschool.getlearnworlds.com/subscription/the-c-academy-membership' target='_blank'>We suggest you watch the tutorial in this article first</a>." }
                                }
                            },
                            new Block
                            {
                                Title = "Using the Command Line",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We recommend you create your project via the command line if you haven't tried it. <b>We need to get stronger at using the CLI</b>. Navigate to the directory where you want to create the project, using the cd command. For example:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "cd path/to/your/folder"
                                    },
                                    new Paragraph { Body = "Run the following command to create a new console app:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "dotnet new console -n TCSA.OOP.LibraryManagementSystem"
                                    },
                                    new Paragraph { Body = "Navigate into the new project directory:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "cd TCSA.OOP.LibraryManagementSystem"
                                    },
                                    new Paragraph { Body = "Open your project in Visual Studio by typing the name of the project followed by .csproj" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "TCSA.OOP.LibraryManagementSystem.csproj"
                                    },
                                    new Paragraph { Body = "Now let's install Spectre Console, an amazing library that makes the lives of developers much easier when working with Console apps. With Spectre we can provide a much better user experience without having to write a lot of code. To install it, use the following command in the CLI:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "dotnet add package Spectre.Console"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "First Lines Of Code",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally let's write some code to demonstrate the power of Spectre Console. In Program.cs, delete the Hello World Code and replace it with this snippet: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "var menuChoices = new string[3] { \"View Books\", \"Add Book\", \"Delete Book\" };\r\n\r\nvar choice = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"What do you want to do next?\")\r\n        .AddChoices(menuChoices));"
                                    },
                                    new Paragraph { Body = "Again if the above code is totally foreign to you, this course might not be the best suit for your current level. <a href='https://thecsharpschool.getlearnworlds.com/subscription/the-c-academy-membership' target='_blank'>We suggest you watch the tutorial in this article first</a>." },
                                    new Paragraph { Body = "Let's explain the code:" },
                                    new Paragraph
{
    Body = @"
<ul style='margin-bottom: 10px;'>
    <li style='margin-bottom: 10px;'>➡️ We're creating an <b>array of strings</b> that will serve as the menu choices. For now we'll only have three choices, but we'll expand it later. I'm creating the variable that stores this array using 'var' but it's up to you how you create it.</li>
    <li style='margin-bottom: 10px;'>➡️ Then we're using the <b>Prompt method</b> of the <b>AnsiConsole</b> class, from Spectre.Console namespace, to create the menu. We're prompting a <b>SelectionPrompt</b>. This class has a <b>Title method</b>, to which we're passing our desired menu title, and an <b>AddChoices method</b>, to which we're passing our array of choices. </li>
</ul>
"
},
                                     new Paragraph { Body = "Run the app and you'll see the menu. Use the arrows in your keyboard to select one of the choices. Isn't that cool? this means we will need to write much less validation code, since the menu choices are fixed." },

                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar menuChoices = new string[3] { \"View Books\", \"AddBook\", \"Delete Book\" };\r\n\r\nvar choice = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"What do you want to do next?\")\r\n        .AddChoices(menuChoices));"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500003,
                        CourseDisplayId = 4,
                        Title = "Basic Functionality",
                        Slug = "oop-course-project-functionality",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "I know you're looking forward to learning OOP, but we just have one more step before starting. Let's add some code to let the users view, add, and delete books." }
                                }
                            },
                            new Block
                            {
                                Title = "Global List of Books",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "At the top of the file, just <b>under menuChoices</b>, let's add a list of books. We won't be storing books in a database,  since it's out of the scope of this course:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "var books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Menu Loop",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next we need to make sure the menu runs again after an operation is completed. For this, just put it in a loop. Notice we're also clearing the console with the <b>Clear() method</b> to improve readability:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    Console.Clear();\r\n\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(menuChoices));\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Menu Choices Switch",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now, inside the loop, let's create a switch statement to handle each option. The switch statement will branch the execution of the code based on the <b>choice variable</b>." },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    Console.Clear();\r\n\r\n    // menu code here\r\n\r\n    switch (choice)\r\n    {\r\n        case \"View Books\":\r\n            break;\r\n        case \"Add Book\":        \r\n            break;\r\n        case \"Delete Book\":         \r\n            break;\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Implementing the Options",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally, let's add the code for each case. You can see the explanation about what the code is doing in the comment in the code block:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "case \"View Books\":\r\n    /* Spectre's MarkupLine method is useful for styling strings.\r\n    We'll use it as a standard do print messages to the console.*/\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    // Printing each book to the console with a loop\r\n    foreach (var book in books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n    }\r\n\r\n    /* Having the user press a key before continuing, or the menu\r\n     wouldn't be visualisable */         \r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n\r\n    break;"
                                    },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "case \"Add Book\":\r\n    /* Spectre's Ask<> method allows us to prompt a message to grab \r\n     the user's input. We can pass the type we expect as an answer\r\n    for validation. We're storing the answer in the 'title' variable*/ \r\n    var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n    // checking if the book already exists to avoid duplication.\r\n    if (books.Contains(title))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n    }\r\n    else\r\n    {\r\n        //if book doesn't exist, add to the list of books.\r\n        books.Add(title);\r\n        AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n    break;"
                                    },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "case \"MenuOption.DeleteBook\":\r\n    // checking if there are any books to delete and letting the user know\r\n    if (books.Count == 0)\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n        Console.ReadKey();\r\n        return;\r\n    }\r\n\r\n    /* showing a list of books and letting the user choose with arrows \r\n     using SelectionPrompt, similarly to what we do with the menu */\r\n    var bookToDelete = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"Select a [red]book[/] to delete:\")\r\n        .AddChoices(books));\r\n\r\n    /* Using the Remove method to delete a book. This method returns a boolean\r\n      that we can use to present a message in case of success or failure.*/\r\n    if (books.Remove(bookToDelete))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n    }\r\n    else\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n    break;"
                                    },
                                    new Paragraph
                                    {
                                        Body = "Next run the app. You should be able to view, add and delete books. We're ready to jump into OOP concepts!"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar menuChoices = new string[3] { \"View Books\", \"Add Book\", \"Delete Book\" };\r\nvar books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(menuChoices));\r\n\r\n    switch (choice)\r\n    {\r\n        case \"View Books\":\r\n            AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n            foreach (var book in books)\r\n            {\r\n                AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n\r\n            break;\r\n        case \"Add Book\":\r\n            var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n            if (books.Contains(title))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n            }\r\n            else\r\n            {\r\n                books.Add(title);\r\n                AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n        case \"MenuOption.DeleteBook\":\r\n            if (books.Count == 0)\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n                Console.ReadKey();\r\n                return;\r\n            }\r\n\r\n            var bookToDelete = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;string&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n            if (books.Remove(bookToDelete))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n            }\r\n            else\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500004,
                        CourseDisplayId = 5,
                        Title = "Enumerations",
                        Slug = "object-oriented-enums",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Enums allow you to define a type that can only take one of a predefined set of values. This restricts the possible values a variable can hold, reducing errors. They're particularly suited for situations where we only have a small amount of options. " }
                                }
                            },
                            new Block
                            {
                                Title = "Creating an enum",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In our app, the menu options are a perfect use case for an enum. So let's create our first. At the end of the file, outside of the loop, add this snippet:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "enum MenuOption\r\n{\r\n    Viewbooks,\r\n    AddBook,\r\n    DeleteBook\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Using the Enum",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next modify the code inside your switch statement so it looks like this. I'm supressing the code inside the switch statement cases to help readability: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.ViewBooks:\r\n            // view book code\r\n            break;\r\n        case MenuOption.AddBook:\r\n            // add book code\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            // delete book code\r\n            break;\r\n    }\r\n}"
                                    },
                                    new Paragraph
                                    {
                                        Body = "Our Selection Prompt is now of the \"MenuOption\" type, instead of string. We can extract the values of our Enum using the GetValues<>() method."
                                    },
                                     new Paragraph
                                    {
                                        Body = "We are now using the enumeration values as cases for our switch statement. For this we need to provide the qualified value, meaning the name of the type, and the name of the option (i.e. MenuOption.ViewBooks)"
                                    }
                                },
                            },
                            new Block
                            {
                                Title = "How does this fit in OOP?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ <b>Readability</b>: Using enums makes your code more expressive and easier to understand compared to using literal constants or integers." },
                                    new Paragraph { Body = "➡️ <b>Encapsulation</b>: Enums help encapsulate related constants within a single type, promoting better organization and abstraction in your codebase. We'll learn more about encapsulation later in this course. It's one of the core principles of OOP" },
                                }
                            },
                            new Block
                            {
                                Title = "Less Errors",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Additionally, using enums provide a safeguard against typos. Let's take our ViewBooks enum as an example. As a developer, I'd have to be precise when writing this reference elsewhere in the code. \"View Books\", \"Viewbooks\", \"viewbooks\" are all variations that could cause problems. I'd have to write extra code to prevent these errors. With enums, the compiler will help us with the correct value. In the fast-paced environment of enterprise development, such ease of use can't be neglected!" }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n            foreach (var book in books)\r\n            {\r\n                AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n\r\n            break;\r\n        case MenuOption.AddBook:\r\n            var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n            if (books.Contains(title))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n            }\r\n            else\r\n            {\r\n                books.Add(title);\r\n                AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            if (books.Count == 0)\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n                Console.ReadKey();\r\n                return;\r\n            }\r\n\r\n            var bookToDelete = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;string&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n            if (books.Remove(bookToDelete))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n            }\r\n            else\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n    }\r\n}\r\n\r\nenum MenuOption\r\n{\r\n    Viewbooks,\r\n    AddBook,\r\n    DeleteBook\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500005,
                        CourseDisplayId = 6,
                        Title = "Methods",
                        Slug = "object-oriented-methods",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "So far, all the logic for handling the various menu choices was directly inside the switch statement within the while loop. Let's make the code more aligned to OOP principles by moving it into methods. " },
                                    new Paragraph { Body = "Under the loop, but above the Enum, create the method with the code for Viewing Books: \r\n" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "void ViewBooks()\r\n{\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    foreach (var book in books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}"
                                    },
                                    new Paragraph
                                    {
                                        Body = "The method can be void as it doesn't return data. Its implementation uses the books list, but we don't need to pass it as a parameter, since the scope of the list allows it to be accessed by any method within Program.cs."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Implement the Missing Methods",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Repeat the process with the other two menu options, creating a method for each. Then call the methods from your switch statement cases. The switch should look like this: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            DeleteBook();\r\n            break;\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Encapsulation",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Encapsulation is one of the fundamental principles of OOP. It involves bundling data and methods that operate on that data into a single unit, typically a class. We will learn about classes soon. For now all we need to know is that all of our code is inside the <b>Program class</b>. Hence the Program.cs file. " },
                                    new Paragraph
                                    {
                                        Body = "A helpful analogy is to think of Encapsulation as putting your valuables in a safe. In programming, it means keeping important data and the details of how things work hidden inside a \"box\" (like a class). Only certain parts of the code, in this case, methods, can interact with that data. This protects the data and makes sure it’s only changed or accessed in controlled ways. So, just like only someone with the key can open the safe, only specific parts of your program can access or modify the hidden data."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Further advantages in using methods in the context of OOP",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ It helps us enforce that each part of the code is responsible for only one thing. This way of thinking is the Single Responsibility Principle, one of the most important principles in software programming. It fits neatly within the idea of Separation of Concerns." },
                                    new Paragraph { Body = "➡️ It makes the code reusable. Whenever we need to execute one of those operations we can simple invoke that method, instead of repeating the code. This helps developers abide to the DRY principle." },
                                    new Paragraph { Body = "➡️ It makes the code more testable.  Isolating functionality into methods makes it much easier to write unit tests." }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            DeleteBook();\r\n            break;\r\n    }\r\n}\r\n\r\nvoid ViewBooks()\r\n{\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    foreach (var book in books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}\r\n\r\nvoid AddBook()\r\n{\r\n    var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n    if (books.Contains(title))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n    }\r\n    else\r\n    {\r\n        books.Add(title);\r\n        AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}\r\n\r\nvoid DeleteBook()\r\n{\r\n    if (books.Count == 0)\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n        Console.ReadKey();\r\n        return;\r\n    }\r\n\r\n    var bookToDelete = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"Select a [red]book[/] to delete:\")\r\n        .AddChoices(books));\r\n\r\n    if (books.Remove(bookToDelete))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n    }\r\n    else\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}\r\n\r\nenum MenuOption\r\n{\r\n    Viewbooks,\r\n    AddBook,\r\n    DeleteBook\r\n}"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500006,
                        CourseDisplayId = 7,
                        Title = "Classes",
                        Slug = "object-oriented-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, a class is a blueprint for creating objects. It defines a type by encapsulating data (fields) and behavior (methods) that an object will have. A class serves as a template from which you can instantiate objects, and each object created from the class is called an instance." },
                                    new Paragraph { Body = "Let's create our first. In Visual Studio's solution explorer, right click \"TCSA.OOP.LibraryManagement\", and choose Add, then Class. Name it BookController. Click the code cleanup icon and add a semi-colon to the namespace so your class looks like this: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n}"
                                    },
                                    new Paragraph
                                    {
                                        Body = "Notice that in the signature, this class has the \"internal\" keyword. This is an access modifier. We'll have a deeper look at these later. For now it will suffice to know that an internal class can be accessed by other parts of the same project."
                                    },
                                    new Paragraph
                                    {
                                        Body = "To better demonstrate OOP, let's start by adding the static keyword to it's signature. By marking a class as static, we're saying that we cannot create instances of it. Be patient, we will explain all of this soon."
                                    },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class BooksController\r\n{\r\n}"
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "Using the New Class",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now move all methods from Program.cs intro the BooksController. This class will be responsible for handling books. Mark all of them as internal and static as well. " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "internal static class BooksController\r\n{\r\n    internal static void ViewBooks()\r\n    {\r\n        // implementation\r\n    }\r\n\r\n    internal static void AddBook()\r\n    {\r\n        // implementation\r\n    }\r\n\r\n    internal static void DeleteBook()\r\n    {\r\n        // implementation\r\n    }\r\n\r\n}"
                                    },
                                     new Paragraph { Body = "You've probably noticed that the compiler is showing an error. The list of books can't be found. Let's also move that variable into this class. Put them just above the methods. Mark it as private (it can only be accessed from within the class) and static:\r\n" },
                                     new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "internal static class BooksController\r\n{\r\n  private static List&lt;string&gt; books = new()\r\n    {\r\n    // list items\r\n    };\r\n\r\n   // methods here\r\n\r\n}"
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "Adjust Program.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally, we need to address one more issue. Back in Program.cs, the methods can't be found, since they moved to another class. Let's call those methods by qualifying them with the name of the class they belong to. Your loop should now look like this:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem;\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            BooksController.ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            BooksController.AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            BooksController.DeleteBook();\r\n            break;\r\n    }\r\n}"
                                    },
                                    new Paragraph { Body = "Notice we have 'using TCSA.OOP.LibraryManagementSystem;' on top of the file. We need that to tell the compiler where BooksController is coming from." },
                                    new Paragraph { Body = "Now our program still does the same thing but the code is slightly more organized. We have a dedicated class to handle books. And Program.cs is calling the methods in that class." },
                                    new Paragraph { Body = "We still have several questions to answer: What does static do? How about the access-modifiers? And how come we don't see the declaration of the Program class? The code in program.cs is running without any methods? We'll tackle these in the next chapters." },
                                },
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem;\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            BooksController.ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            BooksController.AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            BooksController.DeleteBook();\r\n            break;\r\n    }\r\n}\r\n\r\nenum MenuOption\r\n{\r\n    Viewbooks,\r\n    AddBook,\r\n    DeleteBook\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class BooksController\r\n{\r\n    private static List&lt;string&gt; books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n\r\n    internal static void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n        if (books.Contains(title))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            books.Add(title);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void DeleteBook()\r\n    {\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"Select a [red]book[/] to delete:\")\r\n            .AddChoices(books));\r\n\r\n        if (books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500007,
                        CourseDisplayId = 8,
                        Title = "Top-level Statements",
                        Slug = "c-sharp-top-level-statements",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Top-level statements in C# are a feature introduced in C# 9 that allow you to write a simpler, more concise version of your program, eliminating the need to explicitly define the Main method and the containing Program class. This feature is particularly useful for small applications, scripts, and beginner-friendly code samples where the ceremony of defining the Main method is unnecessary." },
                                    new Paragraph { Body = "When you use top-level statements, C# automatically generates the Main method for you under the hood. The compiler treats the code in the file as if it were inside a Main method. So, your code behaves just like it would in a traditional C# program, but you don't see the Main method because it's implied. " },
                                    new Paragraph { Body = "Let's see what our current code would look like without top-level statements:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    BooksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    BooksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    BooksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Behind the Scenes",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We have to remember that the job of the compiler is to translate the code that developers write into Intermediate Language (IL), before it's ultimately executed by the .NET runtime." },
                                    new Paragraph { Body = "Intermediate Language can be quite confusing and we don't want to mess with it right now, but it's worth taking a look at what IL looks like when the code above is translated:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "// IL pseudo-representation\r\n.class public auto ansi beforefieldinit Program\r\n       extends [System.Runtime]System.Object\r\n{\r\n    .method public hidebysig static \r\n        void Main(string[] args) cil managed \r\n    {\r\n        // IL code corresponding to your explicitly defined Main method\r\n    }\r\n}"
                                    },
                                     new Paragraph { Body = "This is exactly the same code generated by top-level statements. The only difference is what the developers see. With top level statements, the Main method and Program.cs declaration are happening under-the-hood. In computer programming a common nick-name for this is \"syntactic sugar\"." },
                                     new Paragraph
                                    {
                                        Body = "So even before designing your first class and methods you were working inside a class and a method all along! "
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500008,
                        CourseDisplayId = 9,
                        Title = "Access Modifiers",
                        Slug = "object-oriented-access-modifiers",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Access modifiers control the visibility and accessibility of class members. In C#, access modifiers help enforce encapsulation, one of the core principles of OOP." },
                                    new Paragraph { Body = "They are keywords that specify the declared accessibility of types and type members. They determine whether other parts of the code can access a particular class, method, property, or field. By controlling access, developers can protect the internal state of objects, exposing only necessary components. C# provides several access modifiers, each offering a different level of accessibility. " }
                                }
                            },
                            new Block
                            {
                                Title = "C# Acess Modifiers",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ <b>Public</b>: It's the most accessible modifier, allowing members to be accessed from any part of the code in the same assembly or from other assemblies. It ensures that the member is available to all." },
                                   new Paragraph { Body = "➡️ <b>Private</b>: It's the most restrictive modifier, limiting access to the containing class only. Members marked as private cannot be accessed from outside the class, ensuring full encapsulation of the class's implementation details." },
                                    new Paragraph { Body = "➡️ <b>Protected</b>: Allows access within the containing class and any class that inherits from it. This modifier is useful when you want derived classes to access certain members but still restrict access from the outside." },
                                   new Paragraph { Body = "➡️ <b>Internal</b>: Limits access to the current assembly, meaning that any type or member marked as internal can only be accessed by other types within the same project but not by other assemblies." },
                                    new Paragraph { Body = "➡️ <b>Protected Internal</b>: It's a combination of protected and internal, allowing access either from within the same assembly or from a derived class in another assembly. It offers flexibility when sharing access across inheritance hierarchies and assemblies." },
                                   new Paragraph { Body = "➡️ <b>Private protected</b>: It's the most restrictive of all inheritance-access modifiers, allowing access only from within the containing class or types derived from the class but only within the same assembly. This ensures that members are not exposed to derived classes from other assemblies." },
                                },
                            },
                            new Block
                            {
                                Title = "Best Practices",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ <b>Default to the Least Permissive Access</b>: Start with the most restrictive access level (private) and only increase accessibility when necessary. This minimizes unintended interactions and enhances security." },
                                   new Paragraph { Body = "➡️ <b>Use private for Implementation Details</b>: Keep fields and helper methods private unless there’s a clear need for broader access." },
                                    new Paragraph { Body = "➡️ <b>Expose Only Necessary Members</b>: Public members should represent the intended interface of the class. Avoid exposing internal workings unless required for extension or interaction." },
                                   new Paragraph { Body = "➡️ <b>Leverage internal for Assembly-Wide Access</b>: Use internal when members need to be accessible across multiple classes within the same assembly but should remain hidden from external assemblies." },
                                    new Paragraph { Body = "➡️ <b>Document Access Levels</b>: Clearly document the intended use and access levels of class members to aid maintainability and clarity for other developers." }
                                },
                            },
                            new Block
                            {
                                Title = "Default Access Modifier",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you don't explicitly declare an access modifier in C#, the default is private for members (fields, methods, properties) inside a class. This means that these members will only be accessible from within the same class or struct. For top-level types (such as classes, interfaces, or structs), the default access modifier is internal, making the type accessible only within the same assembly." }
                                },
                            },
                            new Block
                            {
                                Title = "Compiler Help",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "While we learn about access modifiers, we can count on the compiler's help. It will notify you with an error if you try to use an access modifier in a context where it is not allowed. For example, you cannot apply the private or protected modifier to a class. You also can't invoke a private method from outside of its class. In this case the compiler provides clear error messages to guide you." }
                                },
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500009,
                        CourseDisplayId = 10,
                        Title = "Creating More Classes",
                        Slug = "object-oriented-more-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now that we have a better understand of access modifiers and of what's happening in Program.cs, let's create a few more classes. Start by creating UserInterface.cs, with a method where the main menu will live: \r\n" },
                                    new Paragraph { 
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static STUDY.OOP.LibraryManagement.Enums;\r\n\r\nnamespace STUDY.OOP.LibraryManagement;\r\n\r\ninternal class UserInterface\r\n{\r\n    internal static void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            //menu code here:\r\n        }\r\n    }\r\n}" },
                                     new Paragraph { Body = "Notice that this time the class isn't static, but the method is. This is just to illustrate that it's possible to have static methods inside non-static classes." },
                                }
                            },
                            new Block
                            {
                                Title = "Enums Class",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's proceed by creating an Enums.cs class. It'll contain any enum we need to create for out app. " },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "internal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}" },
                                   new Paragraph { Body = "Here we don't have to worry about the static keyword. Enums are types that allow you to directly access their members without instantiation. This is because enum members are <b>implicitly static</b> in nature, even if the enum itself is not static." },
                                    new Paragraph { Body = "You're probably asking yourself why we're using the word static a lot, without going deeper into it. There's a reason for that. We will clarify everything in the next couple of chapters." }
                                },
                            },
                            new Block
                            {
                                Title = "Starting Point",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The final step is to remove all code from Program.cs. From now on, it will serve as the starting point for our app:" },
                                   new Paragraph {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface.MainMenu();" },
                                   new Paragraph { Body = "These modifications improved the readability of our code. It's now neatly separated in four classes, following the Separation of Concerns simple." }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface.MainMenu();"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class BooksController\r\n{\r\n    private static List&lt;string&gt; books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n\r\n    internal static void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n        if (books.Contains(title))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            books.Add(title);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void DeleteBook()\r\n    {\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"Select a [red]book[/] to delete:\")\r\n            .AddChoices(books));\r\n\r\n        if (books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    internal static void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    BooksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    BooksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    BooksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500010,
                        CourseDisplayId = 11,
                        Title = "Objects",
                        Slug = "object-oriented-objects",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The Object Oriented paradigm lies on the creation of objects. Classes are blueprints for the creation of objects. Let's use Program.cs as a sandbox for better understanding what it means. Replace the code we currently have with this: " },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "class Car()\r\n{\r\n    internal string name;\r\n\r\n    internal void PrintName()\r\n    {\r\n        Console.WriteLine($\"I'm a {name}\");\r\n    }\r\n}" },
                                }
                            },
                            new Block
                            {
                                Title = "Members",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Proceed by adding a few lines of code above this class declaration. Program.cs now should look like this:" },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "﻿using STUDY.OOP.LibraryManagement;\r\n\r\n// UserInterface.MainMenu();\r\n\r\nCar car1 = new Car();\r\nCar car2 = new Car();\r\n\r\ncar1.name = \"Ferrari\";\r\ncar2.name = \"BMW\";\r\n\r\ncar1.PrintName();\r\ncar2.PrintName();\r\n\r\nclass Car()\r\n{\r\n    internal string name;\r\n\r\n    internal void PrintName()\r\n    {\r\n        Console.WriteLine($\"I'm a {name}\");\r\n    }\r\n}" },
                                    new Paragraph {
                                        Body = "Here's what's happening: We're using the new keyword to create objects (instances )of the car class. We're assigning names to both instances. We're invoking the PrintName method for both instances." },
                                   new Paragraph { Body = "If you run the app you'll see both names printed. This means the same blue print was used to create two different objects." }
                                },
                            },
                            new Block
                            {
                                Title = "Objects are Powerful",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "To illustrate the power of this concept, let's suppose we have a gigantic application where thousands of instances of Car get created across millions of lines of code. If we decide that every time we print a car's name it has to be upper case, we need to add one line of code to the method and all instances will be modified." },
                                   new Paragraph {
                                        IsCode = true,
                                        Body = "internal void PrintName()\r\n{\r\n    name = name.ToUpper();\r\n    Console.WriteLine($\"I'm a {name}\");\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using STUDY.OOP.LibraryManagement;\r\n\r\n// UserInterface.MainMenu();\r\n\r\nCar car1 = new Car();\r\nCar car2 = new Car();\r\n\r\ncar1.name = \"Ferrari\";\r\ncar2.name = \"BMW\";\r\n\r\ncar1.PrintName();\r\ncar2.PrintName();\r\n\r\nclass Car()\r\n{\r\n    internal string name;\r\n\r\n    internal void PrintName()\r\n    {\r\n        Console.WriteLine($\"I'm a {name}\");\r\n    }\r\n}"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500011,
                        CourseDisplayId = 12,
                        Title = "Static",
                        Slug = "object-oriented-static",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "So we talked about how objects are instances of classes. It's time to understand what static does." },
                                    new Paragraph {
                                        Body = "The main idea to keep in mind is that a class or a member of a class marked as static cannot be instantiated. Whenever we create a new object, it gets used and disposed of in memory after it does its job. That's not the same with static. Anything marked with static will live for the entire lifecycle of the app." },
                                }
                            },
                            new Block
                            {
                                Title = "Why not just make everything static?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "It's a valid question. It's definitely a possible approach, albeit a bad one. By making everything static our application essentially becomes procedural. If every method or class lives for the entire lifetime of the app, we are giving up on leveraging OOP for organization and maintainability." },
                                     new Paragraph {
                                        Body = "The biggest danger with static is that it creates <b>Global State</b>: data that can be accessed from anywhere within the code. As your application grows, this increases the chances of unexpected behaviors. One part of the app might be using that data without knowing how another area is using that same data. Static can be a threat to data integrity." }
                                }
                            },
                            new Block
                            {
                                Title = "So why use it at all?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Despite the danger, static has a place. Sometimes it doesn't make sense to create instances of a class. A good example can be found in the .NET class library itself, with a class we use all the time: " },
                                   new Paragraph {
                                        Body = "In BooksController.Viewbooks, right click on Console (at the bottom of the method and choose View Implementation). You'll see several fields and methods, including Clear, WriteLine an Readline, just to mention some of the most common:" },
                                     new Paragraph {
                                        Body = "In our app, it doesn't make sense to create a new List of books every time, we need the books to persist across time, so we can make it static. " },
                                     new Paragraph {
                                        Body = "It's not always obvious when to use the static keyword, but hopefully you're now better equipped to make those decisions! From here, the best way to find out will be in the real world, with practice. " },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500012,
                        CourseDisplayId = 13,
                        Title = "Practicing With Objects",
                        Slug = "object-oriented-practice",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now that we know about objects and the static classes, let's use these concepts in our app. Start by removing all instances of the static keyword from our code. In visual studio you can do a search with Ctrl + Shift + H and choosing Find In Files > Entire Solution." }
                                }
                            },
                            new Block
                            {
                                Title = "Mock Database",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next let's create a static MockDatabase class. Since we need our list of books to persist, we'll make it a global variable, available to be used anywhere at anytime. This class will contain a static List&lt;string&gt; field." },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;string&gt; Books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Books Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next, in the BooksController class we need to adjust the code so it uses the Books field in the Mockdatabase class. Here's how it's done in the ViewBooks method. Adjust the remaining accordingly:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = " internal void ViewBooks()\r\n {\r\n     AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n     foreach (var book in MockDatabase.Books)\r\n     {\r\n         AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n     }\r\n\r\n     AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n     Console.ReadKey();\r\n }" }
                                }
                            },
                             new Block
                            {
                                Title = "User Interface",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We can no longer directly access members of BooksController since it's not static. We now need to create an instance of it. In the UserInterface class, create a booksController field, just above the main menu:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        //menu code\r\n    } \r\n}" },
                                    new Paragraph { Body = "Then adjust the code in the switch statement so it uses the newly created field." },
                                }
                            },
                             new Block
                            {
                                Title = "Program.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally, in Program.cs, create an instance of the UserInterface class and call MainMenu() method. This code will kick-start the application." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n" },
                                   new Paragraph { Body = "After creating the basic functionality of the app, we spent several chapters merely refactoring our app applying new concepts. Although the program still does the exact same thing, our code is much more organized and maintainable following OOP principles!" },
                                }
                            },
                             new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in MockDatabase.Books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n        if (MockDatabase.Books.Contains(title))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            MockDatabase.Books.Add(title);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        if (MockDatabase.Books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"Select a [red]book[/] to delete:\")\r\n            .AddChoices(MockDatabase.Books));\r\n\r\n        if (MockDatabase.Books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;string&gt; Books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n}"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500013,
                        CourseDisplayId = 14,
                        Title = "Tuples",
                        Slug = "object-oriented-tuples",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, **tuples** are lightweight data structures that allow you to store a sequence of elements of different types. They are particularly useful for returning multiple values from a method without having to define a separate class or struct. Introduced in C# 7.0, tuples have evolved to become more powerful and user-friendly, especially with the introduction of <b>value tuples</b>." }
                                }
                            },
                            new Block
                            {
                                Title = "Creating a Tuple",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In Program.cs, comment out the current code and run the app with this snippet:" },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "(string, int) book1 = (\"Frankenstein\", 350);\r\nConsole.WriteLine($\"Title: {book1.Item1}, Pages: {book1.Item2}\");" },
                                      new Paragraph { Body = "In the first line, a tuple is created to represent a book with two pieces of information: the title and the number of pages. Here, (string, int) defines the types of the tuple elements. The variable book1 is assigned the tuple (\"Frankenstein\", 350), grouping these two related values into a single data structure. This approach allows you to handle multiple related values without creating a separate class." },
                                      new Paragraph { Body = "The second line demonstrates how to access and display the elements of the tuple. book1.Item1 retrieves the first element of the tuple, and book1.Item2 retrieves the second." },
                                }
                            },
                            new Block
                            {
                                Title = "Named Tuples",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's enhance the original code by using named tuples, which provide more clarity and improve code readability by assigning meaningful names to each element of the tuple." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "(string Title, int Pages) book1 = (\"Frankenstein\", 350);\r\n\r\nConsole.WriteLine($\"Title: {book1.Title}, Pages: {book1.Pages}\");" }
                                }
                            },
                             new Block
                            {
                                Title = "The Downside",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We could go on and refactor our app to use tuples as representation of the books. However, it's likely a book will have many more properties. All of the sudden we could be faced with a monstrosity such as:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "(string Title, int Pages, string Author, string ISBN, string Publisher, int PublicationYear, string Genre, double Rating, bool IsAvailable, decimal Price) book1 = (\"Frankenstein\", 350, \"Mary Shelley\", \"123-4567890123\", \"Penguin Classics\", 1818, \"Gothic\", 4.5, true, 19.99m);" },
                                   new Paragraph { Body = "Not very readable at all. Tuples are much stronger when used more transiently, such as when returning a couple of values from methods where it doesn't really make sense to create a custom type. In the next few chapters we will learn a better approach." },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500014,
                        CourseDisplayId = 15,
                        Title = "Constructors",
                        Slug = "object-oriented-constructors",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Constructors are a key feature of OOP. They are special methods that run when an object is instantiated and ensure we can create objects setting their initial state." }
                                }
                            },
                            new Block
                            {
                                Title = "Book.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In a new file, create a class called Book.cs:" },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Book\r\n{\r\n    string Name;\r\n    int Pages;\r\n\r\n    internal Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                      new Paragraph { Body = "This class has a couple of fields and a special method that doesn't have a return type in its signature. This type of method is called a Constructor. In this case our constructor has a signature with two parameters. In its code block we're assigning the fields to the these parameters and printing them to the console" }
                                }
                            },
                            new Block
                            {
                                Title = "Calling Constructors",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In Program.cs, replace the current code with this snipper and run the app:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nvar book1 = new Book(\"Hamlet\", 200);\r\nvar book2 = new Book(\"Great Gatsby\", 300);" },
                                   new Paragraph { Body = "If you put a breakpoint in the constructor, you'll see that, just as any other method, it executes its code block. The difference is that it will run at the moment of initialization of that object." },
                                }
                            },
                             new Block
                            {
                                Title = "Default Constructor",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If we don't explicitly declare a constructor, the compiler will create one behind the scenes. However if we declare a constructor with parameters and we still want to allow our class to be instantiated without arguments, we need to declare it explicitly." },
                                    new Paragraph { Body = "Right now if we try to initiate a class without arguments we get a compiler error. Try it yourself and see what happens:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nvar book1 = new Book(); //compiler error" },
                                }
                            },
                             new Block
                            {
                                Title = "Parameterless Constructor",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "So let's modify Book.cs, adding a parameterless constructor:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    string Name;\r\n    int Pages;\r\n\r\n    internal Book()\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = 0;\r\n    }\r\n\r\n    internal Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                   new Paragraph { Body = "Now we can create Books without passing arguments." },
                                }
                            },
                             new Block
                            {
                                Title = "Constructor Overload",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We can go a step further and allow Books to be created without a title. This technique is called constructor overload. We can create as many constructors as we need, provided they have different signatures." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    string Name;\r\n    int Pages;\r\n\r\n    internal Book()\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = 0;\r\n      Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n\r\n    internal Book(int pages)\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n\r\n    internal Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                   new Paragraph { Body = "Now we can create Books without passing arguments." },
                                }
                            },
                             new Block
                            {
                                Title = "Skipping Constructors",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We could initialize fields this way:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    string Name = \"Unknown\"\r\n    int Pages = 0;\r\n\r\n    internal Book(int pages)\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                   new Paragraph { Body = "This code would run before any constructors, which means that the assigned values would become default for these fields. However these values can be overridden by the constructors." },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500015,
                        CourseDisplayId = 16,
                        Title = "Properties",
                        Slug = "object-oriented-properties",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, properties are a way to expose class fields in a controlled manner. They allow you to define how the fields of a class can be accessed and modified from outside the class. By using properties, you can implement encapsulation, which is one of the key principles of object-oriented programming. This means you can restrict direct access to the class fields and provide methods for reading and writing their values." }
                                }
                            },
                            new Block
                            {
                                Title = "Getters and Setters",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Getters and setters are methods associated with properties. A getter is a method that retrieves the value of a property, while a setter is a method that sets or updates the value of a property. This allows you to add logic during the retrieval or assignment of values, such as validation or logging, without exposing the underlying field directly." },
                                     new Paragraph {
                                        Body = "In the early versions of C#, specifically C# 1.0 released in 2002, properties were implemented using traditional methods. For example, you would have private fields to store the values, and you would define separate methods to get and set those values. In a class like Book, you might see something like this:" },
                                      new Paragraph { 
                                          IsCode = true,
                                          Body = "internal class Book\r\n{\r\n    private string name;\r\n    private int pages;\r\n\r\n    public string GetName()\r\n    {\r\n        return name;\r\n    }\r\n\r\n    public void SetName(string value)\r\n    {\r\n        name = value;\r\n    }\r\n\r\n    public int GetPages()\r\n    {\r\n        return pages;\r\n    }\r\n\r\n    public void SetPages(int value)\r\n    {\r\n        pages = value;\r\n    }\r\n}\r\n" }
                                }
                            },
                            new Block
                            {
                                Title = "Property Syntax",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Starting with C# 2.0, properties became much easier to use with the introduction of the property syntax. Instead of creating separate getter and setter methods, you could define properties directly within the class. For the Book class, it would look like this:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    public string Name { get; set; }\r\n    public int Pages { get; set; }\r\n}" }
                                }
                            },
                             new Block
                            {
                                Title = "Auto-properties",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The evolution continued with the introduction of auto-properties in C# 6.0. With auto-properties, you could initialize properties directly in the declaration without needing to define a backing field at all. Here's how the Book class would look using auto-properties:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    public string Name { get; set; } = \"Default Name\";\r\n    public int Pages { get; set; } = 100;\r\n}\r\n" },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500016,
                        CourseDisplayId = 17,
                        Title = "Models",
                        Slug = "object-oriented-models",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The Book class we've created in the previous chapter is commonly called a model. A class designed modeling a real-world object. With this we can introduce another OOP principle:" }
                                }
                            },
                            new Block
                            {
                                Title = "Abstraction",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Abstraction in OOP refers to creating a simplified model that represents only the essential features of an object while ignoring irrelevant details. It allows you to focus on what an object is and does at a high level, without worrying about the inner workings. For instance, when you model a Book in your class, you're focusing on attributes like Name and Pages, which are relevant for your application, while ignoring more intricate details like how the book is printed or how the paper is made. In this sense, abstraction helps you create a manageable, conceptual model of a real-world entity." },
                                     new Paragraph {
                                        Body = "This concept is closely related to the Encapsulation principle we've learned previously. To recap: Encapsulation, on the other hand, focuses on bundling the data (attributes) and methods that operate on that data within a single unit (the class) and restricting access to some of that data." }
                                }
                            },
                            new Block
                            {
                                Title = "Applying Model",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's apply our newly created model to our Library system. If you haven't yet, modify Book.cs so it uses auto-properties" },
                                   new Paragraph {
                                       IsCode = true,
                                       Body = "internal class Book\r\n{\r\n    public string Name { get; set; } = \"Unknown\";\r\n    public int Pages { get; set; } = 0;\r\n\r\n    public Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n    }\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "List of Books",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now let's apply it to our MockDatabase class, where we'll now have a list of the Book type instead of string." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = " internal static class MockDatabase\r\n    {\r\n        internal static List&lt;Book&gt; Books = new()\r\n        {\r\n            new Book(\"The Great Gatsby\", 180),\r\n            new Book(\"To Kill a Mockingbird\", 281),\r\n            new Book(\"1984\", 328),\r\n            new Book(\"Pride and Prejudice\", 432),\r\n            new Book(\"The Catcher in the Rye\", 277),\r\n            new Book(\"The Hobbit\", 310),\r\n            new Book(\"Moby-Dick\", 585),\r\n            new Book(\"War and Peace\", 1225),\r\n            new Book(\"The Odyssey\", 400),\r\n            new Book(\"The Lord of the Rings\", 1178),\r\n            new Book(\"Jane Eyre\", 500),\r\n            new Book(\"Animal Farm\", 112),\r\n            new Book(\"Brave New World\", 268),\r\n            new Book(\"The Chronicles of Narnia\", 768),\r\n            new Book(\"The Diary of a Young Girl\", 283),\r\n            new Book(\"The Alchemist\", 208),\r\n            new Book(\"Wuthering Heights\", 400),\r\n            new Book(\"Fahrenheit 451\", 158),\r\n            new Book(\"Catch-22\", 453),\r\n            new Book(\"The Hitchhiker's Guide to the Galaxy\", 224)\r\n        };\r\n    }" },
                                }
                            },
                            new Block
                            {
                                Title = "The Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "These modifications require several changes in BooksController: Modify ViewBooks(), so it uses the model's properties." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = " internal void ViewBooks()\r\n{\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    foreach (var book in MockDatabase.Books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book.Name}[/] - [yellow]{book.Pages} pages[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}" },
                                   new Paragraph { Body = "Modify Add book so that we ask for the pages input and add an instance of Book to the list:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal void AddBook()\r\n{\r\n    var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n    var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n    if (MockDatabase.Books.Exists(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n    }\r\n    else\r\n    {\r\n        var newBook = new Book(title, pages);\r\n        MockDatabase.Books.Add(newBook);\r\n        AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}" },
                                    new Paragraph { Body = "Finally modify the bookToDelete variable in DeleteBook():" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "var bookToDelete = AnsiConsole.Prompt(\r\n    new SelectionPrompt&lt;Book&gt;()\r\n        .Title(\"Select a [red]book[/] to delete:\")\r\n        .AddChoices(MockDatabase.Books));" },
                                    new Paragraph { Body = "Run the app and try to add a new book!" },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in MockDatabase.Books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book.Name}[/] - [yellow]{book.Pages} pages[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.Books.Exists(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(title, pages);\r\n            MockDatabase.Books.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        if (MockDatabase.Books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(MockDatabase.Books));\r\n\r\n        if (MockDatabase.Books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;Book&gt; Books = new()\r\n        {\r\n            new Book(\"The Great Gatsby\", 180),\r\n            new Book(\"To Kill a Mockingbird\", 281),\r\n            new Book(\"1984\", 328),\r\n            new Book(\"Pride and Prejudice\", 432),\r\n            new Book(\"The Catcher in the Rye\", 277),\r\n            new Book(\"The Hobbit\", 310),\r\n            new Book(\"Moby-Dick\", 585),\r\n            new Book(\"War and Peace\", 1225),\r\n            new Book(\"The Odyssey\", 400),\r\n            new Book(\"The Lord of the Rings\", 1178),\r\n            new Book(\"Jane Eyre\", 500),\r\n            new Book(\"Animal Farm\", 112),\r\n            new Book(\"Brave New World\", 268),\r\n            new Book(\"The Chronicles of Narnia\", 768),\r\n            new Book(\"The Diary of a Young Girl\", 283),\r\n            new Book(\"The Alchemist\", 208),\r\n            new Book(\"Wuthering Heights\", 400),\r\n            new Book(\"Fahrenheit 451\", 158),\r\n            new Book(\"Catch-22\", 453),\r\n            new Book(\"The Hitchhiker's Guide to the Galaxy\", 224)\r\n        };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Book\r\n{\r\n    public string Name { get; set; } = \"Unknown\";\r\n    public int Pages { get; set; } = 0;\r\n\r\n    public Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500017,
                        CourseDisplayId = 18,
                        Title = "Abstract Classes",
                        Slug = "object-oriented-abstract-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In Program.cs, write the following code:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal abstract class Animal\r\n    {\r\n        public string Name { get; set; }\r\n        public int Age { get; set; }\r\n\r\n        protected Animal(string name, int age)\r\n        {\r\n            Name = name;\r\n            Age = age;\r\n        }\r\n\r\n        // Abstract method that must be implemented by derived classes\r\n        public abstract void MakeSound();\r\n    }" }
                                }
                            },
                            new Block
                            {
                                Title = "Abstract Classes",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "This class has two things we haven't seen before. The abstract keyword, and a method without a code block." },
                                     new Paragraph {
                                        Body = "The class Animal is declared as abstract, which means it cannot be instantiated directly. Instead, it serves as a blueprint for other classes that will inherit from it." },
                                     new Paragraph {
                                        Body = "An abstract class can contain both abstract methods (without implementation) and concrete methods (with implementation)." }
                                }
                            },
                            new Block
                            {
                                Title = "Inheritance",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Inheritance in object-oriented programming (OOP) allows one class to inherit the properties and methods of another class, facilitating code reusability and establishing a hierarchical relationship. Let's see it in practice. Add this to Program.cs:" },
                                   new Paragraph {
                                       IsCode = true,
                                       Body = "internal class Dog : Animal\r\n    {\r\n        public Dog(string name, int age) \r\n            : base(name, age) \r\n        {\r\n        }\r\n\r\n        public override void MakeSound()\r\n        {\r\n            Console.WriteLine($\"{Name} says: Woof!\");\r\n        }\r\n    }\r\n\r\ninternal class Cat : Animal\r\n    {\r\n        public Cat(string name, int age) \r\n            : base(name, age) // Calling the base class constructor\r\n        {\r\n        }\r\n\r\n        public override void MakeSound()\r\n        {\r\n            Console.WriteLine($\"{Name} says: Meow!\");\r\n        }\r\n    }" },
                                    new Paragraph { Body = "Both the classes inherit from Animal, Implements the MakeSound() method to provide the specific sound the animal makes. The constructor calls the base constructor to initialize Name and Age." },
                                       new Paragraph { Body = "Add this to Program.cs, above the declaration of the classes:" },
                                       new Paragraph {
                                       IsCode = true,
                                        Body = "Animal myDog = new Dog(\"Buddy\", 3);\r\n        Animal myCat = new Cat(\"Whiskers\", 2);\r\n\r\n        myDog.MakeSound(); // Output: Buddy says: Woof!\r\n        myCat.MakeSound(); // Output: Whiskers says: Meow!" }
                                }
                            },
                            new Block
                            {
                                Title = "Polymorphism",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Polymorphism is a fundamental concept in object-oriented programming (OOP) that allows objects of different classes to be treated as objects of a common superclass. The term “polymorphism” literally means “many shapes,” and it refers to the ability of different objects to respond to the same method call in different ways." },
                                    new Paragraph { Body = "In our example, we have different forms of animals, the cat and the dog. They share common characteristics but also contain unique properties. In the next chapter lets's apply this concept to our Library Management System." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500018,
                        CourseDisplayId = 19,
                        Title = "Applying Abstract Classes",
                        Slug = "applying-abstract-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Our library app will need to support not only books but also magazines and newspapers. Since these entities will have common as well as unique characteristics, it's a perfect use case for inheritance. Let's start by creating a folder called Models containing a LibraryItem.cs abstract class:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n" },
                                    new Paragraph { Body = "This class will serve as a base for all items in our library. It makes sense to think that all items will have an id, a name and a location in the library, regardless of its type. We should also be able to display details of any item." },
                                }
                            },
                            new Block
                            {
                                Title = "Modifying Book.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now move Book.cs to the Models folder, and modify it so it inherits from LibraryItem:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal class Book : LibraryItem\r\n{\r\n    internal string Author { get; set; }\r\n    internal string Category { get; set; }\r\n    internal int Pages { get; set; }\r\n\r\n    internal Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    internal override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}" },
                                     new Paragraph {
                                        Body = "Here we have three fields that are unique to Book: Author, Category and Pages. The constructor tells us we need to initiate these three, plus the properties of the base class. This class also implements it own DisplayDetails() using the override keyword." }
                                }
                            },
                            new Block
                            {
                                Title = "Magazine and Newspaper",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the Models folder, let's create a Magazine.cs and a NewsPaper.cs files and repeat the process:" },
                                   new Paragraph {
                                       IsCode = true,
                                       Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}" },
                                       new Paragraph {
                                       IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n" },
                                       new Paragraph { Body = "Study the classes carefully. They are very similar to Book, but contain properties specific to them, along with their own implementation of DisplayDetails()." },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in MockDatabase.Books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book.Name}[/] - [yellow]{book.Pages} pages[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.Books.Exists(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(title, pages);\r\n            MockDatabase.Books.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        if (MockDatabase.Books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(MockDatabase.Books));\r\n\r\n        if (MockDatabase.Books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;Book&gt; Books = new()\r\n        {\r\n            new Book(\"The Great Gatsby\", 180),\r\n            new Book(\"To Kill a Mockingbird\", 281),\r\n            new Book(\"1984\", 328),\r\n            new Book(\"Pride and Prejudice\", 432),\r\n            new Book(\"The Catcher in the Rye\", 277),\r\n            new Book(\"The Hobbit\", 310),\r\n            new Book(\"Moby-Dick\", 585),\r\n            new Book(\"War and Peace\", 1225),\r\n            new Book(\"The Odyssey\", 400),\r\n            new Book(\"The Lord of the Rings\", 1178),\r\n            new Book(\"Jane Eyre\", 500),\r\n            new Book(\"Animal Farm\", 112),\r\n            new Book(\"Brave New World\", 268),\r\n            new Book(\"The Chronicles of Narnia\", 768),\r\n            new Book(\"The Diary of a Young Girl\", 283),\r\n            new Book(\"The Alchemist\", 208),\r\n            new Book(\"Wuthering Heights\", 400),\r\n            new Book(\"Fahrenheit 451\", 158),\r\n            new Book(\"Catch-22\", 453),\r\n            new Book(\"The Hitchhiker's Guide to the Galaxy\", 224)\r\n        };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Book\r\n{\r\n    public string Name { get; set; } = \"Unknown\";\r\n    public int Pages { get; set; } = 0;\r\n\r\n    public Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500019,
                        CourseDisplayId = 20,
                        Title = "Refactoring",
                        Slug = "oop-refactoring",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "At the moment our app doesn't compile since we've changed the namespace and the implementation of the Book class. Let's fix it. Start by updating the Mockdatabase so it now starts with 5 objects of each of the LibraryItem types:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Modifying BooksController",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next we need to modify BooksController. Let's start with the ViewBooks methods, where we will display a table with the information about books:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal void ViewBooks()\r\n{\r\n    var table = new Table();\r\n    table.Border(TableBorder.Rounded);\r\n\r\n    table.AddColumn(\"[yellow]ID[/]\");\r\n    table.AddColumn(\"[yellow]Title[/]\");\r\n    table.AddColumn(\"[yellow]Author[/]\");\r\n    table.AddColumn(\"[yellow]Category[/]\");\r\n    table.AddColumn(\"[yellow]Location[/]\");\r\n    table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n    // Filtering only items of the book type\r\n    var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n    foreach (var book in books)\r\n    {\r\n        table.AddRow(\r\n            book.Id.ToString(),\r\n            $\"[cyan]{book.Name}[/]\",\r\n            $\"[cyan]{book.Author}[/]\",\r\n            $\"[green]{book.Category}[/]\",\r\n            $\"[blue]{book.Location}[/]\",\r\n            book.Pages.ToString()\r\n            );\r\n    }\r\n\r\n    AnsiConsole.Write(table);\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}" },
                                     new Paragraph {
                                        Body = "Notice we have a books variable that contains items of the LibraryItems list, as long as they are of the Book type. That is done with the help of the OfType<> extension method." },
                                     new Paragraph { Body = "In the AddBook method we need to get the user input for the missing properties:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = " public void AddBook()\r\n {\r\n     var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n     var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n     var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n     var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n     var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n     if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n     {\r\n         AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n     }\r\n     else\r\n     {\r\n         var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n         MockDatabase.LibraryItems.Add(newBook);\r\n         AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n     }\r\n\r\n     AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n     Console.ReadKey();\r\n }\r\n" },
                                }
                            },
                            new Block
                            {
                                Title = "Delete Method",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Try fixing the DeleteBook method using what you've learned in the code above. You can find the code in the link at the end of the page. " },
                                    new Paragraph { Body = "With that step, our app is no longer broken! Run it and you'll be able to add a book with all of it's properties." }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500020,
                        CourseDisplayId = 21,
                        Title = "Interfaces",
                        Slug = "interfaces",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "An interface defines a contract that classes can implement. It specifies what a class must do, but not how it does it. Unlike abstract classes, interfaces cannot contain implementation details (prior to C# 8.0; newer versions allow default implementations, but we'll focus on the traditional usage for clarity)." },
                                    new Paragraph {
                                       Body = "Interfaces and Abstract Classes are very similar, particularly after interfaces started allowing default implementations. The most important difference is that a class can implement from multiple interfaces and that's not the case with Abstract classes. Let's see an example. " },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "   public interface IAnimal\r\n    {\r\n        string Name { get; set; }\r\n        int Age { get; set; }\r\n\r\n        void MakeSound();\r\n    }\r\n\r\n public interface IMammal\r\n    {\r\n        bool HasFur { get; set; }\r\n\r\n        void NurseYoung();\r\n    }\r\n\r\npublic interface IPet\r\n    {\r\n        void Play();\r\n    }\r\n\r\npublic class Dog : IAnimal, IMammal, IPet\r\n    {\r\n        public string Name { get; set; }\r\n        public int Age { get; set; }\r\n        public bool HasFur { get; set; }\r\n      \r\n        public Dog(string name, int age, bool hasFur)\r\n        {\r\n            Name = name;\r\n            Age = age;\r\n            HasFur = hasFur;\r\n        }\r\n\r\n        public void MakeSound()\r\n        {\r\n            Console.WriteLine($\"{Name} says: Woof!\");\r\n        }\r\n\r\n        public void NurseYoung()\r\n        {\r\n            Console.WriteLine($\"{Name} is nursing its puppies.\");\r\n        }\r\n\r\n        public void Play()\r\n        {\r\n            Console.WriteLine($\"{Name} is playing fetch.\");\r\n        }\r\n    }" },
                                     new Paragraph {
                                       Body = "Here our dog inherits from multiple interfaces. That's a very common scenario in real applications, since each interface encapsulates a set of related properties and methods. Classes might inherit from difference interfaces as they need those set of members. A good way to think about it is that we should create interfaces so that they're used in a \"per need\" basis." },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500021,
                        CourseDisplayId = 22,
                        Title = "Applying Interfaces",
                        Slug = "applying-interfaces",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You probably realized we don't have a controller for Magazines and Newspapers. That means we can't do anything with those entities. Let's fix that by creating a controller for each. Since many of the methods will be similar amongst controller, we can use Inheritance." }
                                }
                            },
                            new Block
                            {
                                Title = "Base Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Create a folder called Controllers containing an interface with the following code:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}" },
                                     new Paragraph {
                                       Body = "Next modify the BooksController so it inherits from IBaseController. You'll need to modify the names of the methods:" },
                                      new Paragraph {
                                        IsCode = true,
                                       Body = "﻿using Spectre.Console;\r\nusing STUDY.OOP.LibraryManagement.Models;\r\n\r\nnamespace STUDY.OOP.LibraryManagement.Controllers;\r\n\r\ninternal class BookController : IBaseController\r\n{\r\n    public void AddItem()\r\n    {\r\n        // Implementation\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n       // Implementation\r\n    }\r\n\r\n    public void ViewItems()\r\n    {\r\n        // Implementation\r\n    }\r\n}" },
                                }
                            },
                            new Block
                            {
                                Title = "More Controllers",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the same folder create a MagazineController class:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal class MagazineController: IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}" },
                                     new Paragraph {
                                       Body = "Finally Create a NewsPaperController class:" },
                                      new Paragraph {
                                        IsCode = true,
                                       Body = "﻿using Spectre.Console;\r\nusing STUDY.OOP.LibraryManagement.Models;\r\n\r\nnamespace STUDY.OOP.LibraryManagement.Controllers;\r\n\r\ninternal class NewspaperController: IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}" },
                                       new Paragraph {
                                       Body = "Study the code closely. Although it's a lot of new code, there aren't new concepts in these methods. These are similar to the implementation of the Books Controller, but with details specific to Magazines and Newspapers." },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\npublic class BooksController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/MagazineController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class MagazineController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/NewspaperController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class NewspaperController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/IBaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Controllers;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BooksController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500022,
                        CourseDisplayId = 23,
                        Title = "Modifying The Menu",
                        Slug = "oop-modifying-menu",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you tried to run the app after the last chapter you probably realized we still can't do anything with Magazines and Newspapers! The final step to make that happens is to modify the Menus in the UserInterface class." }
                                }
                            },
                            new Block
                            {
                                Title = "One More Enum",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "First modify Enums.cs according to this code:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Two Choices",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Proceed to modify UserInterface.cs:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "namespace STUDY.OOP.LibraryManagement;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BookController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}" },
                                     new Paragraph {
                                       Body = "Notice that this class declares all controllers as fields on top of the file. These are marked as readonly." }
                                }
                            },
                             new Block
                            {
                                Title = "Readonly",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, the readonly keyword is used to specify that a field can only be assigned once, either when it's declared or in the constructor of the class. Once assigned, the value of a readonly field cannot be modified. It ensures that the field's value remains constant after its initial assignment, providing a safeguard for certain variables to avoid accidental modification later in the code." },
                                     new Paragraph {
                                       Body = "With this code the users now make two choices. The action and the item type. The methods for each action have ItemType as a parameter and each type branches execution to the corresponding controller." }
                                }
                            },
                              new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\npublic class BooksController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/MagazineController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class MagazineController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/NewspaperController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class NewspaperController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/IBaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Controllers;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BooksController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500023,
                        CourseDisplayId = 24,
                        Title = "Complex Inheritance",
                        Slug = "oop-complex-inheritance",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "C# Also supports inheritance from a base abstract class and interfaces simultaneously.   Let's create another abstract class in the Controllers folder. Notice that this class provides a default implementation of its methods:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal abstract class BaseController\r\n{\r\n    protected void DisplayMessage(string message, string color = \"yellow\")\r\n    {\r\n        AnsiConsole.MarkupLine($\"[{color}]{message}[/]\");\r\n    }\r\n\r\n    protected bool ConfirmDeletion(string itemName)\r\n    {\r\n        var confirm = AnsiConsole.Confirm($\"Are you sure you want to delete [red]{itemName}[/]?\");\r\n\r\n        return confirm;\r\n    }\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now modify the Delete and Add methods in BookController.cs" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "﻿using Spectre.Console;\r\nusing STUDY.OOP.LibraryManagement.Models;\r\n\r\nnamespace STUDY.OOP.LibraryManagement.Controllers;\r\n\r\ninternal class BookController : BaseController, IBaseController\r\n{\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            DisplayMessage(\"Book added successfully!\", \"green\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            DisplayMessage(\"Book added successfully!\", \"green\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .UseConverter(b => $\"{b.Name} by {b.Author}\")\r\n                .AddChoices(books));\r\n\r\n        if (ConfirmDeletion(bookToDelete.Name))\r\n        {\r\n            if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n            {\r\n                DisplayMessage(\"Book deleted successfully!\", \"red\");\r\n            }\r\n            else\r\n            {\r\n                DisplayMessage(\"Book not found.\", \"red\");\r\n            }\r\n        } else\r\n        {\r\n            DisplayMessage(\"Deletion canceled.\", \"yellow\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\", \"green\");\r\n        Console.ReadKey();\r\n    }\r\n}" },
                                    new Paragraph { Body = "ViewItems doesn't change, but you can find DisplayMessage used several times to print a message with a specific color. Additionally, in DeleteItem() we're calling ConfirmDeletion() method provided by the base class, asking for a binary selection from the user." },
                                    new Paragraph { Body = "Run the app and you'll be asked for confirmation when trying to delete a record." },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class BookController : BaseController, IBaseController\r\n{\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            DisplayMessage(\"Book added successfully!\", \"green\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            DisplayMessage(\"Book added successfully!\", \"green\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .UseConverter(b => $\"{b.Name} by {b.Author}\")\r\n                .AddChoices(books));\r\n\r\n        if (ConfirmDeletion(bookToDelete.Name))\r\n        {\r\n            if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n            {\r\n                DisplayMessage(\"Book deleted successfully!\", \"red\");\r\n            }\r\n            else\r\n            {\r\n                DisplayMessage(\"Book not found.\", \"red\");\r\n            }\r\n        }\r\n        else\r\n        {\r\n            DisplayMessage(\"Deletion canceled.\", \"yellow\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\", \"green\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/MagazineController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class MagazineController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/NewspaperController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class NewspaperController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\ninternal abstract class BaseController\r\n{\r\n    protected void DisplayMessage(string message, string color = \"yellow\")\r\n    {\r\n        AnsiConsole.MarkupLine($\"[{color}]{message}[/]\");\r\n    }\r\n\r\n    protected bool ConfirmDeletion(string itemName)\r\n    {\r\n        var confirm = AnsiConsole.Confirm($\"Are you sure you want to delete [red]{itemName}[/]?\");\r\n\r\n        return confirm;\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/IBaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Controllers;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BooksController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500024,
                        CourseDisplayId = 25,
                        Title = "Conclusion",
                        Slug = "oop-conclusion",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Congratulations! You've completed the Intro to Object Oriented Programming course! I hope you have enjoyed the journey. You should know be familiar with the four core principles of OOP. Most importantly you were able to apply this important programming paradigm to a real project." },
                                }
                            },
                            new Block
                            {
                                Title = "What To Do Now",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The first step I recommend is to write down a reflection upon what you've just learned. What did you think of the course? What are sub-topics you still feel you don't understand well? What feels more clear to you now?" },
                                    new Paragraph {
                                       Body = "Right now we recommend you jump back into our projects and apply the knowledge from this course wherever you can. You can revisit this course at any time. Each time you repeat a course, you'll find that you'll learn something new or see the same topic from a new perspective, no matter how many times you do it." },
                                    new Paragraph { Body = "Remember that this is an intro course covering the most used aspects of Object Oriented Programming. We're working on an advanced course, covering topics for students that are already very comfortable the material in this course. Stay tuned! And once again! Congratulations!" }
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}
