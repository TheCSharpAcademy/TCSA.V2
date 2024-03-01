using TCSA.V2.Data;
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
            new Article
            {
                Id = 5,
                Title = "Start Here",
                IconUrl = "icons8-door-80.png",
                Description = "This is your starting point. Click on the door to find out how the academy works and to read very important tips that will help you in your journey. ",
                ExperiencePoints = 5,
                Slug = "start-here",
                BannerUrl = "start-line.jpeg",
                Area = Area.StartHere,
                Level = Level.Green,
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
                                Body = "It’s great to have the opportunity to help you in your journey. I hope The C# Academy will give you some direction! I’m a self-taught software developer and got my first job in my thirties, after years of relentless, daily, coding practice. Many times I felt lost. I can't complain about the amount of resources available on the internet, but it was very difficult to connect the dots. I felt hopeless many times and second-guessed myself whenever I got stuck. Hence the desire to create this resource to help others who are going through the same. If you want to know more about my journey, please read <a target='_blank' href='https://www.reddit.com/r/learnprogramming/comments/o7jq75/at_39_i_just_got_an_offer_for_my_first_software/'>this Reddit post.</a>"
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
                                Body = "<b><i><u>We won’t teach you how to code</u></i></b>. We’ll teach you how to teach yourself and nudge you in the right direction. You have to do it yourself if you want to have any chance of succeeding in a real job. Even if you pay us a lot of money to be your full-time code teacher, if you don’t learn how to learn on your own you don’t have a chance in this industry."
                            },
                            new Paragraph
                            {
                                Body = "That being said, you will have all the support needed to go from beginner to advanced. You’ll never be alone. If you get lost or stuck during your journey, you’ll always find help in our <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a>. The things we can help you with are: a clear pathway, feedback on your journey, organization and community."
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
                                Body = "Learning how to code, you’ll spend hour upon hour by yourself, in front of your computer, banging your head against the wall, solving problems. Chances are you’ll feel lonely and isolated at times. It makes a difference connecting with people that are going through the same. You’re not alone! We’re here to help. <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Join us on Discord</a> and if the link isn’t working add me and send me a personal message at <b><i><u>pablocappuccino#4729</u></i></b>. No message will be left unanswered."
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
                                Body = "At the C# Academy you can find a roadmap with all the steps necessary to become a full stack web developer. It’s not necessarily linear and the lines between the stages are blurry. You’ll be constantly revisiting the previous items on the checklist, at any given time during your progress. <a target='_blank' href='article/51' target='blank'>Here's the roadmap</a>."
                            },
                            new Paragraph
                            {
                                Body = "You can also tweak it and lay it out as you wish, but whatever you do, I recommend you have a list of clear steps easily accessible and if possible memorized."
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
                                Body = "<b><i><u>Get a good machine</u></i></b>. I started with a 2014 Dell. I quickly realised I needed something better and bought a 128GB 2019 Mac. About a year later I realised having Windows made things way easier for .Net development and I bought a 500GB 2020 Mac to have more space for a virtual machine. Two years later a bought a powerful HP/Windows machine so I could use the full potential of Microsoft’s tools for .NET developers.  I’m not rich, I just worked hard and saved the money to buy it. It’s part of my “I’ll do whatever it takes” mentality."
                            },
                            new Paragraph
                            {
                                Body = "A slow machine can be a nightmare. You can absolutely achieve your goal with a bad computer, but again, your life will be much easier if you get the latest computer. Or something close, second hand. You DON’T NEED Windows to become a .NET developer. <b>Having a Windows machine does make things easier</b> at first, but not only it’s not necessary, but using a different operating system will also teach you important skills such as using the command line and troubleshooting the .NET environment, which will ultimately make you a better developer. "
                            },
                            new Paragraph
                            {
                                Body = "Also, I highly recommend getting an extra screen. It doesn’t need to be fancy. You just need to be able to connect it to your computer. Watching a tutorial having to close your video every time you need to code will waste a ton of your time. Here’s a picture of my setup when I started. I got this screen from a friend that didn’t use it anymore. Please get one for yourself, it can be second hand, it just needs to work. If it’s a large screen, even better."
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
                                Body = "<b><i><u>You have to carve out time in your life if you want to learn how to code</u></i></b>. I admit it was easier for me because I worked from 11am so I would just wake up at 4am every day and code as much as I could."
                            },
                            new Paragraph
                            {
                                Body = "If you can do it first thing in the morning, it will be better. If you can’t, do it as soon as you can. If you leave it to bed time, while not impossible, it will be really hard to focus and retain new knowledge."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>You will have to say NO to requests for your time</u></i></b>. I've sacrificed relationships because I wasn’t willing to give up my morning to spend time with them. My morning is sacred, it’s coding time and I would only sacrifice it for something extraordinarily serious, otherwise I would be coding. Find what your sacred time is and protect it fiercely."
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
                                Body = "A combination of my notes and previous projects saves me many hours of head-banging. I use <a target='_blank' href='https://roamresearch.com/'>RoamResearch</a>. I think it’s superior to anything I’ve ever used, but Evernote, Google Docs and even your computer’s notepad will do. Keep your notes organized."
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
                                Body = "I have a wandering mind, extreme curiosity and several areas of interest. If I don’t keep a tight leash on my mind, I jump around to the point I don’t get anything done. I can’t stress enough the importance of doing one thing at a time."
                            },
                            new Paragraph
                            {
                                Body = "Don’t work on 10 projects. <b><i><u>One at a time!</u></i></b> Actually, to be honest, I always work on two things, so If I get bored or stuck I can always jump to the other to make me feel better. But still, one of them has to be your main goal. "
                            },
                            new Paragraph
                            {
                                Body = "I know so many clever students who have been learning for a long time and have nothing to show for. No portfolio, no projects, nothing. And doing too many things is one of the reasons. "
                            },
                            new Paragraph
                            {
                                Body = "The same applies to your daily life. Don’t cram 20 tasks into your daily schedule. Do one or two big things a day and consider yourself successful for that day. My thing was always coding. If I did my four hours, I won the day. You can have a study goal and parallel goal such as running an important errand or something. But keep it achievable. <b><i><u>You want to win your days</u></i></b>."
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
                                Body = "<b><i><u>I read a lot</u></i></b>. I attribute a lot of my success in my programming journey to the scope and depth that reading has given me. Actually, I don’t read, I listen. Books and podcasts. They are absolutely life-changing."
                            },
                            new Paragraph
                            {
                                Body = "If you don’t have some form of input in your life, you’re missing out. In our days technology gives access to curated information easily accessible at any time. Indirect mentorship through podcasts, audiobooks, youtube channels. Yet some of us think that we don’t need it, we know it all."
                            },
                            new Paragraph
                            {
                                Body = "There are a few exceptions out there, but the vast majority of high achievers, the people who run things in this world, are avid readers. If you don’t like it, start liking it. It will pay off. <b><i><u>I promise</u></i></b>."
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
                                Body = "<b><i><u>Atomic Habits</u></i></b> by James Clear – It will help you to get your habits in order. Backed by many amazing anecdotes and scientific studies, if you listen to it over and over, trust me, you’ll be a better person."
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
                                Body = "<b><i><u>Grit</u></i></b> by Angela Duckworth – This book will demonstrate, also with science and anecdotes, that you should forget about the word talent. Most folks who achieve great success are the ones that <b>SHOW UP CONSISTENTLY</b> and do the hard work."
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
                                Body = "Once you finish reading this page, <a target='_blank' href='https://discord.gg/JVnwYdM79C'>join us on Discord</a> and introduce yourself.  If the link doesn’t work, add me via my nickname: <b><i><u>pablocappuccino#4729</u></i></b>. You can use this website merely as a reference and to get project ideas here and there, or you can follow the roadmap. If you choose to follow the pathway, you can also choose to <a href='Identity/Account/Register' target='_blank'>register</a> so you can track your progress on our dashboard, participate in <a target='_blank' href='/leaderboard'>our Leaderboard</a> and get your code reviewed. By updating your profile with your LinkedIn and Github, the links will be available in the leaderboard for everyone to see, include potential recruiters."
                            },
                            new Paragraph
                            {
                                Body = "We also offer 1-on-1 mentorship and detailed explanations of our projects (including all the challenges) in our <a target='_blank' href='https://thecsharpschool.getlearnworlds.com/subscription/the-c-academy-membership'>Membership Area</a> Subscribing to the VIP Membership doesn't affect your progress in The C# Academy. Everything here is free and will always be free."
                            },
                            new Paragraph
                            {
                                IsPicture = true,
                                PictureUrl = "faq4.png"
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
                                Body = "If you want instant rewards, or if you believe you’ll start earning six figures doing something that doesn’t require a lot of effort, this isn’t for you. If you can’t stand the long hours of hard work,  or if you don’t like getting stuck and taking days, sometimes weeks to fix a problem, you might not have the grit, or be passionate enough about coding to make this happen. Maybe this isn’t for you and that’s fine. It might sound harsh but that’s the reality of what it takes to become a programmer (and I would guess, to be good at anything for that matter)."
                            },
                            new Paragraph
                            {
                                Body = "<b><i><u>Most people who start learning to code quit in less than 6 months</u></i></b>. If you stick to it, imagine that in 2 years it’s highly likely you’ve got many interviews and got at least close to a job. Five years training consistently? You’ll probably not only be employed but also making very good money. Now imagine ten years consistently building stuff. I would say it’s impossible you’re not hired and earning great money."
                            },
                            new Paragraph
                            {
                                Body = "I’ll let Will Smith do the final talk, enjoy:"
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
                                Body = "Every developer, no matter the experience level, gets stuck, every single day. It’s very important to understand that it’s absolutely normal to spend hours, days, sometimes weeks, trying to solve one single problem. I’ve seen many programming students getting frustrated and quitting because they just don’t expect it to be this way. There’s no such thing as entering a flow state and having your project magically finished without hiccups. At least for most mortals."
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
                                Body = "1 – Quitting is not an option.<br>2 – “We have a drone on Mars”. If we are able to control a drone on Mars, <b><i><u>THERE IS A SOLUTION</u></i></b> for whatever programming problem I’m having."
                            },
                            new Paragraph
                            {
                                Body="Remember this: <b><i><u>THERE IS A SOLUTION</u></i></b>. It will take many years of programming to run into problems that haven’t been solved before. So if you stick to it, no matter how long it takes, you will solve it. So let’s see how we solve problems in software development."
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
                                Body = "When something doesn’t work in your code, the first step is to double check it. Read it carefully, word by word. You’ll inevitably have typos, missing words, misplaced code and often times you’ll be able to fix things just by reading again with more attention."
                            },
                            new Paragraph
                            {
                                Body = "If you’re following a tutorial, check the instructors code again. You might have also missed something. In video tutorials, sometimes the teacher will slightly change the code and you’ll miss it because of editing. With time you’ll sharpen your attention to detail and make less of these mistakes, but always keep this tool up your sleeve."
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
                                Body = "It might seem obvious, but even experienced developers sometimes just don’t read the errors. More often than not, the solution will be contained in the error message. Software these days is being written with special attention to error messages to help debugging and you’ll be surprised with how much you can solve by just carefully reading its contents."
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
                                Body = "The next step is to look your error up. Basically you have to ask google or chat gpt. When you’re hired you’ll be searching for stuff on your favourite search engine dozens of times a day. I still remember my first day on my first job, when a senior dev was helping me with some Javascript code and he searched for something on google. It was an eye-opener. Everyone does it. It doesn’t mean lack of knowledge, it just means humans aren’t robots that have everything accessible in a hard drive in their brains. Instead, the best developers know where to look. "
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
                                Body = "If you google the problem using your own words or copying and pasting the error, you’ll quickly find out that most of these questions have been answered on <a href='http://stackoverflow.com/'>Stackoverflow.com</a>."
                            },
                            new Paragraph
                            {
                                Body = "Even though you’ll find answers in different resources, this is the most reliable forum for programmers. You should create an account and if you can’t fix a certain problem, post your code and you’ll get help."
                            },
                            new Paragraph
                            {
                                Body = "<a href='https://stackoverflow.com/users/11659311/pablo-aguirre-de-souza?tab=answers&sort=votes'>Have a look at my account on stack overflow</a> and you’ll see that I asked tons of questions throughout my journey. Most of these questions weren’t unique. They were problems that have already been solved but I couldn’t translate them into my code. With experience you’ll be able to adapt someone else’s answers to your code, but sometimes you’ll have to post your own for someone else to have a look."
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
                                Body = "More likely than not, you’ve already solved your problem by now, but if even Stackoverflow didn’t do it, you might need to ask someone. It could be a friend that has experience in the stack you’re training, or someone in our community, or myself. I ask questions every day at work, either to the senior devs, to the QA people, to my boss, or even junior devs that have more specific domain experience. "
                            },
                            new Paragraph
                            {
                                Body = "For asking questions directly, I recommend that first you verbalise it really well. Just by doing that you might come up with the solution. And also you save the person’s time because it will be easier to understand. Also make sure you have really exhausted every possible avenue. In your first job, you’ll have problems if you ask questions that are easy to look up, so it’s better to incorporate good habits right now."
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
                                Body = "Remember, looking at a problem for hours isn’t a waste of time. Your brain is piecing everything together. You’re getting familiar with the code. An unproductive day stuck with a problem is really a great opportunity for learning. You learned a thousand ways it doesn’t work. And then, all of the sudden, in the middle of a break, you might have that Eureka moment. Or when you get back into it, you’ll have a fresh brain and renewed perspective. Trust me, it works! "
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
                                Body = "So you’ve decided to start your backend journey using C#. You should be excited! .NET is a vast, powerful framework with endless tools for developers. There will always be something to learn!"
                            },
                            new Paragraph
                            {
                                Body = "Now there’s a bit of preparation to do. But don’t worry, if you have a decent internet connection and a minimally functioning computer, you’ll start writing code in a few hours. You do need space in your computer. If you install the .NET environment and run out of space, your experience will be painful. In that case, free some space, upgrade your hard drive or invest in a new computer."
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
                                Body = "The first thing you’ll need is Visual Studio, which is the IDE used in most companies that use .NET C#. It’s totally possible to use other editors such as the super popular Visual Studio Code. I suggest you use Visual Studio because it’s specially designed to work with .NET, but it’s totally up to you. "
                            },
                            new Paragraph
                            {
                                Body = "However, you’ll need to watch many tutorials online to close your knowledge gaps and most of them use Visual Studio. Dealing with the project structure in .NET can be a bit confusing in the beginning, so having juggle different editors can add to the confusion. With some experience you’ll be able to use Visual Studio Code or other editors if you really want to. "
                            },
                            new Paragraph
                            {
                                Body = "On the other hand, a good reason to use Visual Studio Code instead would be if you have a computer that’s too slow or doesn’t have too much space. Visual Studio Code is way lighter and needs less memory to run."
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
                                Body = "To get started, let’s install our IDE. When installing Visual Studio, you’ll also install the .NET Standard Developer Kit. If you’re confused about things like SDK, runtime, .NET framework, etc, you’re not alone. <a href='https://stackoverflow.com/questions/47733014/whats-the-difference-between-sdk-and-runtime-in-net-core' target='blank'>Here's a stack overflow question</a> where some of these terms and tools are (somewhat) explained."
                            },
                            new Paragraph
                            {
                                Body = "Visual Studio for Windows looks completely different from the Mac version. Make sure you follow a specific tutorial for the machine you’re using. If your machine is too slow, I highly recommend you use Visual Studio Code."
                            },
                            new Paragraph
                            {
                                Body = "If you opt for Visual Studio, go for the 2022 version on Windows and the 2019 version on Mac, since the 2022 for Mac is only a preview (as of August 2022).  Below are links to resources to install VS and VSC on all machines."
                            },
                            new Paragraph
                            {
                                Body = @"<a href='https://www.youtube.com/watch?v=nvTwDirvwIw&t=4s' target='blank'>Visual Studio for Windows</a><br>
                                         <a href='https://www.youtube.com/watch?v=KMXm43LVNeY&t=36s' target='blank'>Visual Studio for Mac</a><br>
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
                                Body = "Ok, almost good to go. Now you need a source control system. This is where you’ll back up your work and share it with other people. It’s an absolute must for developers and I recommend you start looking into it straight away. The most common source control system is Git. One of the tools invented by the genius Linus Torvalds, the creator of Linux. The most common platform is Github. <a target='_blank' href='https://www.youtube.com/watch?v=QUtk-Uuq9nE'>Here's a quick tutorial on how to create a Github account</a>."
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
                                Body = "The last thing you need is a decent note-taking system. You don’t need to go crazy on your notes. It might slow you down too much. I recommend you use it to optimise your time. Write lists of steps of the things you do repeatedly. Create notes with commands you keep forgetting. Create checklists for tasks that demand them. "
                            },
                            new Paragraph
                            {
                                Body = "There’s an infinite amount of note taking tools out there. You could use a physical notebook. If you’re an Apple user, “Notes” app is running on ICloud, which means your computer’s notes are integrated with your phone and Ipad. The system I recommend is Google Docs. It’s free, it has plenty of space for thousands of notes, the interface is very friendly and easy to organise/visualise and you can easily share your documents or work with someone else in the same document."
                            },
                            new Paragraph
                            {
                                Body = "If you want to go fancy, try Evernote or the one I use on a daily basis: <a target='_blank' href='http://roamresearch.com/'>Roamresearch.com</a>. It’s paid but it’s the best I’ve seen so far. Whatever you do, keep your notes simple and organised. Back them up and protect them with your life. "
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
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Introduction",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "It’s time to start coding! Welcome to fantastic world of C#! If you haven’t yet, checkout the <a href='article/7' target='blank'>C# Setup</a> article. You’ll need to set up your C# developer environment before starting."
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
                                Body = "In 2023, Microsoft partnered up with Free Code Camp to create a <a target='blank' href='https://thecsharpacademy.com/project/75'>C# certification</a>. It's an excellent course, perfect for absolute beginners to get started. Experienced C# learners will also benefit from this certification as we all have knowledge gaps, no matter how long we have been learning for."
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
                                Body = "In the <a href='article/7' target='blank'>C# Setup</a> article , you learned you have to create your source control repository. This will be your ultimate reference book. Every piece of code you ever write should be saved there. And guess what? That will also become your tool box. You’ll constantly grab pieces of code you’ve written before to reuse in your projects. "
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
        };
    }
}
