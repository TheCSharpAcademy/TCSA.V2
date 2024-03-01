using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class ArticleHelper
{
    public static List<Article> GetArticles()
    {
        return new List<Article>
        {
            new Article
            {
                Id = 1,
                Title = "Start From Scratch",
                IconUrl = "icons8-baby-app-96.png",
                Description = "Learn to set up your developer environment and basic C# concepts to get you started.",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 2,
                Title = "Learn by Doing",
                IconUrl = "icons8-direction-512.png",
                Description = "Dive into our projects, tailored to get you from absolute beginner to advanced, building your skills one step at a time.",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 3,
                Title = "Community Based",
                IconUrl = "icons8-ask-96.png",
                Description = "When you get stuck, reach out and we will help you figure out the solution, teaching you how to think like a professional developer. ",
                Area = Area.HowItWorks
            },
            new Article
            {
                Id = 4,
                Title = "Get Job Ready",
                IconUrl = "icons8-submit-resume-80.png",
                Description = "With our help, create a resume, build a portfolio and start jobhunting.",
                Area = Area.HowItWorks
            },
        };
    }
}
