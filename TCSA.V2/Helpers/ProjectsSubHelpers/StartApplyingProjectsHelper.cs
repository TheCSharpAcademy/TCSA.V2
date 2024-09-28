using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.LanguageModels;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class StartApplyingProjectsHelper
{
    private static readonly IConfiguration Configuration;
    private static readonly string DiscordLink;

    static StartApplyingProjectsHelper()
    {
        Configuration = ServiceProviderAccessor.ServiceProvider.GetService<IConfiguration>();
        DiscordLink = Configuration["LinkProvider:DiscordLink"];
    }
    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
             new Project
            {
                Id = 22,
                Title = "Portfolio",
                IconUrl = "icons8-portfolio-512.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "portfolio",
                Level = Level.Red,
                Description = "Time to create a portfolio! Let’s present your work using a nice front-end technology of your choice",
                Area = Area.StartApplying,
                ExperiencePoints = 40,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="It’s time to build your portfolio! But why? It can be argued that you can get a job without one. And it’s true. Many organisations don’t look at portfolios when hiring. So why bother? Let’s discuss a few reasons."
                    },
                    new Paragraph
                    {
                        Body="<b>You want to stand out</b>. It’s a highly competitive world out there. The fight to get through the tech industry job without any experience is tough. So you want to stack the deck in your favour by doing all you can to stand out. Your portfolio will convey an image of you. It will show that you care, that you’re organised, that you have a plan for your learning. It will show your design skills. Either you want it or not, you have a brand, everyone does. And a portfolio will make your brand stronger."
                    },
                     new Paragraph
                    {
                        Body="<b>It pushes you</b>. I’d even go as far as saying that you should build a portfolio before building any projects. That’s because it sets your vision. The vision of a full portfolio in a year time prevents you from procrastinating. It makes you get out of bed to code and put in the work. It keeps bugging you in the back of your mind: “<i>My portfolio is empty, I have to keep going</i>”. "
                    },
                     new Paragraph
                     {
                         Body = "It will also prevent you from quitting. No matter how many rejections you get, you know that if you keep building, eventually your portfolio will be so impressive that <b>YOU WILL GET NOTICED</b>. Imagine your prospective employer looking at your portfolio with projects covering dozens of different technologies? “<i>We gotta check her out!</i>”, they’ll think. "
                     },
                     new Paragraph
                     {
                         Body = "<b>It's a project in itself</b>: Building a portfolio is … <b>PART OF YOUR PORTFOLIO</b>! It will be part of your practice as a developer. You’ll have to choose a model, design it, look after the front-end details, put yourself in the viewer’s shoes, think of what to have in it, it’s great practice all-around."
                     },
                     new Paragraph
                     {
                         Body = "You’ll have to choose which technology to use: WordPress? HTML/CSS? Vanilla JS? A front-end framework? Choosing technologies is part of a developers job. And you get to practice that too. But enough talking about it, let’s do it!  "
                     }
                },
                Requirements = new List<string>
                {
                    "Your portfolio should be a static website",
                    "The following sections are required: A top area with a 'banner' or 'hero'; 'About me'; 'My work', 'Contact', Footer",
                    "You can use any technology you want: WordPress, a front-end framework, bootstrap or just the good old Html/Css/Vanilla Js combo.",
                    "The 'My Work' area should contain links to your github repositories. If you have full-stack web apps, it should contain links to their webpages.",
                    "Your portfolio should contain a \"Download Resume\" button, preferably in the top area.",
                    "It should be responsive and look good in any screen size."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://www.hostinger.com/tutorials/web-developer-portfolio'>25 Web Developer Portfolio Examples to Take Inspiration From</a>",
                    "<a target='_blank' href='https://scrimba.com/articles/web-developer-portfolio-inspiration/'>30 inspiring web developer portfolio examples you have never seen before</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=X6PwyH0thU0'>Portfolio So Good I Hired Him (Youtube)</a>"
                },
                Tips = new List<string>
                {
                    "Keep it simple. The best portfolios are the ones with an impressive amount of quality projects, not fancy, flashy, empty ones. Your goal here is to build your portfolio fast and get back to work.",
                    $"Before publishing your portfolio, make sure it's reviewed by someone in the industry. If you post your work on our <a target='_blank' href='{DiscordLink}'>Discord community</a>, we'll be happy to help.",
                    "Simple doesn't mean sloppy. Review it dozens of times so there are no misspellings, typos, broken links, non-matching colours, misaligned sections."
                }
            },
             new Project
            {
                Id = 23,
                Title = "Resume",
                IconUrl = "icons8-resume-512.png",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "The last step before start applying for jobs. Let’s build a nice resume before hit the Apply button",
                Area = Area.StartApplying,
                Slug = "resume",
                Level = Level.Red,
                ExperiencePoints = 40,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Now that you have a portfolio of projects, you need a resume. A portfolio sometimes won’t be looked at, but the resume definitely will. This is the piece where you’ll summarise the relevant information about you, and i5 will ultimately dictate if your application will move forward or not."
                    }
                },
                Requirements = new List<string>
                {
                    "Use a template",
                    "You should have links to your github and your portfolio",
                    "If you think a picture will favour you, use it, but please smile",
                    "Your resume should have a maximum of two pages. But only have two pages if you have that much relevant experience",
                    "Your resume should contain a cover letter and be different for each organisation"
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a target='blank' href='https://www.theodinproject.com/lessons/node-path-getting-hired-building-your-resume'>The Odin Project: Build your Resume</a>",
                    "<a target='blank' href='https://www.freecodecamp.org/news/how-to-write-a-resume-with-example/'>Free Code Camp: How to Write a Resume</a>",
                    "<a target='blank' href='https://enhancv.com/resume-examples/entry-level-software-engineer/'>Entry Level Resume Examples</a>",
                     "<a target='blank' href='https://resumegenius.com/resume-samples/entry-level-software-engineer-resume'>Resume Builder</a>",
                    "<a target='blank' href='https://www.youtube.com/watch?v=17YZBH_qtmg'>Resume Tips (Youtube)</a>"
                },
                ResourcesConclusion = "These should suffice, but you can always do your own research, there’s plenty of material online on how to build a nice entry level software engineering resume.  😁 Below is the resume that I landed me my first tech job. Bear in mind the project links might be broken since hosting full stack apps on Azure isn’t free and I might have removed them. ",
                Tips = new List<string>
                {
                    "Don't send resumes machine-gun style. Tailor each application to each job. Write a different cover letter to each application. Do that after looking at their website and if possible, address your future manager by name. Write about something specific you saw in the website, which means you actually took your time to prepare this application. Careless applications have less chance of succeeding.",
                    "Your resume has to look professional. Get a template, even if you need to buy one (it's cheap). There are infinite resume template services online. Remember, you're selling your brand, your resume has to look nice.",
                    "Include mostly relevant experience. I included my experience as a Salsa teacher not because I thought my moves would help the company, but because I wanted to let them know I had experience leading and communicating with large groups of people.",
                    "Track your applications. You can build an MVC app for this (in fact, we will have a project for that soon), but it can be as simple as an excel spreadsheet with a few columns: Date, Name Of the Company, Outcome. And whatever else you think is relevant."
                },
                Screenshots = new List<string>
                {
                    "resume_pablo.jpg"
                }
            },
        };
    }
}
