using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class OpenSourceProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
             {
                Id = 54,
                Title = "Point Of Sale",
                IconUrl = "icons8-point-of-sale-64.png",
                BannerUrl = "",
                Slug = "point-of-sale",
                Description = "Help create a Point of Sale app along with the C# Academy community. See available issues below:",
                Area = Area.OpenSource,
                Difficulty = Difficulty.Beginner,
                IsCommunityProject = true,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="A key skill for software developers is the ability to work in teams. While the tranquility of working individually is benefitial for your learning, having a taste of collaborative work will give you an idea of what working with software professionally is like."
                    },
                    new Paragraph
                    {
                        Body="In this type of project, it's specially important to pay attention to the requirements, since it's not up to you to ultimately decide how a feature should be implemented. There's also an element of pressure, since delays in your work will affect other developers and the pace of the project itself."
                    },
                     new Paragraph
                    {
                        Body="It can be hard to find open source projects that are beginner friendly. This first project has a very low entry barrier. You will will be able to participate with a very small amount of knowledge. The only requirement is basic knowledge of C# and Entity Framework. But if you haven't learned Entity Framework yet, don't worry. There should be tasks that demand very basic knowledge."
                    },
                     new Paragraph
                    {
                        Body="When you go through the list of tasks in this project, feel free to pick the ones that are within your skillset. Some tasks will be harder than others, there will be something for everyone. If you think you're still not skilled enough to contribute, don't worry. We will have new open source projects all the time. Come back later and check our webpage to see what's new."
                    },
                    new Paragraph
                    {
                        Body="In this project we will build a point of sale, a very common and important business case that is a key part of any company that sells products directly to consumers, from the food truck in the corner to a giant department store."
                    },
                    new Paragraph
                    {
                        Body="So let's see how it works!"
                    }
                },
                RequirementsIntro = "Each issue in this project will have it's own requirements. You can see <a href='https://github.com/users/TheCSharpAcademy/projects/2' target='_blank'>this project's issues here</a>.<b> Please assign yourself to the issue on Github before assigning it to yourself in our platform. If you are not able to assign it to yourself on Github, please contact us on Discord.</b>",
                Tips = new List<string>
                {
                    "Please make sure you only assign yourself to ONE issue at a time. You should only assign yourself to an issue once your current issue has been approved and merged. This is important so more people get to participate. There will be a change soon where this will be enforced by our platform.",
                    "When assigning yourself to an issue, make sure you are able to build and run the project. Then get familiar with the code base. Only then start your work. Feel free to reach out with any questions.",
                    "When assigned to an issue, make sure you follow the requirements. Refrain from adding extra functionalities.",
                    "You can create issues yourself on Github. Make sure you add a description/explanation of why you think that issue is important, and it will be assessed by The C# Academy team.",
                    "If you have questions about an existing issue, please post a comment on the issue itself on Github.",
                    "Make sure you assign yourself only to issues you're confident you can complete, or at least that aren't too far off your knowledge",
                    "At the moment you can't unassign yourself from an issue through our platform (we're working on that functionality). If you can't complete a task within 48hs let us know via Discord or e-mail. Assigned incomplete issues will be unassigned after 72hs if we don't hear from assignees."
                }
            },
            new Project
            {
                Id = 87,
                Title = "Academy V2",
                IconUrl = "icons8-construction-64.png",
                BannerUrl = "",
                Slug = "academy-upgrade",
                Description = "Help create The New C# Academy Website. See available issues below:",
                Area = Area.OpenSource,
                Difficulty = Difficulty.Beginner,
                IsCommunityProject = true,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="A key skill for software developers is the ability to work in teams. While the tranquility of working individually is benefitial for your learning, having a taste of collaborative work will give you an idea of what working with software professionally is like."
                    },
                    new Paragraph
                    {
                        Body="In this type of project, it's specially important to pay attention to the requirements, since it's not up to you to ultimately decide how a feature should be implemented. There's also an element of pressure, since delays in your work will affect other developers and the pace of the project itself."
                    },
                     new Paragraph
                    {
                        Body="When you go through the list of tasks in this project, feel free to pick the ones that are within your skillset. Some tasks will be harder than others, there will be something for everyone. If you think you're still not skilled enough to contribute, don't worry. We will have new open source projects and tasks all the time. Come back later and check our webpage to see what's new."
                    },
                    new Paragraph
                    {
                        Body="In this project we will build the new C# Academy website, using the a state-of-the-art technology: .NET8/Blazor, full of new features, refurbished UI elements and most importantly: Translated to many languages!"
                    },
                     new Paragraph
                    {
                        Body="Keep in mind that since this is an actual project that will be out in the world for people to see, the code review will be more demanding than your usual training project in the academy and have professional standards."
                    },
                    new Paragraph
                    {
                        Body="So let's see how it works!"
                    }
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Finding Issues",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Each issue in this project will have it's own requirements. You can see <ahref='https://github.com/users/TheCSharpAcademy/projects/5' target='_blank'>this project's issues here</a>.<b> Please assign yourself to the issue on Github before assigning it to yourself in our platform. If you are not able to assign it to yourself on Github, please contact us on Discord.</b>"
                            },
                            new Paragraph
                            {
                                Body = "In the platform, you can see a list of issues on the right side of your dashboard, under Community Projects Available. The 'Click to See' button won't be present if no issues are present."
                            },
                            new Paragraph
                            {
                                IsPicture= true,
                                PictureUrl="tcsav2-1.png",
                            },
                             new Paragraph
                            {
                                Body = "The issues on github and in the platform have an identical name. Make sure you assign yourself correctly in both. That step isn't done automatically."
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Branches",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "We'll be working with branches instead of forks. You'll create a branch based on the repository's DEVELOPMENT branch. The best way to achieve this is by clicking on Create Branch in the ticket itself. If you submit a PR for a ticket created this way, the progress will be tracked in the issue on github automatically.</b>"
                            },
                            new Paragraph
                            {
                                Body = "Once your branch is updated and committed to the remote repository, you'll create a pull request against the development branch. Only the maintainers of the project will be able to create a pull request from development to master."
                            },
                            new Paragraph
                            {
                                IsPicture= true,
                                PictureUrl="tcsav2-2.png",
                            },
                        }
                    }
                }
                ,
                Tips = new List<string>
                {
                    "To run the project you'll need to modify the server's connection string so it fits your machine.",
                    "Please make sure you only assign yourself to ONE issue at a time. You should only assign yourself to an issue once your current issue has been approved and merged. This is important so more people get to participate. There will be a change soon where this will be enforced by our platform.",
                    "When assigning yourself to an issue, make sure you are able to build and run the project. Then get familiar with the code base. Only then start your work. Feel free to reach out with any questions.",
                    "When assigned to an issue, make sure you follow the requirements. Refrain from adding extra functionalities.",
                    "If you have questions about an existing issue, please post a comment on the issue itself on Github.",
                    "Make sure you assign yourself only to issues you're confident you can complete, or at least that aren't too far off your knowledge",
                    "At the moment you can't unassign yourself from an issue through our platform (we're working on that functionality). If you can't complete a task within 48hs let us know via Discord or e-mail. Assigned incomplete issues will be unassigned after 72hs if we don't hear from assignees."
                }
            },
        };
    }
}