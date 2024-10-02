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
                        Id = 1,
                        Title = "Introduction",
                        Slug = "getting-started-with-csharp",
                        Description = "Learn the fundamentals of C# programming language.",
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
                                Title = "Introduction",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Welcome to the world of Object-Oriented Programming (OOP) in C#! Your programming life will never been the same. In this chapter, we'll explore what OOP is, why it's important, and how it makes your code more organized, readable, and maintainable. By the end of this course you'll be more confident in your coding skills and more prepared to tackle any software development project." },
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
                        Id = 2,
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
                                Title = "Introduction",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Welcome to the world of Object-Oriented Programming (OOP) in C#! Your programming life will never been the same. In this chapter, we'll explore what OOP is, why it's important, and how it makes your code more organized, readable, and maintainable. By the end of this course you'll be more confident in your coding skills and more prepared to tackle any software development project." },
                                    new Paragraph { Body = "Imagine you have two workshops. One is clean and tidy, with tools neatly arranged on shelves, labeled drawers for screws and nails, and a well-organized space where you can quickly find what you need. The other is chaotic, with tools scattered across the floor, screws mixed with nails in random boxes, and materials piled up in no particular order." },
                                    new Paragraph { Body = "Which workshop would you prefer to work in? The tidy one allows you to be more productive—you can easily locate your tools, everything has its place, and the space just makes sense. The messy workshop, on the other hand, slows you down. You waste time searching for what you need, and the chaos makes it harder to complete your projects efficiently." },
                                    new Paragraph { IsPicture = true, PictureUrl = "workshops.png"},
                                    new Paragraph { Body = "In OOP, you break down a complex problem into smaller, manageable parts. Each part is a \"tool\" that can be reused, improved, or replaced without affecting the entire program. With OOP, your projects become more scalable and easier to debug because you can pinpoint issues more quickly." },
                                    new Paragraph { Body = "In the chapters ahead, you'll learn how to use OOP principles in C# to create well-organized, clean, and efficient code. Just like in the tidy workshop, everything will have its place, making it easier for you to build and maintain your projects." }
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}
