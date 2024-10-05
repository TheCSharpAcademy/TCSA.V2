using TCSA.V2.Models;
using TCSA.V2.Data;

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
                        IconUrl = "",
                        BannerUrl = "",
                        BannerV2 = "",
                        Area = Area.Course,
                        ReleaseDate = new DateTime(2024, 1, 15),
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "Introduction",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "dasdadasdasld of Object-Oriented Programming (OOP) in C#! Your programming life will never been the same. In this chapter, we'll explore what OOP is, why it's important, and how it makes your code more organized, readable, and maintainable. By the end of this course you'll be more confident in your coding skills and more prepared to tackle any software development project." },
                                    new Paragraph { Body = "Imagine you have two workshops. One is clean and tidy, with tools neatly arranged on shelves, labeled drawers for screws and nails, and a well-organized space where you can quickly find what you need. The other is chaotic, with tools scattered across the floor, screws mixed with nails in random boxes, and materials piled up in no particular order." },
                                    new Paragraph { Body = "Which workshop would you prefer to work in? The tidy one allows you to be more productive—you can easily locate your tools, everything has its place, and the space just makes sense. The messy workshop, on the other hand, slows you down. You waste time searching for what you need, and the chaos makes it harder to complete your projects efficiently." },
                                    new Paragraph { IsPicture = true, PictureUrl = "workshops.png"},
                                    new Paragraph { Body = "In OOP, you break down a complex problem into smaller, manageable parts. Each part is a \"tool\" that can be reused, improved, or replaced without affecting the entire program. With OOP, your projects become more scalable and easier to debug because you can pinpoint issues more quickly." },
                                    new Paragraph { Body = "In the chapters ahead, you'll learn how to use OOP principles in C# to create well-organized, clean, and efficient code. Just like in the tidy workshop, everything will have its place, making it easier for you to build and maintain your projects." }
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
                        IconUrl = "/images/csharp-icon.png",
                        BannerUrl = "/images/csharp-banner.png",
                        BannerV2 = "/images/csharp-banner-v2.png",
                        Area = Area.StartHere,
                        ReleaseDate = new DateTime(2024, 1, 15),
                        ExperiencePoints = 100,
                        Level = Level.White,
                        IsClosed = false,
                        NextSlug = "variables-and-data-types",
                        CardImgUrl = "/images/csharp-card.png",
                        Author = "John Doe",
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "About this Course",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In this course, we will be building a Library Management System to help demonstrate the concepts of Object-Oriented Programming (OOP) in C#. This project will serve as a practical, hands-on way to apply OOP principles and understand how they work in real-world scenarios." },
                                    new Paragraph { Body = "Learning OOP theory alone can be difficult and abstract. It’s one thing to read about classes, objects, and inheritance, but it's another to actually use them to solve a real-world problem. That’s why building a project like the Library Management System is so important." },
                                    new Paragraph { Body = "Projects provide context. They allow you to see how all the pieces fit together and how the concepts you learn are applied in actual coding tasks. A project:" },
                                    new Paragraph
{
    Body = @"
<ul>
    <li><strong>Gives Purpose to Concepts:</strong> Rather than just memorizing definitions, you’ll see how classes, methods, and objects work together to form a functioning system.</li>
    <li><strong>Encourages Problem Solving:</strong> When building a project, you’ll encounter challenges that force you to think critically and apply your knowledge.</li>
    <li><strong>Develops Real-World Skills:</strong> By the end of the course, you won’t just understand OOP—you’ll have practical experience applying it to a full project.</li>
    <li><strong>Boosts Confidence:</strong> Completing a project gives you something tangible to showcase, and it will boost your confidence as you see your progress.</li>
</ul>
"
},

                                    new Paragraph { Body = "The Library Management System will simulate a simplified library where you can manage books, magazines, and newspapers. The system will allow you to:" },
                                    new Paragraph
{
    Body = @"
<ul>
    <li>Add, edit, and delete library items</li>
    <li>View details of each item</li>
    <li>Keep track of different types of items (books, magazines, newspapers) with specific properties for each</li>
</ul>
"
},
                                    new Paragraph { Body = "Through this project, you'll see how OOP allows us to:" },
                                    new Paragraph
{
    Body = @"
<ul>
    <li>Create reusable components (like different types of library items)</li>
    <li>Group related data and behavior into classes</li>
    <li>Leverage inheritance to avoid repeating code</li>
    <li>Use encapsulation to protect and manage data efficiently</li>
</ul>
"
},
                                    new Paragraph { Body = "In the next chapters, we'll start small by creating classes for different types of library items and gradually expand the system to introduce more complex functionality. Along the way, you'll be applying OOP concepts such as classes, objects, inheritance, polymorphism, and more." },
                                    new Paragraph { Body = "By the end of this course, not only will you have a strong understanding of OOP, but you'll also have a complete Library Management System that you can continue to build upon." },
                                    new Paragraph { Body = "Let's get started!" },
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}
