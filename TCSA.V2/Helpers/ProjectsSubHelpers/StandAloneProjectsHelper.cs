using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;

internal static class StandAloneProjectsHelper
{
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "FreeCodeCamp C# Certification",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                Description = "Get started completing this professional C# certification",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="For a long time Microsoft has put a lot of effort into educational material for .NET and C#. There are of resources in their <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>technical documentation</a> and <a href='https://learn.microsoft.com/en-us/training/' target='blank'>learning platform</a>, targeting from absolute beginners to senior developers seeking to improve their skills. Such an extensive library has the downside of sometimes being confused, particularly when considering the variety of technologies, their different versions accross the years and the constant evolution of .NET."
                    },
                    new Paragraph
                    {
                        Body="In August 2023, FreeCodeCamp and Microsoft paired up to offer a single unified learning resource, which gives students a professional certification when completed. This certification is comprised of a step-by-step list of topics in a curriculum provided by FreeCodeCamp, but the studying and completion of the modules happens within Microsoft's learning materials. It's a fantastic resource that prevents learners from getting lost in tutorial hell when learning the basics. "
                    }
                },
                Requirements = new List<string>
                {
                    @"You need to complete FreeCodeCamp's<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Foundational C# With Microsoft</a> certification",
                    @"Upon completion you need to submit a screenshot of your certificate either via <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> our Discord Server (Code Reviews Channel)</a> or <a target='blank' href='mailto:thecsharpacademy@gmail.com'>via E-mail</a>, along with the username/email you use to log into the academy."
                },
                Tips = new List<string>
                {
                    "You might be tempted to speed through the certification, rushing past the topics you might be familiar with. Instead, read each paragraph carefully. There are always gaps in your knowledge. We don't know what we don't know.",
                    "You don't need to complete the coding challenges in the certification to mark a section as completed. But we recommend you actually complete them, no matter how easy they are. If an exercise is too easy, try using an approach you haven't used before.",
                    "Make lots of notes, but don't fall into the trap of writing EVERYTHING down. Notes are useful when you can have a quick glance at them for reference. A good approach is to write down concise bullet points with concepts you were not familiar with. You can also have separate notes with follow-up topics you want to study.",
                    "Although you can complete the certification in a few hours, we recommend doing each section in a different day, so you're always studying with maximum focus."
                },
                Challenges = new List<string>
                {
                    "Upon completion of your project, have a go at completing the <a target='_blank' href='https://thecsharpacademy.com/project/53'>Math Game</a> project without watching the video tutorial in the project's page. It might be challenging if this is your first time building something yourself but this approach will speed up your learning.",
                }
            },
        };
    }
    internal static List<Project> GetProjectsInPortuguese()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "Certificacao C#",
                IconUrl = "cards/freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                Description = "Get started completing this professional C# certification",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Por muito tempo, a Microsoft investiu muito esforço em material educacional para .NET e C#. Há uma quantidade infinita de recursos na documentação deles, direcionados desde iniciantes até desenvolvedores sênior que procuram aprimorar suas habilidades. Uma biblioteca tão extensa tem a desvantagem de às vezes confundir os alunos, principalmente ao considerar a variedade de tecnologias, as diferentes versões de C# ao longo dos anos e a constante evolução do .NET."
                        
                    },
                    new Paragraph
                    {
                        Body="In August 2023, Free Code Camp and Microsoft paired up to offer a single unified learning resource, which gives students a professional certification when completed. This certification is comprised of a step-by-step list of topics in a curriculum provided by Free Code Camp, but the studying and completion of the modules happens within Microsoft's learning materials. It's a fantastic resource that prevents learners from getting lost in the sea of tutorials provided by Microsoft, and that's not even to mention courses found in platforms such as Udemy, Youtube and alike. "
                    }
                },
                Requirements = new List<string>
                {
                    @"You need to complete Free Code Camp's<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Foundational C# With Microsoft</a> certification",
                    @"Upon completion you need to submit a screenshot of your certificate either via <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> our Discord Server (Code Reviews Channel)</a> or <a target='blank' href='mailto:thecsharpacademy@gmail.com'>via E-mail</a>"
                },
                Tips = new List<string>
                {
                    "You might be tempted to speed through the certification, rushing past the topics you might be familiar with. Instead, read each paragraph carefully. There are always gaps in your knowledge. We don't know what we don't know.",
                    "You don't need to complete the coding challenges in the certification to mark a section as completed. But we recommend you actually complete them, no matter how easy they are. If an exercise is too easy, try using an approach you haven't used before.",
                    "Make lots of notes, but don't fall into the trap of writing EVERYTHING down. Notes are useful when you can have a quick glance at them for reference. A good approach is to write down concise bullet points with concepts you were not familiar with. You can also have separate notes with follow-up topics you want to study.",
                    "Although you can complete the certification in a few hours, we recommend doing each section in a different day, so you're always studying with maximum focus."
                },
                Challenges = new List<string>
                {
                    "Upon completion of your project, have a go at completing the <a target='_blank' href='https://thecsharpacademy.com/project/53'>Math Game</a> project without watching the video tutorial in the project's page. It might be challenging if this is your first time building something yourselfbut this approach will speed up your learning.",
                }
            },
        };
    }
    
        internal static List<Project> GetProjectsInDutch()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "FreeCodeCamp C# Certification",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                Description = "Get started completing this professional C# certification",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="For a long time Microsoft has put a lot of effort into educational material for .NET and C#. There are of resources in their <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>technical documentation</a> and <a href='https://learn.microsoft.com/en-us/training/' target='blank'>learning platform</a>, targeting from absolute beginners to senior developers seeking to improve their skills. Such an extensive library has the downside of sometimes being confused, particularly when considering the variety of technologies, their different versions accross the years and the constant evolution of .NET."
                    },
                    new Paragraph
                    {
                        Body="In August 2023, FreeCodeCamp and Microsoft paired up to offer a single unified learning resource, which gives students a professional certification when completed. This certification is comprised of a step-by-step list of topics in a curriculum provided by FreeCodeCamp, but the studying and completion of the modules happens within Microsoft's learning materials. It's a fantastic resource that prevents learners from getting lost in tutorial hell when learning the basics. "
                    }
                },
                Requirements = new List<string>
                {
                    @"You need to complete FreeCodeCamp's<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Foundational C# With Microsoft</a> certification",
                    @"Upon completion you need to submit a screenshot of your certificate either via <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> our Discord Server (Code Reviews Channel)</a> or <a target='blank' href='mailto:thecsharpacademy@gmail.com'>via E-mail</a>, along with the username/email you use to log into the academy."
                },
                Tips = new List<string>
                {
                    "You might be tempted to speed through the certification, rushing past the topics you might be familiar with. Instead, read each paragraph carefully. There are always gaps in your knowledge. We don't know what we don't know.",
                    "You don't need to complete the coding challenges in the certification to mark a section as completed. But we recommend you actually complete them, no matter how easy they are. If an exercise is too easy, try using an approach you haven't used before.",
                    "Make lots of notes, but don't fall into the trap of writing EVERYTHING down. Notes are useful when you can have a quick glance at them for reference. A good approach is to write down concise bullet points with concepts you were not familiar with. You can also have separate notes with follow-up topics you want to study.",
                    "Although you can complete the certification in a few hours, we recommend doing each section in a different day, so you're always studying with maximum focus."
                },
                Challenges = new List<string>
                {
                    "Upon completion of your project, have a go at completing the <a target='_blank' href='https://thecsharpacademy.com/project/53'>Math Game</a> project without watching the video tutorial in the project's page. It might be challenging if this is your first time building something yourself but this approach will speed up your learning.",
                }
            },
        };
    }
}
