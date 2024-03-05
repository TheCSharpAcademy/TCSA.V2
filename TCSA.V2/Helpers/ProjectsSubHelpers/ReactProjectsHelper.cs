using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;
internal static class ReactProjectsHelper
{
    internal static List<Project> GetProjects ()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 35,
                Title = "Tic-Tac-Toe",
                IconUrl = "icons8-tic-tak-toe-cross-and-circle-matrix-game-with-work-strategy-concept-384.png",
                BannerUrl = "",
                Slug = "tic-tac-toe",
                Description = "A very simple project to easy you into with this rich framework. You’ll be consuming an Api of your choice",
                Area = Area.React,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to React, the most popular front-end framework in the world. The hype isn’t unwarranted. React is truly a joy to work with. Building components and managing application state is made extremely easy by these guys and you’ll be building very cool apps in no time with this tool."
                    },
                    new Paragraph
                    {
                        Body="Right now (August 2022), I still consider a better idea to learn Angular first, since there are way too many React developers out there competing for jobs. And The C# Academy doesn’t have an opinion about which one is better. They’re both great, and ideally, we should learn both. And of course, if in your area there are more React jobs than Angular, go for it!"
                    },
                    new Paragraph
                    {
                        Body="In this project, you’ll build a Tic-tac-toe game with the help of the React Docs tutorial. I know, one of my pet-peeves is the insistence in learning through a useless game, particularly Tic-tac-toe. That doesn’t resemble anything you’ll work with in real life. "
                    },
                    new Paragraph
                    {
                        Body = "However, I have to admit, it’s a great tutorial. Truly beginner friendly. And it does have an interesting feature that lets you back previous moves. With this tutorial, you’ll be ready to jump into more interesting stuff right away."
                    }
                },
                RequirementsIntro = "This project has only one requirement. You’ll build a Tic-Tac-Toe game following React’s documentation. The objective at this stage isn’t to modify it or do anything fancy with it. Right now all you need to do is learn the basics. And there’s a lot to learn. So stick to the tutorial and take your time studying each line of code.",

                Resources = new List<string>
                {
                    "<a target='_blank' href='https://reactjs.org/tutorial/tutorial.html'>React Tic-Tac-Toe Tutorial</a>",
                    "<a target='_blank' href='https://reactjs.org/docs/getting-started.html'>React Documentation</a>",
                    "<a target='_blank' href='https://codersera.com/blog/why-learning-reactjs-makes-sense-in-2020/'>Article: Why Learn React in 2022?</a>"
                },
                ResourcesConclusion = "Since this is your first React project, make sure you look up everything you don’t know. Try not to let any keyword, method or concept left-behind. This is the moment to build your foundation. And don’t forget to reach out on our <a target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> if you have questions!\r\n\r\nHere’s my github repository for this project, where you can find branches for each stage of the development of this game. To navigate through the branches, choose from the dropdown as per the picture below: ",
                Tips = new List<string>
                {
                    "Take your time to study each word in the code. This isn't time to rush, but to learn at a slow pace, with patience.",
                    "Take notes, write diagrams. React has completely new concepts to us such as hooks and state management and drawing can be very helpful.",
                    "Once your app is complete, I strongly suggest you redo it and try to add some styling. If you're confused after your first go, it's crucial you go back and start from scratch.",
                    "If you want to take it a step further you could try to build another game. Sudoku? Checkers?"
                }
            },
            new Project
            {
                Id = 36,
                Title = "Call an External API",
                IconUrl = "icons8-baby-app-96.png",
                BannerUrl = "",
                Slug = "call-external-api",
                Description = "Build a simple Get Endpoint with .NET and fetch data from it using React",
                Area = Area.React,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Congratulations! You’ve finished your first React App. It was probably easy. After all, React’s documentation is excellent. It’s at the same time thorough but easy to follow. So let’s complicate things a little. "
                    },
                     new Paragraph
                    {
                        Body="It’s time for you to combine a React App to a .NET WebAPI. Since this is the first time you’re doing it, we will keep it simple. We will only be showing data coming from the API via Get requests. This will reinforce what you’ve learned in the first app, and will exercise your creativity. Oh, and by the way, we will also be training .NET Web Apis again. Let’s go!"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should present data coming from a .NET WebAPI using React.",
                    "Your application can only have GET requests.",
                    "You cannot use AXIOS to fetch the data, you have to use JS Fetch API",
                    "You should create an API of your choice, with a model representing a single table.",
                    "One of the properties of your API's model should be imageUrl, with a link to pictures that will be shown by the react app.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "Your app needs to have a list of records and a page to visualise an individual record.",
                    "Your app should show a 'Loading Data...' message while the request hasn't been completed.",
                    "If there's a server error, the user should be informed."
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://www.freecodecamp.org/news/fetch-data-react/'>How to fetch data with React</a>",
                    "<a target='_blank' href='https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0'>Enabling CORS (Cross Origin Resource Sharing) in .NET Web API</a>",
                    "<a target='_blank' href='https://stackoverflow.com/questions/65082452/cors-is-not-working-with-net-core-api-and-angular-frontend'>Dealing With CORS errors (Stack Overflow)</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=DTBta08fXGU'>Handling Fetch API errors in React</a>",
                },
                ResourcesConclusion = "Connecting to an API using Fetch JS is incredibly easy. But chances are you’ll find a cross-origin error. Don’t forget to visit these links to solve it. ",
                Tips = new List<string>
                {
                    "This app should be relatively easy to build. Try not to over complicate it.",
                    "If you want to add extra features, think of: pagination, filters and the ability to create a list of 'favourite' records.",
                    "Think of a project that has plenty of good images online and keep it simple. Examples: Dogs, Cats, Movies, Cars, Athletes, Singers, Bands, Drinks.",
                    "<a target='_blank' href='https://github.com/public-apis/public-apis'>Another variation of this project would be to call a public api. Click to view a massive list.</a>"
                }
            },
            new Project
            {
                Id = 37,
                Title = "Shopping List",
                IconUrl = "icons8-shopping-list-512.png",
                BannerUrl = "",
                Slug = "shopping-list",
                Description = "Build your first full CRUD app with React, calling a .NET Web API",
                Area = Area.React,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="It’s time to advance in your React knowledge by creating a full CRUD application with a .NET backend. This time you’ll also need a full CRUD .NET web API, so you get some extra practice in that as well. We’re recommending you stick to the basics and don’t use Redux (a popular state management library used in React). Its learning curve can be quite steep and you’re still taking baby-steps in React. You’ll also have a greater appreciation of Redux if you make a few apps without it first. "
                    }
                },
                Requirements = new List<string>
                {
                    "This is a CRUD Shopping List App with React and .NET Web API .",
                    "Users should be able to cross items from the shopping-list without deleting them. You can use a IsPickedUp boolean for that.",
                    "You should create two projects: A .NET WebApi and a React app.",
                    "You can choose whatever database solution you want: Sqlite, SQL server or whatever you're comfortable with.",
                    "You can choose whatever ORM you want: Dapper, EF, ADO.NET.",
                    "To keep it simple, don't create a project that allows multiple shopping lists.",
                    "Your database should have a single \"ShoppingListItems\" table. The objective is to focus on React, so we should avoid the complexities of relational data.",
                    "You CANNOT use Axios or Redux."


                },
                ResourcesIntro = "The resources from the previous projects will be helpful in the completion of this project, plus this tutorial:",

                Resources = new List<string>
                {
                    "<a target='_blank' href='https://www.freecodecamp.org/news/fetch-data-react/'>Crud React Tutorial Example</a>"
                },
                ResourcesConclusion = "This is just an example of a tutorial where a React app uses it’s inbuilt Http client to call an api. However React is one of the most popular libraries out there, so feel free to search for other examples. ",
                Tips = new List<string>
                {
                    "Start by building the complete CRUD .NET Webapi",
                    "In your second step, make sure you can call the get method from the API using React. Once the data is flowing between apps, everything else becomes easier."
                }
            },
            new Project
            {
                Id = 38,
                Title = "Friends Manager",
                IconUrl = "icons8-friend-512.png",
                BannerUrl = "",
                Slug = "friends-manager",
                Description = "Build an app that will help you monitor and cultivate your friendships managing state with Redux",
                Area = Area.React,
                ExperiencePoints = 100,
                Difficulty = Difficulty.Beginner,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In this project we will manage our friendships. This won’t be just a contact book. It will be an app where we will keep track of the people we consider REAL friends. The main objective is to keep track of how much attention we’re giving to our friends. So not only we will have our friends details, but also data about our frequency of communication with them. "
                    },
                     new Paragraph
                    {
                        Body="We will be dealing with a more advanced way of managing state in React. We will use Redux to keep a central state management system so you don’t have to pass it around using props and pointer functions. Managing state with props is ok for small projects, but as soon as our system have more than a few layers, it can quickly get messy. Managing state in a central location will reduce the amount of code and make debugging much easier. Not to mention the visualization of the data pathways within our app. "
                    }
                },
                Requirements = new List<string>
                {
                    "In this app you'll keep data about the friendships you want to cultivate.",
                    "You can choose which properties you want to have in your \"Friend\" model, except that you need to have a \"LastContactDate\" and a \"LastContactType\" and a \"Desired Contact Frequency\" properties",
                    "You're also required to have a \"Category\" table, which will be linked to your \"Friends\" table by a foreign key.",
                    "Users should be able to easily visualize the friends that are getting the least attention (i.e. Last contact date has been longer than desired contact frequency)",
                    "When adding a new friend, the form should contain a dropdown with the Category.",
                    "You need to use Redux for state management.",
                    "You need to handle validation and server errors."
                },
                ResourcesIntro = "Adding onto the resources of our previous React projects, you’ll need to find out how to use Redux:",
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://react-redux.js.org/tutorials/quick-start'>React-Redux Quick Guide</a>",
                    "<a target='_blank' href='https://www.valentinog.com/blog/redux/'>Beginners Redux: Complete Guide</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=hXpYQqykORU'>React Redux Crud App (Youtube).</a>"
                },
                ResourcesConclusion = "Angular Material can be tricky at first, but trust us, you’ll learn to love it and once you master it, you will never look back. But as always, reach out in our <a  target='_blank' href='https://discord.gg/JVnwYdM79C'>Discord community</a> if you get stuck!",
                Tips = new List<string>
                {
                    "You won't find many tutorials of React-Redux with C# Web Api. But with the knowledge of the previous React projects you should be able to setup the required front-end and call a C# server.",
                    "Initially don't worry about styling. Make sure everything is working as intended first and add styles in the end.",
                    "Since you're new to Redux, you might need to create a \"stepping stone\" project where your only focus is to learn redux with a very simple app (i.e. todo list)."
                },
                Challenges = new List<string>
                {
                    "Once this project is done, I highly recommend you create two forks for two different ways of managing state: Context API, and Recoil.",
                    "Find a way to get an e-mail sent to user with warnings such as : You haven't contacted John in 14 days!"
                }
            },
        };
    }
}
