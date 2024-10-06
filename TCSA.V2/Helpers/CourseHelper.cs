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
                        Id = 500000,
                        CourseDisplayId = 1,
                        Title = "Introduction",
                        Slug = "getting-started-with-csharp",
                        Description = "Learn the fundamentals of C# programming language.",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "Introduction",
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
                                        Body = "var menuChoices = new string[3] { \"View Books\", \"AddBook\", \"Delete Book\" };\r\n\r\nvar choice = AnsiConsole.Prompt(\r\n        new SelectionPrompt<string>()\r\n        .Title(\"What do you want to do next?\")\r\n        .AddChoices(menuChoices));"
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
                            }
                        }
                    }
                }
            }
        };
    }
}
