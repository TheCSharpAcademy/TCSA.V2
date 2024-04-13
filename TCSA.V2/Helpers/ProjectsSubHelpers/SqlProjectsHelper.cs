using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class SqlProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
            
            new Project
            {
                Id = 76,
                Title = "Starter SQL Challenges",
                IconUrl = "sql.png",
                BannerUrl = "",
                ExperiencePoints = 10,
                Description = "Start your SQL journey with easy exercises",
                Area = Area.SQL,
                Level = Level.Grey,
                Slug = "starter-sql",
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="This is your first SQL challenge! Although there isn't too much hype around SQL, it's one of the most important skills for a software developer. One could argue that nothing can be done on the internet without writing to and reading from databases, and SQL is the most common language used to communicate with them. "
                    },
                    new Paragraph
                    {
                        Body="For .NET developers, it's tempting to skip SQL and jump straight into Entity Framework. It's indeed a great ORM and gone are the days where it would suit only simple projects, while raw SQL would be required for more complex operations. However, a developer will only have advanced knowledge of Entity Framework with advanced knowledge of SQL. After all Entity Framework does nothing more than compile into SQL! (in a neat, developer-friendly way, we must say)."
                    },
                    new Paragraph
                    {
                        Body="In this project we're using CodeWars exercises integrated with our platform to deliver automated feedback. CodeWars is a popular online platform that offers a collection of coding challenges and programming exercises. It provides a wide variety of programming problems that cover different programming languages, algorithms, data structures, and computer science concepts."
                    }
                },
                RequirementsIntro = "For this project you'll complete the following exercises in the Code Wars Platform:",
                Requirements = new List<string>
                {
                    "<a target='blank' href='https://www.codewars.com/kata/590a95eede09f87472000213'>Adults only (SQL for Beginners #1)</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/590ba881fe13cfdcc20001b4'>On the Canadian Border (SQL for Beginners #2)</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/590cc86f7557c0494000007e'>Register for the Party (SQL for Beginners #3)</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/5910b0d378cc2ba91400000b'>Collect Tuition (SQL for Beginners #4)</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/591127cbe8b9fb05bd00004b'>Best-Selling Books (SQL for Beginners #5)</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/5e5f09dc0a17be0023920f6f'>Countries Capitals for Trivia Night (SQL for Beginners #6)</a>",
                },
                Tips = new List<string>
                {
                    "You don't need to refrain from using Chat GPT. However avoid the temptation of using it without understanding the SQL script. AI  will only take you so far and you won't be able to handle very complex scenarios. Try to understand what EACH KEYWORD does. Also ask Chat GPT for alternative answers.",
                    "Create your own library of scripts and push it to Github. You'll find yourself reusing your old scripts, or basing yourself off of old ones all the time. It will save you a lot of time to have your own library as a reference."
                },

                ResourcesIntro = "If this is your first contact with SQL, Free Code Camp's tutorial is an excellent resource. It's 5 years old but that's not an issue. Most core SQL features haven't changed a lot since they have been created. If you already know some SQL, SQLtutorial.org is a slim, to-the-point resource for learning commands you're not familiar with.",
                Resources = new List<string>
                {
                    "<a href='https://www.sqltutorial.org/' target='_blank'>Sqltutorial.org</a>",
                    "<a href='https://www.youtube.com/watch?v=HXV3zeQKqGY' target='_blank'>Free Code Camp SQL Tutorial (Youtube)</a>"
                },
                IsClosed = false,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Linking your Codewars user name with the C# Academy.",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In The C# Academy's Dashboard, you'll see a button where you can insert your Codewars user name. Your input has to match Code War's username exactly, including case sensitivity, or we won't be able to track your results."
                            },
                            new Paragraph
                            {
                                Body = "Once you have completed a challenge, refresh this page and you'll be able to see your progress so far at the bottom of the page. Once all challenges are finished, the project will be marked as completed automatically."
                            }
                        }
                    }
                },
                CodeWarsChallenges = new List<CodeWarsChallenge>
                {
                    new CodeWarsChallenge
                    {
                        Id = "590a95eede09f87472000213",
                        Name = "Adults only (SQL for Beginners #1)"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "590ba881fe13cfdcc20001b4",
                        Name = "On the Canadian Border (SQL for Beginners #2)"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "590cc86f7557c0494000007e",
                        Name = "Register for the Party (SQL for Beginners #3)"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "5910b0d378cc2ba91400000b",
                        Name = "Collect Tuition (SQL for Beginners #4)"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "591127cbe8b9fb05bd00004b",
                        Name = "Best-Selling Books (SQL for Beginners #5)"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "5e5f09dc0a17be0023920f6f",
                        Name = "Countries Capitals for Trivia Night (SQL for Beginners #6)"
                    },
                }
            },
            new Project
            {
                Id = 77,
                Title = "Starter SQL Challenges 2",
                IconUrl = "sql.png",
                BannerUrl = "",
                ExperiencePoints = 10,
                Description = "Creating a solid SQL Foundation",
                Slug = "starter-sql-2",
                Area = Area.SQL,
                Level = Level.Grey,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Continuing with our SQL projects linked with Code Wars, we will work on a few different ways to processed the data being returned by the queries. Try solving the questions by heart before using Google and Chat GPT. Although these are useful tools in day to day development, relying exclusively on them will prevent you succeeding in situations where you can't use them, such as coding interviews. "
                    }
                },
                RequirementsIntro = "For this project you'll complete the following exercises in the Code Wars Platform:",
                Requirements = new List<string>
                {
                    "<a target='blank' href='https://www.codewars.com/kata/58111670e10b53be31000108'>SQL Basics: Simple DISTINCT</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/581113dce10b531b1d0000bd'>SQL Basics: Simple MIN / MAX</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/58110da0009b4f7ef80000ad'>SQL Basics: Simple SUM</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/5809508cc47d327c12000084'>SQL Basics: Simple WHERE and ORDER BY</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/594a9592704e4d21bc000131'>SQL Basics: Modulus</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/594a6133704e4daf5d00003d'>Easy SQL: Rounding Decimals</a>",
                },
                ResourcesIntro = "If this is your first contact with SQL, Free Code Camp's tutorial is an excellent resource. It's 5 years old but that's not an issue. Most core SQL features haven't changed a lot since they have been created. If you already know some SQL, SQLtutorial.org is a slim, to-the-point resource for learning commands you're not familiar with.",
                Resources = new List<string>
                {
                    "<a href='https://www.sqltutorial.org/' target='_blank'>Sqltutorial.org</a>",
                    "<a href='https://www.youtube.com/watch?v=HXV3zeQKqGY' target='_blank'>Free Code Camp SQL Tutorial (Youtube)</a>"
                },
                IsClosed = false,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Linking your Codewars user name with the C# Academy.",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In The C# Academy's Dashboard, you'll see a button where you can insert your Codewars user name. Your input has to match Code War's username exactly, including case sensitivity, or we won't be able to track your results."
                            },
                            new Paragraph
                            {
                                Body = "Once you have completed a challenge, refresh this page and you'll be able to see your progress so far at the bottom of the page. Once all challenges are finished, the project will be marked as completed automatically."
                            }
                        }
                    }
                },
                CodeWarsChallenges = new List<CodeWarsChallenge>
                {
                    new CodeWarsChallenge
                    {
                        Id = "58111670e10b53be31000108",
                        Name = "SQL Basics: Simple DISTINCT"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "581113dce10b531b1d0000bd",
                        Name = "SQL Basics: Simple MIN / MAX"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "58110da0009b4f7ef80000ad",
                        Name = "SQL Basics: Simple SUM"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "5809508cc47d327c12000084",
                        Name = "SQL Basics: Simple WHERE and ORDER BY"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "594a9592704e4d21bc000131",
                        Name = "SQL Basics: Modulus"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "594a6133704e4daf5d00003d",
                        Name = "Easy SQL: Rounding Decimals"
                    },
                }
            },
            new Project
            {
                Id = 78,
                Title = "Starter SQL Challenges 3",
                IconUrl = "sql.png",
                BannerUrl = "",
                ExperiencePoints = 10,
                Slug = "starter-sql-3",
                Description = "Slightly more advanced challenges",
                Area = Area.SQL,
                Level = Level.Grey,
                Difficulty = Difficulty.Beginner,
                RequirementsIntro = "For this project you'll complete the following exercises in the Code Wars Platform:",
                Requirements = new List<string>
                {
                    "<a target='blank' href='https://www.codewars.com/kata/658ae4c7dc801726974dce76'>Calculating Next Fiscal Year-End Dates for UK Companies</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/6565d16cec724304be564778'>Correcting an SQL Query : Unexpected Data Inflation and Null Value Anomalies",
                    "<a target='blank' href='https://www.codewars.com/kata/594633020a561e329a0000a2'>Easy SQL: Counting and Grouping</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/653f7207da59f62d2ee55035'>Drug Dosages with Dual Unit Measurements</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/650c5aa70b7009a1640c9596'>Sibling Count based on Common Parent</a>",
                    "<a target='blank' href='https://www.codewars.com/kata/62b0da0e58e471000f28ce99'>First Normal Form</a>",
                },
                IsClosed = false,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Linking your Codewars user name with the C# Academy.",
                        ImgUrl= "icons8-software-installer-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In The C# Academy's Dashboard, you'll see a button where you can insert your Codewars user name. Your input has to match Code War's username exactly, including case sensitivity, or we won't be able to track your results."
                            },
                            new Paragraph
                            {
                                Body = "Once you have completed a challenge, refresh this page and you'll be able to see your progress so far at the bottom of the page. Once all challenges are finished, the project will be marked as completed automatically."
                            }
                        }
                    }
                },
                CodeWarsChallenges = new List<CodeWarsChallenge>
                {
                    new CodeWarsChallenge
                    {
                        Id = "658ae4c7dc801726974dce76",
                        Name = "Calculating Next Fiscal Year-End Dates for UK Companies"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "6565d16cec724304be564778",
                        Name = "Correcting an SQL Query : Unexpected Data Inflation and Null Value Anomalies"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "594633020a561e329a0000a2",
                        Name = "Easy SQL: Counting and Grouping"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "653f7207da59f62d2ee55035",
                        Name = "Drug Dosages with Dual Unit Measurements"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "650c5aa70b7009a1640c9596",
                        Name = "Sibling Count based on Common Parent"
                    },
                    new CodeWarsChallenge
                    {
                        Id = "62b0da0e58e471000f28ce99",
                        Name = "First Normal Form"
                    }
                }
            }
        };
    }
}
