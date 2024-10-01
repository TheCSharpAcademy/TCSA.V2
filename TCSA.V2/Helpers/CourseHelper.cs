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
                Title = "Introduction to C# Programming",
                Description = "A comprehensive introduction to C#, covering basics to advanced topics.",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 1,
                        Title = "Getting Started with C#",
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
                                Title = "Introduction to C#",
                                ImgUrl = "/images/intro-csharp.png",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "C# is a modern, object-oriented programming language developed by Microsoft." },
                                    new Paragraph { IsCode = true, Body = "Console.WriteLine(\"Hello World!\");" }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 2,
                        Title = "Variables and Data Types",
                        Slug = "variables-and-data-types",
                        Description = "Understand variables, data types, and how to use them in C#.",
                        IconUrl = "/images/variables-icon.png",
                        BannerUrl = "/images/variables-banner.png",
                        BannerV2 = "/images/variables-banner-v2.png",
                        Area = Area.Console,
                        ReleaseDate = new DateTime(2024, 2, 1),
                        ExperiencePoints = 150,
                        Level = Level.White,
                        IsClosed = false,
                        NextSlug = "control-structures",
                        CardImgUrl = "/images/variables-card.png",
                        Author = "Jane Smith",
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "Understanding Variables",
                                ImgUrl = "/images/variables-block.png",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Variables are used to store data in your programs. Each variable has a specific data type." },
                                    new Paragraph { IsCode = true, Body = "int age = 30;\nstring name = \"John\";" }
                                }
                            }
                        }
                    }
                }
            },
            new Course
            {
                Id = 2,
                Title = "Building Web Apps with Blazor",
                Description = "Learn how to build interactive web applications using Blazor.",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 1,
                        Title = "Introduction to Blazor",
                        Slug = "introduction-to-blazor",
                        Description = "Get started with Blazor and understand its core concepts.",
                        IconUrl = "/images/blazor-icon.png",
                        BannerUrl = "/images/blazor-banner.png",
                        BannerV2 = "/images/blazor-banner-v2.png",
                        Area = Area.Blazor,
                        ReleaseDate = new DateTime(2024, 3, 10),
                        ExperiencePoints = 200,
                        Level = Level.White,
                        IsClosed = false,
                        NextSlug = "building-components",
                        CardImgUrl = "/images/blazor-card.png",
                        Author = "Sarah Connor",
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "What is Blazor?",
                                ImgUrl = "/images/intro-blazor.png",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Blazor is a framework for building interactive web UIs with C#." },
                                    new Paragraph { IsPicture = true, PictureUrl = "/images/blazor-example.png" }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 2,
                        Title = "Building Components",
                        Slug = "building-components",
                        Description = "Learn how to build reusable components in Blazor.",
                        IconUrl = "/images/components-icon.png",
                        BannerUrl = "/images/components-banner.png",
                        BannerV2 = "/images/components-banner-v2.png",
                        Area = Area.Blazor,
                        ReleaseDate = new DateTime(2024, 4, 5),
                        ExperiencePoints = 250,
                        Level = Level.White,
                        IsClosed = false,
                        NextSlug = "state-management",
                        CardImgUrl = "/images/components-card.png",
                        Author = "Kyle Reese",
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "Creating Your First Component",
                                ImgUrl = "/images/component-block.png",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In Blazor, components are the basic building blocks of the UI." },
                                    new Paragraph { IsCode = true, Body = "<Component>\n    @code {\n        public string Message = \"Hello from Blazor!\";\n    }\n</Component>" }
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}
