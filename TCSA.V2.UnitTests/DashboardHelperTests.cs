using TCSA.V2.Models;
using TCSA.V2.Helpers;
using TCSA.V2.Data;

namespace TCSA.V2.UnitTests;

public class DashboardHelperTests
{
    private readonly List<Project> _projects;
    private readonly List<Article> _articles;

    public DashboardHelperTests()
    {
        _projects = new List<Project>
        {
            new Project { Id = 1, Area = Area.Console },
            new Project { Id = 2, Area = Area.Console, Difficulty = Difficulty.Beginner }
        };

        _articles = new List<Article>
        {
            new Article
            {
                Id = 5,
                Title = "Start Here",
                IconUrl = "icons8-door-80.png",
                Description = "This is your starting point. Click on the door to find out how the academy works and to read very important tips that will help you in your journey.",
                ExperiencePoints = 5,
                Slug = "start-here",
                BannerUrl = "start-line.jpeg",
                Area = Area.StartHere,
                Level = Level.Green,
                NextSlug = "article/6/getting-help"   
            },
            new Article
            {
                Id = 6,
                Title = "Getting Help",
                IconUrl = "icons8-helping-96.png",
                BannerUrl = "",
                Slug="getting-help",
                Description = "You’ll get stuck. Many times. It’s the life of a developer. Find out how to solve problems like a professional programmer and where to get help.",
                Area = Area.StartHere,
                Level = Level.Green,
                ExperiencePoints = 5,
                NextSlug = "article/7/setting-up",
            
            },
            new Article
            {
                Id = 7,
                Title = "Setting Up",
                IconUrl = "icons8-project-setup-96-1.png",
                BannerUrl = "",
                Slug="setting-up",
                Description = "Learn how to set up your develop environment with .NET framework and Visual Studio so you can get ready to start coding.",
                Area = Area.StartHere,
                Level = Level.Green,
                ExperiencePoints = 5,
                NextSlug = "article/8/foundations",
            },
            new Article
            {
                Id = 8,
                Title = "C# Foundations",
                IconUrl = "icons8-sharp-94.png",
                Slug="foundations",
                BannerUrl = "",
                Description = "Dive into basic C# syntax and control flow. You’ll learn just enough theory to have a solid foundation before jumping into our projects.",
                Area = Area.StartHere,
                Level = Level.Green,
                ExperiencePoints = 5
                
            },
            new Article
            {
                Id = 9,
                Area = Area.Console,
                Level = Level.Green,
                ExperiencePoints = 5
            }
        };
    }

    [Theory]
    [InlineData(new[] { 5,6,7,8 })]
    public void CheckIfAreaIsCompleted_AreaCompleted_ReturnsTrue(int[] completedProjects)
    {
        // Act
        var result = DashboardHelper.CheckIfAreaIsCompleted(_projects, _articles, completedProjects.ToList(), Area.StartHere, null);

        // Assert
        Assert.True(result);
    }
}