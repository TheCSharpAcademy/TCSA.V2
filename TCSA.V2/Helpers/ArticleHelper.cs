using Microsoft.EntityFrameworkCore.Infrastructure;
using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers;

public static class ArticleHelper
{
    public static List<Article> GetArticles()
    {
        var configuration = ServiceProviderAccessor.ServiceProvider.GetService<IConfiguration>();
        var discordLink = configuration["LinkProvider:DiscordLink"];

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
                NextSlug = "article/6/getting-help",
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Hi! Welcome to The C# Academy!"
                            },
                            new Paragraph
                            {
                                Body = "It’s great to have the opportunity to help you in your journey. I hope The C# Academy will give you some direction! I’m a self-taught software developer and got my first job in my thirties, after years of relentless, daily, coding practice. Many times I felt lost. I can't complain about the amount of resources available on the internet, but it was very difficult to connect the dots. I often felt hopeless and second-guessed myself whenever I got stuck. Hence the desire to create this resource to help others who are going through the same. If you want to know more about my journey, please read <a target='_blank' href='https://www.reddit.com/r/learnprogramming/comments/o7jq75/at_39_i_just_got_an_offer_for_my_first_software/'>this Reddit post.</a>"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What to Expect",
                        ImgUrl = "icons8-in-doubt-skin-type-3-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>We won’t teach you how to code</u></i></b>. We’ll teach you how to teach yourself and nudge you in the right direction. You have to do it yourself if you want to have any chance of succeeding in a real job. Even if you hired us to be your full-time code teacher, if you don’t learn how to learn on your own you don’t have a chance in this industry."
                            },
                            new Paragraph
                            {
                                Body = $"That being said, you will have all the support needed to go from beginner to advanced. You’ll never be alone. If you get lost or stuck during your journey, you’ll always find help in our <a target='_blank' href='{discordLink}'>Discord community</a>. Here's what we can help you with: a clear pathway, feedback on your journey and community."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Community",
                        ImgUrl = "icons8-community-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = $"Have you ever heard that it takes ten thousand hours to achieve mastery? That applies to programming too. During your journey you’ll spend countless hours by yourself in front of your computer, banging your head against the wall, solving problems and creating beautiful applications. Chances are you’ll feel lonely and isolated at times. It makes a difference connecting with people that are going through the same. You’re not alone! We’re here to help. <a target='_blank' href='{discordLink}'>Join us on Discord</a> and if the link isn’t working add me and send me a personal message at <b><i><u>pablocappuccino#4729</u></i></b>. No message will be left unanswered."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Clear Pathway",
                        ImgUrl = "icons8-ambition-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s very important to have <b><i><u>clear stepping stones</u></i></b> and benchmarks as references for your work. It’s easy to feel lost in the sea of information and possibilities the web gives us. You need to give your brain a rest by laying out a pathway that will be in the back of your mind throughout your journey. Decision fatigue is exhausting and frustrating. It can undermine your progress and ultimately lead to failure."
                            },
                            new Paragraph
                            {
                                Body = "At the C# Academy you can find a roadmap with all the steps necessary to become a full stack web developer. Your progress won't be linear. There will be ups and downs and ultimately you'll learn from many sources. You’ll be constantly revisiting the previous items on the program, and close knowledge gaps. We suggest a structure but you can tailor your own experience in the academy. <a target='_blank' href='dashboard/roadmap' target='blank'>Here's the roadmap</a> (you need to be logged in to see it)."
                            },
                            new Paragraph
                            {
                                Body = "You can also tweak it and lay it out as you wish, but whatever you do, we recommend you have a list of clear steps easily accessible and if possible memorized. Without that, your journey might be derailed. There's a risk you'll jump from tutorial to tutorial, always starting the new exciting thing, while those who persist are getting the jobs."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Feedback",
                        ImgUrl = "icons8-feedback-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "As we progress through our road map, you’ll be building projects, a portfolio, a resume and preparing for interviews. We’ll give you feedback on all of those. Each of our projects have a list of requirements, but there are always details in the design, implementation and code style that are open to your own individuality. We encourage you try things on your own and we’ll only suggest corrections that are considered bad practice."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Organisation",
                        ImgUrl = "icons8-tidy-shelf-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>You need to do some housekeeping before starting</u></i></b>.  I’m sure there are messy disorganised high achievers in this world. But in my experience, creating the right environment, organising your life and your priorities and removing the clutter (mental and physical) will improve your chances of becoming a successful programmer. Here are some things to consider:"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Gear",
                        ImgUrl = "icons8-equipment-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>Get a good machine</u></i></b>. I started with a 2014 Dell. I quickly realised I needed something better and bought a 128GB 2019 Mac. About a year later I realised having Windows made things way easier for .Net development and I bought a 500GB 2020 Mac to have more space for a virtual machine. Two years later a bought a powerful HP/Windows machine so I could use the full potential of Microsoft’s tools for .NET developers.  I’m definitely not rich, but I wanted to learn to code so badly that I just worked hard and saved the money to buy it. It’s part of the “I’ll do whatever it takes” mentality."
                            },
                            new Paragraph
                            {
                                Body = "A slow machine can be a nightmare. You can absolutely achieve your goal with a bad computer, but again, your life will be much easier if you get the latest computer. Or maybe second hand, but with enough power to run at least a code editor and a database server. You DON’T NEED Windows to become a .NET developer. <b>Having a Windows machine does make things easier</b> at first, but not only it’s not necessary, but using a different operating system will also teach you important skills such as using the command line and troubleshooting the .NET environment, which will ultimately make you a better developer. "
                            },
                            new Paragraph
                            {
                                Body = "Also, I highly recommend getting an extra screen. It doesn’t need to be fancy. You just need to be able to connect it to your computer. Watching a tutorial having to close your video every time you need to code will waste a lot of your precious time. Here’s a picture of my setup when I started. I got this screen from a friend that didn’t use it anymore. Please get one for yourself, it can be second hand, it just needs to work. If it’s a large screen, even better."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "IMG_8392-768x576.jpg"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Time",
                        ImgUrl = "icons8-timetable-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>You have to carve out time in your life if you want to learn programming</u></i></b>. I admit it was easier for me because I worked from 11am so I would just woke up at 4am every day and code as much as I could."
                            },
                            new Paragraph
                            {
                                Body = "If you can do it first thing in the morning, it will be better. If you can’t, do it as soon as you get home from work. If you leave it to bed time, while not impossible, it will be really hard to focus and retain new knowledge."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>You will have to say NO to requests for your time</u></i></b>. I've sacrificed relationships because I wasn’t willing to give up my morning to spend time with anyone. My morning is sacred, it’s coding time and I would only sacrifice it for something extraordinarily serious, otherwise I would be coding. Find what your sacred time is and protect it fiercely."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>Also, track your time</u></i></b>. I’m a geek, so I track every hour of my day. You don’t need to go that far, but I suggest you track at least your coding hours. I always aimed for 28hs of programming per week. Even though I almost never achieved it, I never coded less than 20hs a week, in part due to the big goal. Start recording your results today and lay them out on a spreadsheet. Try to beat your daily, weekly and monthly records."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Notes",
                        ImgUrl = "icons8-notes-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You need to take notes. Don’t worry about taking notes about theory, unless that’s how you comprehend things. Instead, take notes about the steps you’re taking to complete a project and about errors you encountered and how you solved them. Notes should be practical and useful. You will need those in the feature. "
                            },
                            new Paragraph
                            {
                                Body = "A combination of my notes and previous projects saves me many hours of head-banging. I use <a target='_blank' href='https://roamresearch.com/'>RoamResearch</a>. I think it’s superior to anything I’ve ever used, but Evernote, Google Docs and even your computer’s notepad will do. Keep your notes organized. Other options with great reviews are <a target='_blank' href='https://www.notion.so/'>Notion</a> and <a target='_blank' href='https://obsidian.md/'>Obsidian</a>."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "One Thing At A Time",
                        ImgUrl = "icons8-to-do-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "I have a wandering mind, extreme curiosity and several areas of interest. If I don’t keep a tight leash on my mind, I'll be constantly starting new courses and projects and end up not doign anything well. I can’t stress enough the importance of doing one thing at a time."
                            },
                            new Paragraph
                            {
                                Body = "Don’t work on ten projects. <b><i><u>One at a time!</u></i></b> Actually, to be honest, I always work on two things, so If I get bored or stuck I can always jump to the other to make me feel better. But still, one of them has to be your main goal. "
                            },
                            new Paragraph
                            {
                                Body = "I know so many clever students who have been learning for a long time and have nothing to show for. No portfolio, no projects, nothing. And doing too many things is one of the reasons. "
                            },
                            new Paragraph
                            {
                                Body = "The same applies to your daily life. Don’t cram twenty tasks into your daily schedule. Do one or two big things a day and consider yourself successful for that day. My thing was always coding. If I did my four hours, I won the day. You can have a study goal and a parallel goal such as running an important errand or something. But keep it achievable. <b><i><u>You want to win your days</u></i></b>."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Mindset",
                        ImgUrl = "icons8-dreaming-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<b><i><u>I read a lot</u></i></b>. I attribute a lot of my success in my programming journey to the scope and depth that reading has given me. I understand it's hard to find time to read, but audiobooks solve this problem. You can quickly listen to a book while doing running errands or exercising. the same applies to podcasts. They can be life-changing."
                            },
                            new Paragraph
                            {
                                Body = "If you don’t have some form of input in your life, you’re missing out. In our days technology gives access to curated information easily accessible at any time. We can indirectly mentored  through podcasts, audiobooks, youtube channels. Isn't that absolutely amazing? "
                            },
                            new Paragraph
                            {
                                Body = "There are a few exceptions out there, but the vast majority of high achievers, the people who run things in this world, are avid readers. We believe books are superior to other media because you'll focus your attention on that topic for a few days or weeks. It's a type of immersion that you don't get from articles or blog posts. If you don’t like it, start liking it. It will pay off. <b><i><u>I promise</u></i></b>."
                            },
                            new Paragraph
                            {
                                Body = "There are many books I could recommend but to keep it simple, the most important are:"
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "40121378-678x1024.jpg",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<a target='_blank' href='https://amzn.to/4c1wzWK'><b><i><u>Atomic Habits</u></i></b> by James Clear</a> – It will help you to get your habits in order. Backed by many amazing anecdotes and scientific studies, if you listen to it over and over, trust me, you’ll be a better person."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "27213329-672x1024.jpg",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<a target='_blank' href='https://amzn.to/4e9KNXi'><b><i><u>Grit</u></i></b> by Angela Duckworth</a> – This book will demonstrate, also with science and anecdotes, that you should forget about the word talent. Most folks who achieve great success are the ones that <b>SHOW UP CONSISTENTLY</b> and do the hard work."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What Happens From Here",
                        ImgUrl = "icons8-where-what-quest-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = $"Once you finish reading this page, read <a target='_blank' href='/article/20000/user-guide'>The C# Academy Intro Guide</a> for a quick overview of how the academy works. Then, <a target='_blank' href='{discordLink}'>join us on Discord</a> and introduce yourself.  If the link doesn’t work, add me via my nickname: <b><i><u>pablocappuccino#4729</u></i></b>. You can use this website merely as a reference and to get project ideas here and there, or you can follow our <a target='_blank' href='/dashboard/roadmap'>Roadmap</a> (you need to be logged in to see it). If you choose to follow the pathway, you can also choose to <a href='/Account/Register' target='_blank'>register</a> so you can track your progress in <a target='_blank' href='/dashboard'>our Dashboard</a>, participate in <a target='_blank' href='/leaderboard'>our Leaderboard</a> and <b>get your code reviewed</b>. By <a target='_blank' href='/dashboard/profile'>updating your profile</a> with your LinkedIn and Github, the links will be available in the leaderboard for everyone to see, include potential recruiters. "
                            },
                            new Paragraph
                            {
                                Body = "If you really want to take your learning seriously and keep yourself accountable, we offer a VIP Membership Area, where your projects will be graded and you'll get certificates of completion of each level. In this area you can also find exclusive tutorials and detailed explanations of our projects (including all the challenges) in our <a target='_blank' href='https://thecsharpschool.getlearnworlds.com/subscription/the-c-academy-membership'>VIP Membership Area</a>. Becoming a VIP doesn't affect your progress in The C# Academy. You'll still get your code reviewed. Everything here is free and will always be free."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Final Word",
                        ImgUrl = "icons8-whispering-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want instant rewards, or if you believe you’ll start earning six figures doing something that doesn’t require a lot of effort, this isn’t for you. If you can’t stand the long hours of hard work, or if you don’t like getting stuck and taking days, sometimes weeks to fix a problem, you might not have the grit, or be passionate enough about coding to make this happen. Maybe programming isn’t for you and that’s fine. It might sound harsh but that’s the reality of what it takes to become a programmer (and I would guess, to be good at anything for that matter)."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>Most people who start learning to code quit in less than six months</u></i></b>. If you stick to it, imagine that in two years it’s highly likely you’ve got many interviews and got at least close to a job. Five years training consistently? You’ll probably not only be employed but also making very good money. Now imagine ten years consistently building stuff. The sky is the limit. And don't let anyone tell you that AI is the end of programming. It's actually just the start. 😎"
                            },
                            new Paragraph
                            {
                                Body = "I’ll let Will Smith say the final words, enjoy:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/MVVx8tzTJYg"
                            }
                        }
                    }
                }
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
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        ImgUrl= "icons8-anxious-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Every developer, no matter the experience level, gets stuck, <b>almost every day</b>. It’s very important to understand that it’s absolutely normal to spend hours, days, sometimes weeks, trying to solve one single problem. I’ve seen many programming students getting frustrated and quitting because they just don’t expect it to be this way. There’s no such thing as entering a flow state and having your project magically finished without hiccups. At least for most mortals."
                            },
                            new Paragraph
                            {
                                Body = "Every project is a bumpy road. When studying, every little thing you try to do will require some level of troubleshooting. In a professional environment, there will be a constant back-and-forth between developers, “product owners”, “quality assurance” professionals and stakeholders to make sure the requirements are being met."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Thought Patterns",
                        ImgUrl= "icons8-headache-60.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The sooner you understand that this is the nature of the work, the better. Your attitude towards these errors is the single most important factor that will determine your success. I know it can be disheartening sometimes. I’ve been stuck with errors for weeks. So what kept me going? I have two thought patterns that I trained myself to use in difficult programming situations:"
                            },
                            new Paragraph
                            {
                                Body = "1 – Quitting is not an option.<br>2 – “We have a drone on Mars”. If we are able to control a drone on Mars, <b><i><u>there is a solution</u></i></b> for whatever programming problem I’m having."
                            },
                            new Paragraph
                            {
                                Body="Remember this: <b><i><u>there is a solution</u></i></b>. It will take many years of programming to run into problems that haven’t been solved before. So if you stick to it, no matter how long it takes, you will solve it. So let’s see how we solve problems in software development."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Double Check Your Code",
                        ImgUrl= "icons8-magnifying-glass-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "When something doesn’t work in your code, the first step is to double check it. Read it carefully, word by word. There can be typos, missing words, unclosed brackets, misplaced code, a missing dependency, and the list goes on.  Often you’ll be able to fix things just by reading again with more attention."
                            },
                            new Paragraph
                            {
                                Body = "If you’re following a tutorial, check the instructor's code again. You might have also missed something. In video tutorials, sometimes the teacher will slightly change the code and you’ll miss it because of editing. With time you’ll sharpen your attention to detail and make less of these mistakes, but always keep this tool up your sleeve."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Read The Error",
                        ImgUrl= "icons8-error-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It might seem obvious, but even experienced developers sometimes just don’t read the errors the compiler provides. More often than not, the solution will be contained in the error message. Software these days is being written with special attention to error messages to help troubleshooting these issues. You’ll be surprised with how much you can solve by just carefully reading its contents."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Look It Up",
                        ImgUrl= "icons8-google-shopping-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The next step is to look your error up. Basically you have to ask google or your favourite AI tool. When you’re hired you’ll be talking to your AI assistant or searching for stuff on your favourite search engine dozens of times a day. I still remember my first day on my first job, when a senior dev was helping me with some Javascript code and he searched for something on google. It was an eye-opener. Everyone does it. It doesn’t mean lack of knowledge, it just means humans aren’t robots that have everything accessible in a hard drive in their brains. Instead, the best developers <b>simply know where to look</b>. "
                            },
                            new Paragraph
                            {
                                Body = "For the first few years of your journey, rest assure that most of your questions will have been answered before. When you run into a problem without previous answers, chances are you didn’t ask the question correctly. The best way to do it is to copy and paste your error, verbatim. Except, of course, for the part that’s specific to your application. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Post Your Question",
                        ImgUrl= "icons8-stack-overflow-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you google the problem using your own words or copying and pasting the error, you’ll quickly find out that most of these questions have been answered on <a target='_blank' href='http://stackoverflow.com/'>Stackoverflow.com</a>. Even though you’ll find answers in different resources, this is the most reliable forum for programmers. You should create an account and if you can’t fix a certain problem, post your code and you’ll get help."
                            },
                            new Paragraph
                            {
                                Body = "<a target='_blank' href='https://stackoverflow.com/users/11659311/pablo-aguirre-de-souza?tab=answers&sort=votes'>Have a look at my account on Stack Overflow</a> and you’ll see that I asked several questions when I was a beginner. Most of these questions weren’t unique. They were problems that have already been solved but I couldn’t translate them into my code. With experience you’ll be able to adapt someone else’s answers to your code, but sometimes you’ll have to post your own for someone else to have a look."
                            },
                            new Paragraph
                            {
                                Body = "Remember. <b><i><u>THERE IS A SOLUTION</u></i></b>."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Ask Someone",
                        ImgUrl= "icons8-apologise-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "More likely than not, you’ve already solved your problem by now, but if even Stack Overflow didn’t do it, you might need to ask someone. It could be a friend that has experience in the stack you’re training, or someone in our Discord community, or myself. I ask questions almost every day at work, either to the senior devs, to the QA people, to my boss, or even junior devs that have more specific domain experience. "
                            },
                            new Paragraph
                            {
                                Body = "For asking questions directly, I recommend that first you verbalise it really well. Just by doing that you might come up with the solution. Additionally, you save the person’s time because it will be easier for them to understand. Also make sure you have really exhausted every possible avenue. In a professional environment, you’ll have problems if you ask questions that are easy to look up, so it’s better to incorporate good habits right now."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Have a Break",
                        ImgUrl= "icons8-relax-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You have everything it takes. The grit, the will power, you never quit. Now sometimes that gets in the way of solving a problem. After hours trying to fix something, the best to do is probably to have a break. Going for a walk does wonders. Go to the gym, talk to someone, socialise, sleep. If you can’t do any of these things, ok, watch something on Youtube or Netflix, but generally try doing things that don’t involve a screen."
                            },
                            new Paragraph
                            {
                                Body = "Remember, looking at a problem for hours isn’t a waste of time. Your brain is piecing everything together. You’re getting familiar with the code. An unproductive day stuck with a problem is a great opportunity for learning. You learned a thousand ways it doesn’t work. And then, all of the sudden, in the middle of a break, you might have that eureka moment. Or when you get back into it, you’ll have a fresh brain and renewed perspective. Trust me, it works! "
                            }
                        }
                    }
                }
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
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        ImgUrl= "c-logo-icon-28402-1-300x288.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "So you’ve decided to start your backend journey using C#. You should be excited! .NET is a vast, powerful framework with endless tools for developers. There will always be something to learn! If you haven't yet, read <a target='_blank' href='/article/20000/user-guide'>The C# Academy Intro Guide</a> for a quick overview of how the academy works."
                            },
                            new Paragraph
                            {
                                Body = "Now there’s a bit of preparation to do. But don’t worry, if you have a decent internet connection and a minimally functioning computer, you’ll start writing code in a few hours. You do need space in your machine. If you install the .NET environment and run out of space, your experience will be painful. In that case, free some space up, upgrade your hard drive or invest in a new computer."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Editor",
                        ImgUrl= "icons8-visual-studio-2019-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The first thing you’ll need is Visual Studio (VS), which is the IDE used in most companies that use .NET C#. It’s totally possible to use other editors such as the super popular Visual Studio Code (VSC). I suggest you use VS because it’s specially designed to work with .NET, but it’s totally up to you. "
                            },
                            new Paragraph
                            {
                                Body = "However, you’ll need to watch many tutorials online to close your knowledge gaps and most of them use VS. Dealing with the project structure in .NET can be a bit confusing in the beginning, so having juggle different editors can add to the confusion. With some experience you’ll be able to use VSC or other editors if you really want to. "
                            },
                            new Paragraph
                            {
                                Body = "On the other hand, a good reason to use VSC instead would be if you have a computer that’s too slow or doesn’t have too much space. VSC is much lighter and uses less memory to run. Additionally, if you're on a Mac, VS will be retired in August, so unless you use a paid IDE such as JetBrains' Rider, you'll have to use VSC. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = ".NET Environment",
                        ImgUrl= "icons8-visual-studio-2019-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "To get started, let’s install our IDE. When installing Visual Studio, you’ll also install the .NET Standard Developer Kit. If you’re confused about things like SDK, runtime, .NET framework, etc, you’re not alone. <a href='https://stackoverflow.com/questions/47733014/whats-the-difference-between-sdk-and-runtime-in-net-core' target='blank'>Here's a stack overflow question</a> where some of these terms and tools are (somewhat) explained.<a href='https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net80?wt.mc_id=MVP_364708' target='blank'>You can also find detailed instructions on .NET installation here</a>. Click on the dropdown at the top of the page to switch operation systems."
                            },
                            new Paragraph
                            {
                                Body = "VS for Windows looks completely different from the Mac version. Make sure you follow a specific tutorial for the machine you’re using. If your machine is too slow, I highly recommend you use Visual Studio Code."
                            },
                            new Paragraph
                            {
                                Body = @"<a href='https://www.youtube.com/watch?v=nvTwDirvwIw&t=4s' target='blank'>Visual Studio for Windows</a><br>
                                         <a href='https://www.youtube.com/watch?v=r5dtl9Uq9V0' target='blank'>Visual Studio Code for Windows</a><br>
                                         <a href='https://www.youtube.com/watch?v=LXxjCNfd5b4' target='blank'>Visual Studio Code for Mac</a><br>
                                         <a href='https://www.youtube.com/watch?v=3YIADWbQFzE' target='blank'>Visual Studio Code for Linux</a><br>"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl= "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Ok, almost good to go. Now you need a source control system. This is where you’ll back up your work and share it with other people. It’s an absolute must for developers and I recommend you set it up right now. The most common source control system is Git. One of the tools invented by the genius Linus Torvalds, the creator of Linux. The most common platform is Github. <a target='_blank' href='https://www.youtube.com/watch?v=QUtk-Uuq9nE'>Here's a quick tutorial on how to create a Github account</a>."
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            },
                            new Paragraph
                            {
                                Body = "To use all the functionalities of git you should learn to use it from the command line. But for now it will be enough if you can integrate it with Visual Studio. There are many other options better visualization and management of your repositories such as Github Desktop and Sourcetree. They’re very good tools with the main purpose of dealing with Git, but for a beginner, Visual Studio 2022’s Github integration will do just fine. "
                            },
                            new Paragraph
                            {
                                Body = "But remember, professional developers need to know git from the command line. User interface tools will help but not replace the CLI. As you get comfortable with Git, create a list of commands so you’re not dependent on anyone tool."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Taking Notes",
                        ImgUrl= "icons8-google-docs-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "The last thing you need to get started is a decent note-taking system. You don’t need to go crazy on your notes. Don't let them paralyse you. I recommend you use it to optimise your time. Write lists of steps of the things you do repeatedly. Create notes with commands you keep forgetting. Create checklists for tasks that demand them."
                            },
                            new Paragraph
                            {
                                Body = "There’s an infinite amount of note taking tools out there. You could use a physical notebook. If you’re an Apple user, “Notes” app is running on ICloud, which means your computer’s notes are integrated with your phone and Ipad. The system I recommend is Google Docs. It’s free, it has plenty of space for thousands of notes, the interface is very friendly and easy to organise/visualise and you can easily share your documents or work with someone else in the same document."
                            },
                            new Paragraph
                            {
                                Body = "If you want to go fancy, try Evernote, Notion, Obsidian, or the one I use on a daily basis: <a target='_blank' href='http://roamresearch.com/'>Roamresearch.com</a>. It’s paid but it’s the best I’ve seen so far. Whatever you do, keep your notes simple and organised. Back them up and protect them with your life. "
                            }
                        }
                    }
                }
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
                ExperiencePoints = 5,
                NextSlug = "project/75/freecodecamp-certification",
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s time to start coding! Welcome to fantastic world of C#! If you haven’t yet, checkout the <a href='article/7/setting-up' target='blank'>C# Setup</a> article. You’ll need to set up your C# developer environment before starting."
                            },
                            new Paragraph
                            {
                                Body = "Now it’s time to learn the basic C# syntax. You need to be familiar with a few concepts and techniques before jumping into your first real project. The way you’ll attack this first contact with the language will depend on your learning style, but here’s my advice: Don’t try to understand <b>EVERYTHING</b> before starting to build."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "You don't need a lot to start building",
                        ImgUrl= "icons8-builder-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "One of the biggest mistakes people make when starting to code is assuming they need to know <b>A LOT</b> before building interesting things. You’ll be surprised about what you can create with basic concepts you can learn within a few hours."
                            },
                            new Paragraph
                            {
                                Body = "By all means, make lots of notes when you’re first learning to code. Go through the entire material once or twice. But that’s it! The basic syntax hasn’t and won’t change significantly across the years. You’ll have to get back to the basics many times during your journey. Everything you initially have contact with will only be internalised with <b>PRACTICE</b>. So make sure you don’t spend more than a few hours learning the basic theory."
                            },
                            new Paragraph
                            {
                                Body = "Here’s an example of your self-talk when you start your first project: '<i>Oh, what do I need to do here? I think an if-else statement will be good to get the user input. How do I write it again? I remember I saw it in the documentation, but I’m not quite sure</i>'. Then you’ll go back to your notes or the documentation, get what you need and apply in your code. You won’t know exactly how to do it, or even how it works yet, but you’ll know where to look and learn how it’s applied once you use it. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Learning With Microsoft and Free Code Camp",
                        ImgUrl= "icons8-bill-gates-100-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In 2023, Microsoft partnered up with Free Code Camp to create a <a target='blank' href='https://thecsharpacademy.com/project/75/freecodecamp-certification'>C# certification</a>. It's an excellent course, perfect for absolute beginners to get started. Experienced C# learners will also benefit from this certification as we all have knowledge gaps, no matter how long we have been learning for."
                            },

                            new Paragraph
                            {
                                Body = "We highly recommend you don't rush past the sections of this C# Certification. Read every line carefully and make notes. An effective way to write notes is writing the concepts that are new to you. Or anything that jumps to your attention. Don't write down things you already knew, as it's unlikely you'll ever touch those notes again if they aren't actually interesting."
                            },
                            new Paragraph
                            {
                                Body = "After submitting your certificate to the Academy, you'll be rewarded with <b>20 Experience Points</b>. The certification is required for students get their <b>Green Belt</b>."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Video Course",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Here’s a playlist of videos with an intro course by the C# Academy that aim to provide the foundation you need for the upcoming projects. It differs from most beginners tutorials because we don’t just teach concepts that you have no idea how to apply in a real program. We will create a desktop game so that you see how each concept is applied in the context of a real world application."
                            },
                            new Paragraph
                            {
                                Body = "In the first part of the tutorial, we will build a console app where we’ll go over all the basics you need to get started. Starting with a console app is important because you can focus purely on C#. If you jump straight into Web, Desktop or Mobile Apps, there’s a lot of overhead code and setup that will distract you from actually learning what’s necessary at this stage."
                            },
                            new Paragraph
                            {
                                Body = "But we understand that console apps aren’t very exciting. It’s nice to create something beautiful very early on, so in the second part of the tutorial we will build the same app using the state-of-the-art .NET Maui, a modern cross-platform solutin that allows us to build apps for Windows, Apple, Android and Mac using a single code base. "
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/iLByqqLGYEc"
                            },
                            new Paragraph
                            {
                                Body = "In the second part of the tutorial, you’ll again build a math game, but this time building a Desktop app, with the amazing .NET Maui. You can use the knowledge gained from this project to build an interface for all of your projects from now on. It can serve as a sandbox for you to practice your C# skills as opposed to the console."
                            }
                        }
                    },

                    new Block
                    {
                        Title = "Creating Your Library",
                        ImgUrl= "icons8-books-96-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In the <a href='article/7/setting-up' target='blank'>C# Setup</a> article , you learned you have to create your source control repository. This will be your ultimate reference book. Every piece of code you ever write should be saved there. And guess what? That will also become your tool box. You’ll constantly grab pieces of code you’ve written before to reuse in your projects. "
                            },
                            new Paragraph
                            {
                                Body = "You can also use your note taking system for that. If you keep your notes and repository organised, you’ll feel like you’re building a nice library of code and saving time not having to rewrite everything from scratch. That will allow you to look for the next, more complex challenge, which will in turn become part of your library. Imagine where you’ll get after a few years doing this."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "More Videos",
                        ImgUrl= "external-video-tutorial-online-learning-photo3ideastudio-flat-photo3ideastudio-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s great to learn from different sources. While we’re biased towards C# Academy’s beginner’s tutorial above, since it’s unique in that you learn concepts by applying them, we strongly encourage you to learn from different instructors throughout your journey. Here’s my favourite <a target='_blank' href='https://www.youtube.com/watch?v=gfkTfcpWqAY'>Beginners tutorial</a>. Mosh touches on everything you need to get started and after this video you can jump straight into the projects. <a target='_blank' href='https://www.youtube.com/playlist?list=PLLWMQd6PeGY2GVsQZ-u3DPXqwwKW8MkiP'>Tim Corey</a> is another excellent instructor to get started with."
                            },
                            new Paragraph
                            {
                                Body = "The <a target='_blank' href='https://www.youtube.com/watch?v=GhQdlIFylQ8&t=8242s'> most watched C# course</a> on Youtube is excellent but it’s 4 hours long. It might take you weeks to watch it. I suggest you don’t go through the whole thing before jumping into projects. That’s exactly the type of behaviour that makes people quit. Initially stay away from super long, comprehensive tutorials, unless you break them in pieces and mix theory with practice. "
                            },
                            new Paragraph
                            {
                                Body = "Also, use Youtube to close knowledge gaps. If there’s something you don’t get during your journey, search for that specific topic and you’ll find tutorials just about that subject. The different teaching styles and approaches will help you understand that particular area you’re having trouble with."
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 9,
                Title = "The Importance of Console Applications",
                IconUrl = "icons8-baby-app-96.png",
                Slug = "the-importance-of-console-applications",
                BannerUrl = "",
                Description = "Building console applications will allow you to focus on the back end before diving into the complexities of front-end. Here’s why.",
                Area = Area.Console,
                Level = Level.Green,
                ExperiencePoints = 5,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        ImgUrl= "icons8-command-line-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Web technologies are developing extremely fast. Websites these days are faster, more efficient, better looking and provide great user experience. When starting to learn web development, it’s easy to get tempted by all the hype of the latest frameworks. I started with Angular myself. I loved it from the moment I wrote my first component."
                            },
                            new Paragraph
                            {
                                Body = "But I quickly realised if I wanted to deal with data in the capacity I wanted, I would need to learn a back-end language. I took an approach that I find less than ideal. I dove into a bunch of tutorials about how to build full-stack apps. That made it very difficult for me to understand back-end properly. I wish I knew there was a better approach."
                            },
                            new Paragraph
                            {
                                Body = "Now I find it much more effective to build Console Apps to learn back-end. And the reason is simple: Focus. You can dedicate your full attention to your back-end language if you don’t have to worry about all the complexities of presenting data to the user in a beautiful way."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl= "icons8-console-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "That’s why I decided to make the first part of this program purely focused on Console Apps, without any front-end distractions. These apps will help progressively teach you: data types; basic control flow and syntax; dealing with databases; creating and calling APIs; Entity Framework; Repository Pattern and Unit Testing. As you can see there’s already a lot to keep you busy. "
                            },
                            new Paragraph
                            {
                                Body = "That doesn’t mean you won’t have an user interface. But instead of the website, you’ll be interacting with the user via the console line. You’ll still need to handle validation, basic presentation and all sorts of errors to provide a good user experience. And this knowledge will definitely transfer when you start creating full-stack apps."
                            },
                            new Paragraph
                            {
                                Body = "I know we all want to create fancy things as soon as possible. Even when I was creating this library of console apps, I was looking forward to going back to the latest web technologies, Maui, Blazor, Angular, Ionic, React, they are beautiful! But without a solid back-end foundation we’re very limited. The competition for a job is tough out there. You need to stack the deck in your favour. And it starts here, writing simple, clean, effective console programs. Now let’s start"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 10,
                Title = "Graduation!",
                IconUrl = "icons8-graduate-96.png",
                BannerUrl = "",
                Description = "This is your graduation from Console Apps! Find out how to start applying for jobs and what are the next steps in your coding journey.",
                Slug = "graduation",
                Area = Area.Console,
                ExperiencePoints = 5,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Congratulations",
                        ImgUrl= "hexternal-celebration-soccer-and-football-match-kosonicon-lineal-color-kosonicon-300x300.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Well done!! If you got this point, I’m sure you feel accomplished. It wasn’t easy. You were probably frustrated and disheartened at times. You felt stuck and maybe even thought of quitting. But you pushed through! And now you can proudly affirm you know the basics of back-end development with C#. How are you planning to celebrate? 🍾 You deserve it!! 😁"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What you've learned",
                        ImgUrl= "icons8-checklist-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"
✅ Basic C# Syntax and Control Flow<br>
✅ Console Application Techniques: User Input and Validation<br>
✅ Basic SQL Syntax and Crud Commands<br>
✅ Principles of MVC Design: Models, Controllers, UI, Services, Validators<br>
✅ Interaction with files in your file system<br>
✅ Calling an External Api with Http Requests<br>
✅ Entity Framework<br>
✅ Creating and calling Web APIs<br>
✅ Webscrapping <br>
✅ Sending e-mails with code<br>
✅ Fundamentals of Unit Testing<br><br>
   That's a lot!! Again... Well done!!!"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "What Happens From Here",
                        ImgUrl= "icons8-where-what-quest-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Now that you have a good understanding of the basic principles of back-end web development with C#, what’s the next step? Well, there’s a lot to do! ASP.NET is endless, but as I said before, most of what you’ll do from now on is a variation of what you’ve already done. Calling databases, getting the user input and processing data in between."
                            },
                            new Paragraph
                            {
                                Body = "The next steps in this program involve building full-stack applications with the following:"
                            },
                            new Paragraph
                            {
                                Body = @"➡️ ASP.NET MVC With Razor Syntax<br>
➡️ Securing Your App With Authorisation and Authentication With Asp.NET Identity<br>
➡️ Deploying your full-stack app with Azure, Firebase<br>
➡️ Desktop Applications With WPF and XAML<br>
➡️ Single Page Applications with Blazor<br>
➡️ Mobile Applications With Xamarin Forms (and hopefully with .NET MAUI)<br>
➡️ CRUD Applications With React<br>
➡️ CRUD Applications With Angular<br><br>
But I'll be surprised if you get to the end of this list and you don't have a job yet."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Before We Continue",
                        ImgUrl= "icons8-permanent-job-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Before we continue with our .NET C# program, I have to tell you. What you have done so far might be enough to land you a job. Yes, that’s right. The demand for C# developers is so high that a handful of console apps might suffice. "
                            },
                            new Paragraph
                            {
                                Body = "So while you learn everything else .NET has to offer, you’ll be also applying for jobs, with a decent chance of success. But we need to get organised first. You need a portfolio and a resume."
                            },
                            new Paragraph
                            {
                                Body = @"While a portfolio isn’t absolutely necessary to land you a job, it does increase your chances. You’ll read more about it in the Portfolio Area. So let’s get ready for our next three steps:<br><br>
✔️ Creating a Portfolio<br>
✔️ Creating a Resume<br>
✔️ Applying for Jobs<br>"
                            },
                            new Paragraph
                            {
                                Body = "If you don’t want to look for jobs right now, you can jump straight to the MVC Area, but I strongly recommend you still create a portfolio. Check out the portfolio project to understand why."
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 51,
                Title = "Roadmap",
                BannerUrl = "",
                Area = Area.StandAlone,
                ExperiencePoints = 5,
                Blocks = new List<Block>
                {
                      new Block
                    {
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/X7QlVcdPhxQ?si=-vzC0rfOzbjBtuX6"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "The C# Academy Full-Stack Developer Roadmap",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "I’m live proof that a progamming job can be obtained  without a college degree. I landed a job as a software engineer at a large company at the age of 39, after learning online for less than two years."
                            },
                            new Paragraph
                            {
                                Body = "One day in 2019, I was exploring possibilities of remote work. I considered teaching languages, content creation, becoming a personal assistant, and a few other options, but I quickly realised that these fields were already crowded and the average salary wasn't great. I needed a highly skilled, high in demand, well-paid skill that would lead to my financial freedom."
                            },
                            new Paragraph
                            {
                                Body = @"I found an online web developer course and in a matter of hours, I was hooked. The course had a very clear, organised curriculum and the feedback loop was immediate. Writing code and seeing the results of my work in real time was incredible. After that, the rest is history. I was addicted. Programming was in the back of my mind 24/7 for two years and now I’m employed and have a promising career ahead of me. And I believe that everyone can do it."
                            },
                            new Paragraph
                            {
                                Body = @"But enough about me. I wanted to give you some background so you realize anyone can do it. But let's move on. Before jumping onto our road map, let's examine a very important question: should you learn back-end or front-end?"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Front-end or back-end?",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you're reading this you're probably interested in learning a back-end language. But it's still a good question: when starting, which one should you learn? There's isn't an absolutely correct answer to this, but we at The C# Academy do have an opinion about it."
                            },
                            new Paragraph
                            {
                                Body = "The first criteria to make this decision is: what do you enjoy the most? Are you more interested in creating beautiful designs and a great user experience? Or you like the processing and analysis of data more? This will play a big role on your decision. Don't ignore your inclinations. It's unlikely you'll get far if you choose something you ultimately don't like."
                            },
                            new Paragraph
                            {
                                Body = "We think that you should learn both. The reason is simple. You're stacking the deck in your favor and increasing your chances of getting your foot in the door if you're able to demonstrate full-stack skills. That doesn't mean you wouldn't be able to get a job with just front-end or just back-end but it will definitely be harder."
                            },
                            new Paragraph
                            {
                                Body = "Now that you know where we stand, which one should you learn first? While starting with front-end is perfectly fine, we advocate starting with back-end because the competition for purely front-end jobs is not as fierce as for purely back-end. You'll find hundreds of applications for the latter while that's almost never the case for back-end jobs."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Learn a Back-End Language",
                        ImgUrl = "icons8-coding-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Pick any of the most used languages. Really. Don’t overthink it. Read a few articles just to see what’s out there and start learning a programming language, TODAY. You can do it for free. There are abundant beginner resources for the most common languages out there, and you can make a lot of progress without spending a cent. If you can afford a course, even better. "
                            },
                            new Paragraph
                            {
                                Body = "There are, however, a few criteria you can use to help pick a language. The main thing would be to start with a language that someone you know can help you with. I started learning Java but switched early to C# because a close friend was a senior C# developer and he was willing to help. I got unstuck many times by asking him questions and seeing him work helped me shape the way I think about code.  "
                            },
                            new Paragraph
                            {
                                Body = "Something else you have to do while thinking about your first programming language is to research what's being used in your area. It's unlikely your first programming job will be remote, so make sure the language you choose is in demand in your city or in the places you would be willing to relocate to."
                            },
                            new Paragraph
                            {
                                Body = "Another criteria is community support. Super common languages such as Python, Java, C#, Javascript and PHP have so many users that most of your questions for the first few years of learning will already have been answered online. And most of the time you’ll be looking for answers in forums, so it pays off to start with a widely-used language."
                            },
                            new Paragraph
                            {
                                Body = "You don’t need to become an expert in this first language. You’ll be able to build interesting applications with beginner knowledge and very cool stuff just getting to intermediate. And even when you get a job, you’ll keep learning this language, so don’t worry too much about trying to learn EVERYTHING about it."
                            },
                        }
                    },
                    new Block
                    {
                        Title = "Learn front-end technologies ",
                        ImgUrl = "icons8-front-end-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "I included Javascript in the back-end languages because you can do a lot of ‘under the hood’ work with JS these days, but it’s very important that you learn how to interact with a browser, so Javascript is the way to go.  "
                            },
                            new Paragraph
                            {
                                Body = "You’ll be building very interesting applications with only a little knowledge of javascript. Even if you don’t plan to become a web developer, I would still learn it so I can quickly build projects that are out in the world for people to use. Javascript will allow that."
                            },
                            new Paragraph
                            {
                                Body = @"Of course, you’ll also need to learn basic HTML and CSS, but the learning curve isn’t so steep and you can learn the basics in a matter of hours."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Build stuff",
                        ImgUrl = "icons8-builder-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Your knowledge will only be solid once you build applications. You’ll never get the knowledge necessary to succeed in an enterprise environment without creating stuff that works and works well. And I doubt you’ll get a job without it anyways."
                            },
                            new Paragraph
                            {
                                Body = "<b>Start Small</b>: In the process of learning the technologies we talked about above, you’ll be building small applications, using one or a few libraries. These small projects are very important for understanding how these things work in isolation. They should definitely be part of your library of projects."
                            },
                            new Paragraph
                            {
                                Body = @"<b>Complex Tutorials</b>: On top of that, it’s very important to build applications that involve dozens of technologies tied together. That’s a bit closer to the world of enterprise applications you’ll have to navigate when getting a job. Many tutorials have this approach, using many libraries and design patterns. "
                            },
                            new Paragraph
                            {
                                Body = @"In my view, It’s a big mistake to start with complex tutorials. Not only the chances are higher that you’ll feel overwhelmed and might end up quitting, but you might also not understand how each piece of the puzzle works before getting them to work in unison. "
                            },
                            new Paragraph
                            {
                                Body = @"If you escalate the complexity of your projects and still find yourself overwhelmed, you don’t need to quit them, just take a step back and start a little side project to understand how one of the pieces of the big tutorial work separately. Everything will make more sense after taking that step. Do it as many times as necessary until you get comfortable with all the concepts."
                            },
                            new Paragraph
                            {
                                Body = @"The first Udemy course I bought to learn Asp.Net overwhelmed me because there were so many things to learn at the same time. I ended up stepping back and approaching each subject separately and the tutorial was very useful later on, with a bit more experience in each part of that stack."
                            },
                            new Paragraph
                            {
                                Body = @" <b>Tweaking</b>:  Once you complete a complex tutorial, try to create something based on that, adding, subtracting or modifying features to suit your own needs. Think of applications you can actually use, or something you can build for someone. I recommend you build an application for someone else, as you’ll get used to the constant back and forth of feedback that happens in the real world. You’ll have to get used to another person’s needs and learn to communicate with them, which is really important for a developer. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Create a Portfolio",
                        ImgUrl = "icons8-portfolio-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "After you build your first big project, you can build a portfolio. It’s ok to just have one thing in there. You can also add a few of the other smaller ones to have some more content, but I suggest you curate your public portfolio with solid projects. You need things that will stand out and impress your recruiters. You could even have two sections, something like “Small Projects” and “Big Projects”.  "
                            },
                            new Paragraph
                            {
                                Body = "If you have just one project, you’ll feel the urge to build more. An empty portfolio will give you extra motivation to build things to fill it with. Also, you’ll inevitably raise the bar for what you’ll build, paying more attention to detail, knowing it will be out in the world for people to see. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Apply for Jobs",
                        ImgUrl = "icons8-job-seeking-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you’re consistent with your training, you should be ready to apply for jobs in six months. It could be faster or slower depending on how much time you dedicate to it, but the reality is that stage five can come faster than you imagine. You just have to free yourself from the idea that you need to get to a certain stage before applying for jobs. "
                            },
                            new Paragraph
                            {
                                Body = "The objective here isn’t to get a job as soon as you start applying. More likely than not, you’ll get a lot of rejections and that’s fine. But getting yourself out there and sending resumes will make you feel it’s real. It will force you to take a closer look at your material. You’ll scrutinise your knowledge, your projects, your portfolio, your CV. Knowing it will be looked at by recruiters will make you push yourself harder."
                            },
                            new Paragraph
                            {
                                Body = "Don’t worry too much about the job prerequisites. Apply for jobs in your two main areas of expertise: The languages you chose for front-end and back-end. There will usually be a list of other technologies and that can be disheartening. Start tackling them one by one, making small projects in each of them, and then trying to add them to your bigger projects. By the end of a year, you’ll notice that you have some experience in most items on most jobs’ list of requirements."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Don’t give up",
                        ImgUrl = "icons8-climbing-512-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "I know you’ve heard this gazillions of times: “Don’t give up and you’ll get there”. It’s obvious, but it’s true. By showing up and studying every day, you’ll get increasingly comfortable. After a few months of looking at it, the things that initially overwhelmed you will feel easy. "
                            },
                            new Paragraph
                            {
                                Body = "Spending an hour in front of the computer will be difficult for the first week, but if you push yourself a little more every day, you’ll be able to train for several hours and crave more after a few months."
                            },
                            new Paragraph
                            {
                                Body = "If you set your expectations correctly, you won’t be beaten into quitting before getting to where you want. You have to expect to be rejected many times, to have lazy days where you are unmotivated, to feel hopeless and stupid because you can’t understand a concept or a piece of code, to get stuck for weeks trying to solve an issue. These are all normal and it happens to every single programmer.  "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Enjoy the journey",
                        ImgUrl = "icons8-playing-512.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You might find out this is not for you. If after a few months, every day you dread sitting down to study, you probably don’t like it enough to keep going. And that’s perfectly fine. But you have to know that the better we get, the more motivated we’re likely to be. That’s why it’s important to start with easy small projects and get a few wins in the beginning. "
                            },
                            new Paragraph
                            {
                                Body = "After that, think that whatever happens, you’ll have fun. I just loved sitting down and coding, regardless of getting a job or not. If I never got a job, I wouldn’t think of my time as having been wasted. I learned a new skill, I learned how to learn, I grew. And I gave it a solid try. Way better than not doing anything. In the worst case scenario, you lose nothing. In the best case scenario, you get your dream job and change your life. "
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 52,
                Title = "Code Reviews",
                Area = Area.StandAlone,
                ExperiencePoints = 5,
                Slug="code-reviews",
                BannerUrl = "code-review-banner.png",
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"In this article you’ll find out how to submit code to The C# Academy for review. The objective is to make it easy for reviewers to clone and test code and submit comments directly on code. It’s also similar to the work flow used in real life production applications and will force you to get familiar with how to submit pull requests on Github. Here’s a step by step list with the process. You’ll probably need it for the first few projects and then it will become second nature."
                            },
                            new Paragraph
                            {
                                Body = @"Once your pull request is approved, your repository will be part of the C# Academy archive. The reviewers will be relatively strict with coding standards, so you'll have a good taste of the demands of the software engineering industry. Below is a video tutorial plus a list of steps on how to create a pull-request for your code to be reviewed."
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/0A5-iLbfo8k"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "1. Forking the Review Repository",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = $"Log into Github and create a fork of our review repository. Each project in the academy has a different review repository .They can be found <a href='https://github.com/stars/TheCSharpAcademy/lists/code-reviews' target='_blank'>here</a>. If you can't find a repository for a project, let us know by reaching out via our <a  target='_blank' href='{discordLink}'>Discord community</a>. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-1.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "2. Clone The Fork",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Click on the green “Code” button to see the repository name. You can click on the two-square icon to copy the repository’s address. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-3.png"
                            },
                            new Paragraph
                            {
                                Body = @"Using the command line, navigate to a folder of your choice and use the following command:<br><br>
<code>git clone your-repository-name</code>. The repository consists of a list of folders, one for each project from other students, that has been submitted, approved and merged."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "3. Create Your Project",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"Using visual studio, create a new project with the following name: 'projectName.yourGithubName' and when prompted for its location, choose the folder that was created when cloned the repository. It will inside the folder you used in step 2."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "4. Commit and Push your Changes",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"After finishing working on your project, stage, commit and push your changes to your fork. You won't be able to push your changes from your projects folder, since the repository was initiated in the parent folder. You can either open the parent folder with Visual Studio, or push your changes via the command line, from the parent folder, where you can use the following commands: <br><br>
<code>git add . <br>
git commit -m ""type your message here""<br>
git push</code>"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "5. Create a Pull Request",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Back in Github, go to your fork where you’ll see a message saying your branch is ahead of the master. Click on contribute and “Open Pull Request”. By default, the title will be the message in your last commit. You can choose to change the title or leave as it is. Then click on “Create Pull Request”. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-4.png"
                            }
                        }
                    },
                     new Block
                    {
                        Title = "6. Fix any code-analysis issues",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "\nWe're currently implementing automatic code-analysis to speed up the code review process. In some projects, after submitting a pull request, you'll see the following:"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-6.png"
                            },
                             new Paragraph
                            {
                                Body = "\nThis means your code is currently being scanned by a code-analysis tool. Wait a few minutes and you'll see if any issues have been picked up. If  no problems were found, you don't need to do anything. You'll see the following message: "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-7.png"
                            },
                             new Paragraph
                            {
                                Body = "If issues were found, you'll see the following message. Click on    the 'details' link on the right side:  "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-8.png"
                            },
                            new Paragraph
                            {
                                Body = "Another screen will be opened. Click on 'Resolve' or 'View more details on Codacy Production':"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-9.png"
                            },
                             new Paragraph
                            {
                                Body = "In the next screen you'll be able to see all pending issues. You can expand each alert to see exactly where the error is by click on the down arrow on the right side. Go back to your code, fix those errors, commit and push. Your PR will be updated automatically and the code-analysis will run again. Check if all tests passed and wait for The C# Academy to review your code."
                            },
                              new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-10.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "7. Rework your project",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Once you change your project based on the comments, all you need to do is repeat step 4 (stage, commit, push) and the pull request will be updated. You don’t need to submit another Pull request. Once your project is accepted, go to the Academy's repository where you'll see your project included."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-review-5.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Ask Questions",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = $"Dealing with source control can be cumbersome and there's a bit to learn. But it's a vital aspect of a developer's knowledge and it's important you get used to troubleshooting it, since you'll inevitably need it when working in any organization. Feel free to get help on our <a target='_blank' href='{discordLink}'>Discord community</a> if you get stuck."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Common Issues",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"<ul> 
                                       <li>Before submitting your code, make sure it follows <a href='https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions' target='_blank'>C# coding conventions</a>.</li>
                                       <li>Remove unused 'using' statements and any other code that's not being used.</li>
                                       <li>Don't write too many statements without spacing. It makes your code harder to read.</li>
                        <li>On the other hand, never have more than one empty line. Or empty lines between code and brackets.</li>
                                       <li>Use the <a href='https://www.honlsoft.com/blog/2021-06-06-new-namespace-features-in-csharp-10' target='_blank'>latest namespaces and usings</a> convention to prevent extra indentation of your classes and to write less code.</li>
                                       <li>Double check the project's requirements to make sure your project fulfils them.</li>
                                       <li>Refactor your code. You'll be surprised about how many improvements you can think of by checking your code a couple more times after completion.</li>
                                        </ul>"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 57,
                Title = "Code Review Guidelines",
                Area = Area.StandAlone,
                ExperiencePoints = 5,
                BannerUrl = "code-review-banner.png",
                Slug="review-guidelines",
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"In this article you’ll find out how to review code in The C# Academy. By reviewing other student's projects, not only you're helping them and helping our community grow, but you are becoming a better developer. When going through someone else's code, you learn different ways of doing the same thing and develop an eye for detail, an essential skill for programmers."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "1. Assign yourself to the project on your dashboard",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In your dashboard, on your right side you'll see the number of projects available for review. Click on <b>Click to See</b> or <b>Code Reviews</b> on the left side-bar to access them."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-reviewer-1.png"
                            }
                        }
                    },
                     new Block
                    {
                        Title = "2. Assign yourself to the project on the dashboard",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "You'll see a list of available projects along with the Experience Points you'll get for that review. You'll only be able to review projects from at least two belts below yours. Click on <b>Assign Myself</b> if you'd like to review that project."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-reviewer-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "3. Assign yourself to the project on Github",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = $"Click on 'View PR' on the project's card. On the new tab that will open, click on <b>assign yourself</b> on the <b>Assignees</b> area on the right side of the screen. If you're not able to click or see this option contact me on <a target='_blank' href='{discordLink}'>Discord</a> or via the e-mail <b>thecsharpacademy@gmail.com</b>"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-reviewer-3.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "4. Clone the Repository and pull the PR",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"Using the command line, clone the PROJECT'S REPOSITORY (not the Pull Request). Navigate into the project's folder and pull the PR with the following command:"
                            },

                             new Paragraph
                            {
                                Body = @"<code>git pull origin pull/pull-request-number/head</code>"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "4. Open the project",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"You can open the project via the command line navigating into its folder (the one with the format <b>studentName.projectName</b>) and typing <b>projectName.sln</b> or if there's no .sln file <b>projectName.csproj</b>. This will open Visual Studio. Alternatively you can open it via File Explorer or from Visual Studio."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "5. Make sure the project is passing code-analysis ",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If tests are passing, move on to step 6. If not, create a comment on the PR along the lines of: <b>Please fix the errors picked up by code analysis before I review your code. You can find instructions in item 6 of this article: https://www.thecsharpacademy.com/article/52/code-reviews. If you have any questions feel free to reply to this comment or reach out on Discord via the #codeReview channel</b>. Then wait for the student to fix the errors and move on to step 6. You won't get an e-mail once the student fixes the changes, so make sure you check the pull request for changes for changes."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-reviewer-4.png"
                            }
                        }
                    },
                     new Block
                    {
                        Title = "6. Review the Code",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "\nRun the project and make sure it follows all requirements Then make sure the code follows our <a href='article/58/code-conventions' target='_blank'>code conventions</a> (Code analysis doesn't pick everything up yet). If it doesn't, make a comment in the relevant areas (you can create comments by hovering over the line numbers which prompts a + button. Once that's done click on <b>Request Changes</b> and <b>Finish Review</b> (or <b>Review Changes</b>) and <b>Submit Review</b>. "
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-reviewer-5.png"
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-reviewer-6.png"
                            },
                            new Paragraph
                            {
                                Body = "\nIf the project is flawless, click on Approve. That's it, you're done. The project will be merged by The C# Academy team and you'll receive your Experience Points."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "7. Approve/request more changes",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "In case you requested changes, check the PR daily to see if there are changes after your request. If that's the case, repeat step 6 (and 7 if necessary)."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Ask Questions",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = $"It will take a few iterations before getting used to the Code Review flow. Don't hesitate to ask questions on <a target='_blank' href='{discordLink}'>Discord</a> via the #codeReview channel or reach out to me personally."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Review Manual",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"
                                     <ul> 
                                       <li>At the moment we're reviewing entry-level projects. We want the students to feel good about their journey. We want to approve their code! Keep that in mind and don't be too strict.</li>
                                       <li><b><u>Be nice</u></b>. Always use <b>please</b> when asking for a review. We want to create a supportive environment. Add an emoji if you think what you're saying might come across as blunt/direct/harsh. Words can be aggressive even if we don't want them to be and emojis are a good way to lighten the tone 😊.</li>
                                       <li>Test each functionality of the app.</li>
                                       <li>Try invalid inputs to make sure the validation works.</li>
                                       <li>It's ok if the project has MORE features than requested, but not LESS.</li>
                                       <li>Most comments will relate to spacing, unused code, unused 'usings' and general code-organization/tidiness. Often times after requesting a change, the students will have fixed most of your comments, but will forget one or two. You can approve it anyways, we don't want too much back and forth in these entry-level projects. </li>
                                       <li>The C# Academy team will 'review your review' 2-3 times to ensure you understand the process.</li>
                                       <li>It doesn't happen often, but some students will never fix their PR after you request changes. Unfortunately there isn't much we can do about it.</li>
                                     </ul>"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 58,
                Title = "Code Conventions",
                Area = Area.StandAlone,
                Slug="code-conventions",
                ExperiencePoints = 5,
                BannerUrl = "code-review-banner.png",
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"Coding conventions are a set of guidelines for a specific programming language that recommend programming style, practices, and methods for each aspect of a program written in that language. These conventions usually cover file organization, indentation, comments, declarations, statements, white space, naming conventions, programming practices, programming principles, programming rules of thumb, architectural best practices, etc. "
                            },
                             new Paragraph
                            {
                                Body = @"These are guidelines for software structural quality. Software programmers are highly recommended to follow these guidelines to help improve the readability of their source code and make software maintenance easier. Coding conventions are only applicable to the human maintainers and peer reviewers of a software project. Conventions may be formalized in a documented set of rules that an entire team or company follows or may be as informal as the habitual coding practices of an individual. Coding conventions are not enforced by compilers. (<b>This paragraph was stolen from</b> <a href='https://en.wikipedia.org/wiki/Coding_conventions' target='_blank'>Wikipedia</a>)"
                            },
                            new Paragraph
                            {
                                Body = @"You might disagree with some of these conventions and do things your own way in your personal projects. And that is perfectly fine. However we think it's important that our students abide to a certain set of standards because that's what will be required from them in companies. More often than not, especially when starting, you'll have to meet certain requirements that might be different from what you would do. That will assure the code base is consistent, which is very important for the efficiency of software development teams. "
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Microsoft Documentation's Coding Style Guide",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"Please read through <a href='https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names' target='_blank'>this guide</a>. It contains widely adopted coding style conventions widely used in the industry."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "1. Spacing",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"
                                     <ul> 
                                       <li>The first line of a file shouldn't be empty.</li>
                                       <li>No empty lines are necessary after the last closing bracket.</li>
                                       <li>Have one empty line between using statements and namespace.</li>
                                       <li>Have one empty line between namespace and class name.</li>
                                       <li>Have one empty line between methods.</li>
                                       <li>Remove empty lines after opening curly brackets and before closing curly brackets.</li>
                                       <li>Group related statements in blocks separated by an empty line. It prevents your code from looking like spaghetti.</li>    
                                     </ul>"
                            },

                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-convention-1.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "2. Remove unused code",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Remove anything that's not being used. It makes your code less readable and mantainable. In Visual Studio the compilers will tell you when code isn't being used by slightly fading it."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-convention-2.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "3. Refrain from commenting",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Code should be self-explanatory. Name your classes/methods/properties/fields so that you don't need to compensate by writing comments. Only write comments that are reminders for your future self or to let other developers know about aspects that the code can't possibly explain."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "4. Don't abbreviate",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"A variable called <b><i>getUserByIdButton</b></i> is infinitely better then one called <b><i>btn</b></i>. Be verbose so that readers don't have to guess what's going on in your code."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "5. Write less code",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"It might sound contradictory to item 4, but it's not. Verbose naming is fine. Writing unnecessary code isn't. (i.e. Don't assign variables that have a default assignment, example: int myInteger = 0 or bool myBoolean = false and use ternaries when possible)."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "6. Use the newest namespaces",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"From C# 10 we are able to ditch the namespace block and save one indentation level, which optimizes the use of space."
                            }
                            ,
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-convention-6.png"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "7. Var or Int?",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"Up to you."
                            }
                        }
                    },
                    new Block
                    {
                        Title = "8. Use string interpolation and string literals.",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = @"You can mix strings with variables elegantly using the $ sign. And you can write multiline strings verbatim using the @ sign."
                            }
                            ,
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "code-convention-7.png"
                            }
                        }
                    }
                }
            },
            new Article
            {
                Id = 20000,
                Title = "The C# Academy Intro Guide",
                IconUrl = "icons8-notes-64.png",
                Slug="user-guide",
                BannerUrl = "",
                Description = "A quick overview of how to get the most out of the academy.",
                Area = Area.StandAlone,
                ExperiencePoints = 5,
                Blocks = new List<Block>
                {
                    new Block
                    {
                        ImgUrl = "icons8-multitasking-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "There's a lot that can be done in The C# Academy. Our program is designed to let you customize your learning experience, whether you’re a complete beginner looking for a clear roadmap or an experienced developer aiming to fill in knowledge gaps. Let's explore how The C# Academy works!"
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-roadmap-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Roadmap</h3><p><p> We offer a series of projects designed to guide you from writing your first line of code to developing professional applications. Each project builds on the last, introducing new concepts and technologies. Once you register and log in, <a href='/dashboard/roadmap' target = '_blank'>you can view the roadmap here</a>. "
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-karate-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Belt System</h3><p><p> You'll notice that the roadmap is organized into levels, or belts, similar to martial arts. To advance to the next belt, you need to complete a series of tasks. On the roadmap page, you can see icons for the tasks you need to complete to advance to the next belt. Hovering over the question mark on each belt will display a list of the tasks. At the top of the page, you'll find a list of the missing tasks for the current level. "
                            }
                        }
                    },
                      new Block
                      {
                        ImgUrl = "icons8-leaderboard-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Leaderboard</h3><p><p> We also have a <a href='/leaderboard' target='_blank'>leaderboard</a>. You'll feature on the leaderboard as soon as you gain your first points. It's totally independent of the belt system. You can be at the top of the leaderboard and still be a White Belt. We've designed it this way so that you're not forced to follow the roadmap if you don't want to. We really want you to enjoy yourself! "
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-sequence-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Which Order Should You Follow?</h3><p><p>It's totally up to you. If you're a professional developer with years of experience, you might jump straight to the section that's most relevant to you. If you're following the suggested roadmap and the belt system, here's a super brief overview of the order we recommend: "
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-start-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>First Steps</h3><p><p>You'll start by reading 6 short articles: Start Here, Getting Help, Setting Up, C# Foundations, The Importance of Console Applications and this guide. We don't want to bore you with a lot of reading, so the whole thing will take you less than an hour. This preparation time will increase if you need to install a few programs."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-certification-94.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Microsoft Certification</h3><p><p>Then you'll jump onto the <a href='/project/75/freecodecamp-certification' target='_blank'>Freecodecamp Certification</a> (FCC). We warn you that many people say it can get boring. However, it provides important knowledge before you start building. And it gives you a Microsoft Certificate! We recommend you do it. If you find it unbearable, divide and conquer. Do one section a day. In parallel, get started with the Math Game. Reading the articles, completing FCC and finishing the Math Game will earn you a Green Belt."
                            }
                        }
                    },
                     new Block
                    {
                        ImgUrl = "icons8-console-64-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Console Area</h3><p><p>After this first quick win, complete the <a href='/#console-area' target='_blank'>Console Area</a> and build your <a href='/project/23/resume' target='_blank'>Resume</a> and <a href='/project/22/portfolio' target='_blank'>Portfolio</a>. This will take you all the way up to Red Belt. It's not very hard; if you create a solid study routine you can complete it in a couple of months. However, those who complete it very quickly usually have a good amount of previous programming experience. If you're an absolute beginner, give yourself some time and think of it as a marathon!"
                            }
                        }
                    },
                     new Block
                    {
                        ImgUrl = "icons8-full-stack-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Full Stack</h3><p><p>The next step is to delve into <a href='/project/23/resume' target='_blank'>Resume</a> and <a href='/#mvc-area' target='_blank'>Full Stack Development</a>. While it might seem like we're recommending you to learn ASP.NET Core front-end solutions since it's the first option after the 'Apply for Jobs' area, that's not the case. You can choose any of the following: ASP.NET Core MVC, Angular, React, Blazor, or MAUI. And we'll be including more options soon!"
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-checklist-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>More Than Projects</h3><p><p>As you go through the Roadmap, you'll notice that some levels have extra tasks, carefully designed to make you a well-rounded developer: Community Projects, Code Reviews, Code Challenges, Flagship Project. Let's see what these are about."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-users-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Community Projects</h3><p><p>As a professional developer, you'll often collaborate in teams, exploring large codebases built and maintained by various hands. We offer this experience through community projects, which you can find here. Currently, you can contribute to The C# Academy itself or to the Point of Sale project. Tasks are available for all skill levels, from fixing typos to creating entire features, so we encourage you to try these sooner rather than later. Contributing to large projects will leave you with a sense of accomplishment! While we don't officially label The C# Academy as open source since registration is required to participate, it's similar in spirit!"
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-code-review-64-1.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Code Reviews</h3><p><p>Starting from Yellow Belt, you'll also be expected to contribute through code reviews. With hundreds of projects being submitted weekly, ensuring everyone receives a thorough review is only possible with the assistance of advanced students. Not only will you be helping the academy, but you'll also benefit from the reviews, gaining more experience with git workflow and honing your communication skills. "
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-rubik-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Code Challenges</h3><p><p>With the integration of <a href='https://www.codewars.com/' target='_blank'>Codewars</a>, we offer a series of code challenges to test your knowledge in a fun way. Currently, we provide SQL puzzles, but more challenges are being prepared and will be integrated into the curriculum, including <a href='https://leetcode.com/' target='_blank'>Leetcode</a>."
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-cloud-data-66.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Cloud Development</h3><p><p>To attain a black belt, you'll also need to grasp the basics of <a href='/#cloud-area' target='_blank'>Azure Cloud Services</a>. This section will instruct you on deploying apps and databases to the cloud and constructing serverless systems. While this section might have been optional a few years ago, the current job market demands proficiency in cloud development. It's prominently featured in most job postings and empowers you to built better and more engaging systems."
                            }
                        }
                    }, 
                    new Block
                    {
                        ImgUrl = "icons8-battleship-55.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Flagship Project</h3><p><p>Last but not least, we have the <a href='/project/139/flagship-project' target='_blank'>Personal Flagship Project</a>, where you get to decide what to build. This project includes a list of features to ensure it's complex enough to be a key feature in your portfolio. However, it's designed to get you even more motivated by allowing you to work on something you're passionate about. There's ample room for creativity! We suggest you start thinking about it early in your journey. If you don't have any interesting ideas, you can use one of our existing projects and add your personal touch. There's nothing wrong with that!"
                            }
                        }
                    },
                    new Block
                    {
                        ImgUrl = "icons8-artist-100.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "<h3>Express Yourself</h3><p><p>In fact, all our projects have requirements that ensure you're learning the topics you need to become a developer. We're constantly updating them to reflect what's in demand by the industry. But beyond meeting these requirements, we suggest you always try to add your personal touch. When I started, I built several apps for things I deeply cared about: Football, languages, personal finance. I had a great time creating a Fifa World Cup app with Blazor when it was first launched. I suggest you do the same. In all projects, you can use your own business case and ideas. This concept is backed by science. People learn much better when they apply what's being studied to things they relate to and care about. Keep this in mind and you'll always be motivated!"
                            }
                        }
                    }
                }
            }
        };
    }
}
