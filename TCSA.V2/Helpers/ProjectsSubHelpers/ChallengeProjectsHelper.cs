using TCSA.V2.Models;
using TCSA.V2.Models.LangugageModels;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class ChallengeProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
             new Project
            {
                Id = 64,
                Title = "Brewery API",
                IconUrl = "icons8-brewery-64.png",
                BannerUrl = "brewerychallenge.jpg",
                LanguageHeadings = new EnglishHeadings(),
                ExperiencePoints = 50,
                Description = "Improve your .NET WebAPI skills building a Brewery API",
                Area = Area.MonthlyChallenge,
                Difficulty = Difficulty.Intermediate,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In our first monthly challenge, we will use a project that was sent by a company as a test for hiring developer for an entry-level position. This project will give you a good idea of what is required from a developer to break into the industry."
                    },
                    new Paragraph
                    {
                        Body="In this type of project, it's important to follow the requirements strictly. But that doesn't mean you can't add functionalities to try to impress the hiring managers. It's all about finding the balance between your deadline and how much energy you want to invest into it."
                    },
                     new Paragraph
                    {
                        Body="Unlike all the other projects in the academy, the repository to which you'll submit your pull request won't contain any other projects. Also, we won't provide tips or resources. You are on your own. The idea is to replicate a real-life test. After completing such a project you'll be better prepared when you receive a similar type of test from a real company. On the bright side, we will have challenges. And for each challenge you'll be awarded extra points for your efforts."
                    },
                     new Paragraph
                    {
                        Body="Keep in mind code reviews might take a bit longer as a high volume of code reviews are expected. If this is your first time in the platform, please be aware <a target='blank' href='/Identity/Account/Register'>you need to be registered</a> (for free) to submit code reviews.  Let's get into it!"
                    }
                },
                RequirementsIntro = "Welcome to Belgium! You've been contacted to create a management system for breweries and wholesalers. Below are listed the functional and technical requirements sent by your client",
                Requirements = new List<string>
                {
                    "List all beers by brewery",
                    "A brewer can add, delete and update beers",
                    "Add the sale of an existing beer to an existing wholesaler",
                    "Upon a sale, the quantity of a beer needs to be incremented in the wholesaler's inventory",
                    "A client can request a quote from a wholesaler.",
                    "If successful, the quote returns a price and a summary of the quote. A 10% discount is applied for orders above 10 units. A 20% discount is applied for orders above 20 drinks.",
                    "If there is an error, it returns an exception and a message to explain the reason: order cannot be empty; wholesaler must exist; there can't be any duplicates in the order; the number of beers ordered cannot be greater than the wholesaler's stock; the beer must be sold by the wholesaler",
                    "A brewer brews one or several beers",
                    "A beer is always linked to a brewer",
                    "A beer can be sold by several wholesalers",
                    "A wholesaler sells a defined list of beers, from any brewer, and has only a limited stock of those beers",
                    "The beers sold by the wholesaler have a fixed price imposed by the brewery",
                    "For this assessment, it is considered that all sales are made without tax",
                    "The database is pre-filled by you",
                    "No front-end is needed, just the API",
                    "Use REST architecture",
                    "Use Entity Framework",
                    "No migrations are needed; use Ensure Deleted and Ensure Created to facilitate development and code reviews."
                },
                Challenges = new List<string>
                {
                    "Add unit tests to make sure business constraints are accurate. <b>(Bonus: 20XPs)</b>",
                    "Include a Read me with your thought process, your challenges and instructions on how to run the app. <b>(Bonus: 20XPs)</b>",
                    "Add integrations tests using a real test database. These will ensure data is still added corrected when the codebase changes. The test database must be created and deleted for each test. <b>(Bonus: 50XPs)</b>",
                    "Create a separate project with a front-end of your choice. Provide instructions on how to run it. <b>(Bonus: 50XPs)</b>"
                }
            },
        };
    }
}