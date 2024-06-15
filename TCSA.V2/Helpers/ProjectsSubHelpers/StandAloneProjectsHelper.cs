using TCSA.V2.Data;
using TCSA.V2.Models;
using TCSA.V2.Models.LanguageModels;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;

internal static class StandAloneProjectsHelper
{
    private static readonly IConfiguration Configuration;
    private static readonly string DiscordLink;

    static StandAloneProjectsHelper()
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
                Id = 75,
                Title = "FreeCodeCamp C# Certification",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Get started completing this professional C# certification",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="For a long time, Microsoft has put a lot of effort into educational material for .NET and C#. There are plenty of resources in their <a href='https://learn.microsoft.com/en-au/docs/?wt.mc_id=MVP_364708' target='_blank'>technical documentation</a> and <a href='https://learn.microsoft.com/en-us/training/?wt.mc_id=MVP_364708' target='_blank'>learning platform</a>, catering to everyone from absolute beginners to senior developers seeking to improve their skills. Such an extensive library has the downside of sometimes being confusing, particularly considering the variety of technologies, their different versions over the years, and the constant evolution of .NET."
                    },
                    new Paragraph
                    {
                        Body="In August 2023, FreeCodeCamp and Microsoft teamed up to offer a single unified learning resource, providing students with a professional certification upon completion. This certification comprises a step-by-step list of topics in a curriculum provided by FreeCodeCamp, but the studying and completion of the modules occur within Microsoft's learning materials. It's a fantastic resource that prevents learners from getting lost in tutorial hell when learning the basics. "
                    }
                },
                Requirements = new List<string>
                {
                    @"You need to complete FreeCodeCamp's<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Foundational C# With Microsoft</a> certification",
                    @$"Upon completion, you need to submit the link to your project on the <a target='blank' href='/dashboard/submit-project'> project submission page</a>. Choose the certification from the project's dropdown menu and fill the textbox with the link to your certificate. If you encounter any problems, contact us <a target='_blank' href='mailto:thecsharpacademy@gmail.com'>via email</a>, along with the username/email you use to log into the academy."
                },
                Tips = new List<string>
                {
                    "You might be tempted to speed through the certification, rushing past the topics you might be familiar with. Instead, read each paragraph carefully. There are always gaps in your knowledge. We don't know what we don't know.",
                    "You don't need to complete the coding challenges in the certification to mark a section as completed. But we recommend you actually complete them, no matter how easy they are. If an exercise is too easy, try using an approach you haven't used before.",
                    "Make lots of notes, but don't fall into the trap of writing <b>everything</b> down. Notes are useful when you can have a quick glance at them for reference. A good approach is to write down concise bullet points with concepts you were not familiar with. You can also have separate notes with follow-up topics you want to study.",
                    "Although you can complete the certification in a few hours, we recommend doing each section in a different day, so you're always studying with maximum focus."
                },
                Challenges = new List<string>
                {
                    "Upon completion of your project, the next roadmap step is the <a target='_blank' href='/project/53/math-game'>Math Game</a> Try completing it without watching the video tutorial in the project's page. It might be challenging if this is your first time building something yourself but this approach will speed up your learning.",
                }
            },
             new Project
             {
                Id = 86,
                Title = "Mark Yourself As Student of The C# Academy on LinkedIn",
                IconUrl = "icons8-student-512.png",
                BannerUrl = "",
                Slug="linkedin",
                LanguageHeadings = new EnglishHeadings(),
                ExperiencePoints = 20,
                Description = "",
                Area = Area.StandAlone,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="We hope you're enjoying your learning journey with us and finding value in the projects, resources and community we provide. We believe in the power of hands-on practice and code reviews to get you on the path of becoming a great dev! We're excited to invite you to connect with us on LinkedIn through <a target='blank' href='https://www.linkedin.com/school/thecsharpacademy/'>our official school page.</a>"
                    },
                    new Paragraph
                    {
                        Body="By marking yourself as a student, you'll be helping to spread the word about the academy. The more people know about it, the better it looks in your resume! This connection allows you to showcase your dedication to learning and improving your .NET/C# skills and gain recognition for it. Additionally, it opens up opportunities to network with other students, potentially leading to valuable connections 🤓"
                    },
                     new Paragraph
                    {
                        Body="To mark yourself as a student, make sure your profile is updated with your LinkedIn url. You can view and update your profile in the dashboard. Then <a target='blank' href='https://www.linkedin.com/help/linkedin/answer/a542784'>follow these instructions</a> and submit the project <a target='_blank' href='dashboard/submit-project'>in the dashboard</a>. Please be aware that we don't have integration with Linkedin at this stage. Allow a few hours for this project to be marked as complete and receive your experience points."
                    }
                }
            },
             new Project
            {
                Id = 85,
                Title = "Complete Profile Task",
                IconUrl = "icons8-user-profile-264",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                ExperiencePoints = 20,
                Description = "Complete your profile to get extra points",
                Area = Area.StandAlone
            },
             new Project
            {
                Id = 139,
                Title = "Personal Flagship Project",
                IconUrl = "flagship.png",
                BannerUrl = "",
                Slug = "flagship-project",
                LanguageHeadings = new EnglishHeadings(),
                ExperiencePoints = 300,
                Description = "Use all your .NET/C# knowledge to build a portfolio feature",
                Area = Area.GraduationProject,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="The C# Academy's curriculum is based on relatively small projects. The principle behind this is to prevent students getting caught up in large endeavours that might take months to complete and that most of the time, at least in our experience, lead to frustration."
                    },
                    new Paragraph
                    {
                        Body="With that in mind, we also believe that it is important to build a comprehensive piece. Something that will challenge your knowledge. A project with a 'wow' factor that will truly impress prospective employers. Not only it looks great in your portfolio, but having a unique project that you're truly passionate about is a great feeling. A feeling that keeps you motivated to keep going, knowing you're building something amazing."
                    },
                    new Paragraph
                    {
                        Body="When planning for this project, try to think outside of the box. Think of something that you haven't seen before. Who knows if this might turn into a business idea? However, you don't necessarily need to build something that hasn't been built before. Do you love languages and want to build a Duolingo-like app? Perfectly fine! As long as you add your own twists to it. Do you love movies, or finance or sports, and want to built an app similar to ones you've seen in this area? Go for it! Your unique take on this subject might create something amazing based on an existing idea."
                    },
                    new Paragraph
                    {
                        Body="Shoot for the moon! Even if you don't hit it, you might reach very high 🤓"
                    }
                },
                Requirements = new List<string>
                {
                    @"Your project needs to contain a Readme with an overview of the system, justification of your choices and instructions on how to run the application. An initial PR needs to be created with this document and a diagram file (the format is up to you). This PR is a requirement to achieve Grey Belt.",
                    @"You need to build a full-stack web app with front-end, back-end and database. You can choose any front-end technology, but the back end has to be .NET/C#.",
                    @"If you have an amazing idea that doesn't require a front-end, let us know so we can assess it.",
                    @"Authorization/authentication, including at least one external provider.",
                    @"Interaction with an external api. If you don't find a free API that suits your idea, create one and seed the data",
                    @"You need to use at least two Azure Functions.",
                    @"Your project will be thoroughly tested. Make sure errors are handled properly.",
                    @"Logging and monitoring capabilities. You can choose a service of your choice.",
                    @"You need to deploy your solution to Azure and produce a link to the website."
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Planning",
                        ImgUrl = "planning.jpg",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "Before starting your project, you'll have a planning phase. You'll create a pull-request in the project's repository outlining what your app is, what features it will have and detail your tech stack. It needs to include diagrams of your database models and outline what problems you're trying to solve. Submitting this initial pull request is a requirement to achieve Grey Belt."
                            },
                            new Paragraph
                            {
                                Body = "In this phase, don't worry about being perfect. There might be a bit of back-and-forth before you get the ok to get started, so aim to have a mininum viable idea and ship it for review. We recommend you take your time to think about what you want to build. Actually undistracted, device-free thiking. Walking is great for that. We spend less and less time in our own head without having our attention grabbed. You'll be amazed with what your mind can come up with when left alone. 😊"
                            },
                             new Paragraph
                            {
                                Body = "Upon completion, your project will, with your permission, feature in a dedicated area of our website and on The C# Academy's social media accounts (Linkedin, Twitter, Instagram, Threads, Blog). You want to showcase your great achievement to the world! "
                            }
                        }
                    }
                },
                Challenges = new List<string>
                {
                    "Since this is your own idea, it won't have specific challenges. However when your first submit your code you'll be given four challenge ideas, worth 50XP each. Completion of those will take your points to a total of 500XP, as a recognition for your efforts. ",
                    "If you loved the experience of building a comprehensive project, and have lots of great ideas, you can do it again! This project will be open for completion as many times as you want. "
                },
                Tips = new List<string>
                {
                    "Check out this <a target='_blank' href='https://www.youtube.com/watch?v=m8Icp_Cid5o'>Systems Design For Beginners Tutorial</a> to have an idea of the thought processes when creating a large application. And <a target='_blank' href='https://www.youtube.com/watch?v=JvDmJybANCQ'>Mocking Diagrams with Excalidraw</a> for a cool diagram-designing tool.",
                    "We usually recommend you don't work in more than one project at a time. Since this is a comprehensive undertaking, you can work on it in parallel with the rest of the curriculum. This will be specially useful when you get stuck, as you can jump between projects to get some fresh air 😊 "
                },
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
                LanguageHeadings = new PortugueseHeadings(),
                Description = "Comece sua jornada completando a certificação profissional em C# da Microsoft",
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
                        Body="O Free Code Camp e a Microsoft uniram forças em agosto de 2023 para oferecer um recurso unificado de ensino, também providenciando aos estudantes que completarem o currículo um certificado profissional.\r\nEssa certificação contém um lista passo a passo de tópicos organizados em um currículo fornecido pela Free Code Camp, mas o estudo e conclusão dos módulos acontece dentro do portal de estudo da Microsoft.\r\nÉ um ótimo recurso e evita que estudantes se percam no mar de tutoriais que a Microsoft oferece, mantendo uma linha de aprendizado consistente. Sem mencionar outros cursos encontrados em plataformas como Udemy, youtube, entre outras."
                    }
                },
                Requirements = new List<string>
                {
                    @"Você precisa completar o curso no Free Code Camp <a target='blank' href='https://www.freecodecamp.org/portuguese/learn/foundational-c-sharp-with-microsoft/'>Fundamentos de C# com a Microsoft</a> com certificação",
                    @$"Após completar a certificação você precisará enviar uma captura de tela do seu certificado via <a target='blank' href='{DiscordLink}'> nosso servidor do discord (Code Reviews Channel)</a> ou <a target='blank' href='mailto:thecsharpacademy@gmail.com'>por E-mail"
                },
                Tips = new List<string>
                {
                    "Você talvez sinta a tentação de concluir a certificação rapidamente, pulando tópicos que pareçam familiares.\r\nAo invés disso, leia cada parágrafo com cuidado. Sempre existem lacunas em nosso conhecimento. Nós não sabemos o que não sabemos.",
                    "Você não precisa completar os desafios de código para marcar uma seção como concluída. Mas nós recomendamos que você complete eles, não importa o quão facéis sejam. Se um exercício parecer muito fácil, tente usar um método que você nunca usou antes para completá-lo.",
                    "Faça muitas anotações, mas cuidado para não cair na armadilha de anotar TUDO. Notas são úteis quando você precisa referenciar algo rapidamente. Uma boa prática é anotar pontos importantes e conceitos coms os quais você ainda não está familiarizado. Você também pode separar notas com tópicos de acompanhamento que você deseja estudar no futuro.",
                    "Embora você possa terminar a certificação em algumas horas, nós recomendamos dedicar um dia diferente para cada seção, para você estar sempre focado durante os estudos."
                },
                Challenges = new List<string>
                {
                    "Após completar a certificação, tente concluir o projeto do <a target='_blank' href='https://thecsharpacademy.com/project/53'>Jogo de matemática</a> sem assistir ao tutorial em vídeo na página do projeto. Pode ser desafior se essa é a sua primeira vez construindo algo do zero, mas essa abordagem irá acelerar seu aprendizado.",
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
                Title = "FreeCodeCamp C# Certificering",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Ga aan de slag met het behalen van deze professionele C#-certificering",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Microsoft heeft al lange tijd veel aandacht besteed aan educatief materiaal voor .NET en C#. Er zijn bronnen in hun <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>technische documentatie</a> en <a href='https://learn.microsoft.com/en-us/training/' target='blank'>leerplatform</a>, gericht op absolute beginners tot senior ontwikkelaars die hun vaardigheden willen verbeteren. Zo'n uitgebreide bibliotheek heeft het nadeel dat deze soms verward raakt, vooral als je kijkt naar de verscheidenheid aan technologieën, hun verschillende versies door de jaren heen en de constante evolutie van .NET."
                    },
                    new Paragraph
                    {
                        Body="In augustus 2023 werkten FreeCodeCamp en Microsoft samen om één uniform leermiddel aan te bieden, dat studenten na voltooiing een professionele certificering geeft. Deze certificering bestaat uit een stapsgewijze lijst met onderwerpen in een curriculum dat wordt aangeboden door FreeCodeCamp, maar het bestuderen en voltooien van de modules gebeurt binnen het leermateriaal van Microsoft. Het is een fantastische hulpbron die voorkomt dat leerlingen verdwalen in de hel van de tutorials wanneer ze de basis leren. "
                    }
                },
                Requirements = new List<string>
                {
                    @"Je moet de <a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Foundational C# With Microsoft</a>-certificering van FreeCodeCamp voltooien",
                    $@"Na voltooiing moet je een screenshot van jouw certificaat indienen via <a target='blank' href='{DiscordLink}'> onze Discord Server (Code Reviews Channel)</a> of <a target='blank' href='mailto:thecsharpacademy@gmail.com'>via e-mail</a>, samen met de gebruikersnaam/e-mailadres die je gebruikt om in te loggen op de academie."
                },
                Tips = new List<string>
                {
                    "Het kan zijn dat je in de verleiding komt om de certificering snel te doorlopen en onderwerpen waarmee u mogelijk bekend bent te overslaan. Lees elke paragraaf en geef het aandacht. Er zitten altijd gaten in je kennis. We weten niet wat we niet weten.",
                    "Je hoeft de programmeeruitdagingen  in de certificering niet te voltooien om een sectie als voltooid te markeren. Maar we raden je aan ze ook daadwerkelijk uit te voeren, hoe gemakkelijk ze ook zijn. Als een oefening te gemakkelijk is, probeer dan een aanpak die je nog niet eerder hebt gebruikt.",
                    "Maak veel aantekeningen, maar trap niet in de valkuil om ALLES op te schrijven. Notities zijn handig als je er even snel naar kunt kijken ter referentie. Een goede aanpak is om beknopte opsommingen op te schrijven met concepten waarmee je nog niet bekend was. Je kunt ook aparte notities maken met vervolgonderwerpen die je wilt bestuderen.",
                    "Hoewel je de certificering in een paar uur kunt voltooien, raden we je aan om elk onderdeel op een andere dag te doen, zodat je altijd met maximale focus studeert."
                },
                Challenges = new List<string>
                {
                    "Na voltooiing van dit project zou je het <a target='_blank' href='https://thecsharpacademy.com/project/53'>Wiskundespel</a> project kunnen voltooien zonder de video-tutorial in de projectpagina te bekijken. Het kan een uitdaging zijn als dit de eerste keer is dat je zelf iets bouwt, maar deze aanpak zal jouw leerproces zeker versnellen.",
                }
            },
        };
    }

    internal static List<Project> GetProjectsInCroatian()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 75,
                Title = "FreeCodeCamp C# Certifikat",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Započni sa polaganjem profesionalnog C# certifikata",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Microsoft već dugo vremena ulaže puno truda kreirajući edukacijski materijal za .NET i C#. Velika količina resursa nalazi se u <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>tehničkoj dokumentaciji</a> i na <a href='https://learn.microsoft.com/en-us/training/' target='blank'>platformi za učenje</a>, namijenjenih svima od aposlutnih početnika do iskusnih programera koji žele usavršiti svoje vještine. Takva opširna zbirka ponekad može zbuniti studente, posebno kad se uzme u obzir raznolikost tehnologija, različite verzije C# jezika i stalna evolucija .NET-a."
                    },
                    new Paragraph
                    {
                        Body="U kolovozu 2023. godine, FreeCodeCamp i Microsoft udružili su snage kako bi ponudili jedinstveni izvor znanja za učenje koji po završetku polaznicima dodjeljuje stručni certifikat. Certifikacija se sastoji od korak-po-korak tema organiziranih unutar FreeCodeCamp nastavnog plana, dok se proučavanje i polaganje modula odvija pomoću Microsoftovih obrazovnih materijala. Radi se o izvrsnom resursu koji pomaže polaznicima da izbjegnu \"tutorial hell\" tijekom učenja osnova programskog jezika. "
                    }
                },
                Requirements = new List<string>
                {
                    @"Potrebno je položiti FreeCodeCamp obrazovni program<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Foundational C# With Microsoft</a>",
                    $@"Nakon završetka potrebno je dostaviti screenshot certifikata putem <a target='blank' href='{DiscordLink}'> našeg Discord Servera (Code Reviews kanal)</a> ili <a target='blank' href='mailto:thecsharpacademy@gmail.com'>poslati E-mail</a>, te navesti username/email koji koristite za prijavu na stranicu C# akademije."
                },
                Tips = new List<string>
                {
                    "Možda ćete htjeti požuriti polaganje certifikata i brzo proći kroz teme s kojima već imate iskustva. Umjesto toga, pažljivo pročitajte svaki odlomak. Uvijek postoje praznine u znanju nekog područja. Ne znamo što sve ne znamo.",
                    "Nije potrebno riješiti vježbe programiranja kako bi se odjeljak označio kao dovršen. Unatoč tome preporučujemo da ih stvarno riješite, bez obzira koliko su jednostavne. Ako je vježba prejednostavna, pokušajte koristiti pristup koji do sada niste koristili.",
                    "Napravite puno bilješki, ali ne upadajte u zamku zapisivanja SVEGA. Bilješke su korisne kada ih možete brzo pregledati kao referencu. Dobar pristup je zapisivati sažete točke s konceptima s kojima niste bili upoznati. Također možete imati odvojene bilješke s temama koje želite kasnije proučiti.",
                    "Iako možete završiti certifikaciju u nekoliko sati, preporučujemo da svaki odjeljak obavite tijekom različitog dana kako biste uvijek učili s maksimalnom koncentracijom."
                },
                Challenges = new List<string>
                {
                    "Nakon završetka ovog projekta, pokušajte riješiti projekt <a target='_blank' href='https://thecsharpacademy.com/project/53'>Matematičke Igre</a> bez gledanja video tutorijala na stranicama projekta. Ako prvi puta samostalno pokušavate nešto izraditi ovo će možda biti prilično izazovno, ali će ovakav pristup ubrzati Vaše učenje.",
                }
            }
        };
    }

    internal static List<Project> GetProjectsInTurkish()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "C# Sertifikasyonu",
                IconUrl = "cards/freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Bu profesyonel C# sertifikasyon programını tamamlamaya başlayın",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Microsoft uzun bir süredir .NET ve C#'a yönelik eğitim materyalleri için büyük çaba harcıyor. <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>Teknik dokümantasyon</a> ve <a href='https://learn.microsoft.com/en-us/training/' target='blank'>öğrenme platformlarında</a>, yeni başlayanlardan becerilerini geliştirmek isteyen üst düzey yazılımcılara kadar herkes için birçok kaynak bulunmaktadır. Özellikle teknolojilerin çeşitliliği, yıllar içindeki farklı versiyonları ve .NET'in sürekli gelişimi göz önüne alındığında, bu kadar kapsamlı bir kütüphanenin bazen kafa karışıklığı yaratmak gibi olumsuz bir yanı vardır."

                    },
                    new Paragraph
                    {
                        Body="Ağustos 2023'te Free Code Camp ve Microsoft bir araya gelerek, tamamlandığında öğrencilere profesyonel sertifika veren bir öğrenim kaynağı sundular. Bu sertifikasyon, Free Code Camp tarafından sağlanan ve müfredatta adım adım ilerleyen konu listesinden  oluşmakta, ancak modüllerin çalışılması ve tamamlanması Microsoft'un öğrenme materyalleri dahilinde gerçekleşmektedir. Bu, öğrencilerin Microsoft tarafından sağlanan eğitimler denizinde ve Udemy, Youtube ve benzeri platformlarda bulunan kurslarda kaybolmasını önleyen muhteşem bir kaynaktır."
                    }
                },
                Requirements = new List<string>
                {
                    @"Free Code Camp'ta bulunan<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'>Microsoft ile temel C#</a> sertifikasyonunu tamamlamanız gerekmektedir.",
                    $@"Programı tamamladığınızda sertifikanızın ekran görüntüsünü <a target='blank' href='{DiscordLink}'> Discord sunucumuz (Code Reviews kanalı))</a> yada <a target='blank' href='mailto:thecsharpacademy@gmail.com'> E-posta </a> yolu ile göndermeniz gerekmektedir."
                },
                Tips = new List<string>
                {
                    "Aşina olabileceğiniz konuları hızlıca geçerek sertifikasyon sürecini hızlandırmak isteyebilirsiniz. Bunun yerine her paragrafı dikkatlice okuyun. Bilgilerinizde her zaman boşluklar vardır. Neyi bilmediğimizi bilmiyoruz.",
                    "Bir bölümün tamamlanmış olarak işaretlenmesi için sertifikasyondaki kodlama yarışmalarını yapmanıza gerek yok. Ancak size ne kadar kolay gelsede bunları  gerçekten tamamlamanızı öneririz. Bir alıştırma sizin için çok kolaysa, daha önce denemediğiniz bir yaklaşımla çözmeyi deneyin",
                    "Bolca notlar alın ancak HERŞEYİ yazmak gibi bir tuzağa saplanmayın. Notlar referans olarak hızlıca göz atıldığında kullanışlıdır. Aşina olmadığınız konularla ilgili kısa ve öz cümleler yazmak iyi bir yaklaşımdır. Daha sonra gözatmak istediğiniz konularla ilgili ayrı notlar da alabilirsiniz.",
                    "Sertifikasyon birkaç saatte tamamlanabilir olsada, maksimum odaklanmayı sağlamak için her bölümü farklı bir günde tamamlamanızı öneririz. \r\n"
                },
                Challenges = new List<string>
                {
                    "Sertifikasyonu  tamamladıktan sonra, video eğitimini izlemeden <a target='_blank' href='https://thecsharpacademy.com/project/53'>Matematik Oyunu</a> projesini tamamlamaya çalışın. İlk kez kendi başınıza bir şeyler geliştiriyorsanız biraz zorlanabilirsiniz, ancak bu yaklaşım öğrenmenizi hızlandıracaktır.\r\n",
                }
            },
        };
    }
    internal static List<Project> GetProjectsInKorean()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "프리코드캠프 C# 자격증",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "C# 자격증 과정을 시작해 보세요!",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="마이크로소프트(MS)는 오랜 시간 동안 .NET 및 C#에 관련된 학습자료를 제공하기 위해 많은 노력을 기울여 왔습니다. 마이크로소프트(MS)는 <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>기술 문서</a>와 <a href='https://learn.microsoft.com/en-us/training/' target='blank'>학습 플랫폼</a>을 통해 완전 코딩 초보부터 자신의 실력을 향상시키고자 하는 시니어 개발자 분들도 유용하게 쓸 수 있는 다양하고 방대한 자료들을 제공하고 있습니다. 하지만 이러한 자료들은 오히려 너무 다양하고 방대하기 떄문에 오히려 더 난해하게 느껴질 수가 있는데, 특히 .NET이 계속적으로 발전함으로 인해 연도별로 다른 버전들이 존재하고, 그로 인해 생긴 기술의 다양성을 고려할 때 더욱 더 그럴 수 있습니다."
                    },
                     new Paragraph
                    {
                        Body="그렇기 때문에 2023년 8월, 마이크로소프트(MS)는 프리코드캠프(FCC)와 협력하여 통합된 단일 교육 과정을 제공하기로 했으며 이 과정을 수료한 학생들이 별도의 전문 자격 인증서를 받을 수 있도록 하였습니다.이 자격증은 프리코드캠프(FCC)가 제공하는 형식을 따라 단계별로 또는 주제별로 학습내용을 진행할 수 있게 구성되어 있지만, 실질적으로 코딩을 배우는 모듈은 마이크로소프트(MS)의 학습 자료 내에서 진행하게 됩니다. 이는 코딩의 기초를 배우는 과정에서 초보자가 튜토리얼 지옥에 빠져 시간을 낭비하지 않고 효과적으로 코딩을 배울 수 있게 해주는 아주 매력적인 학습 과정입니다"
                    }
                },
                Requirements = new List<string>
                {
                    @"프리코드캠프(FCC)에서 제공하는 마이크로소프트(MS)의 기초 C# 자격증 과정<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'>을 완료하세요",
                    @"자격증을 발급 받은 후에는 <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'>저희 디스코드 서버(Code Reviews Channel)</a>를 통해 또는 <a target='blank' href='mailto:thecsharpacademy@gmail.com'>이메일</a>을 통해 자격증의 스크린샷을 제출해야 하며, 로그인할 때 사용하는 사용자 이름/이메일도 함께 보내주셔야 합니다."
                },
                Tips = new List<string>
                {
                    "학습 과정을 후다닥 마치고 자격증만 빨리 받고 어느정도 아는 내용은 대충 넘어가고 싶을 수도 있습니다. 그러나 모든 내용을 주의 깊게 읽어주세요. 지식에는 항상 틈새가 있습니다. 나 스스로도 내가 뭘 모르는 지를 모른다는 것입니다.",
                    "자격증 과정에서 코딩 도전과제를 풀지 않아도 괜찮습니다만 가능하면 실제로 해보는 것이 좋습니다. 도전과제가 얼마나 쉬운지에 관계없이 모든 도전 과제를 완료하는 것이 좋습니다. 과제가 너무 쉬우면 이전에 사용하지 않았던 방법을 통해 풀어볼 수 있도록 보세요.",
                    "많은 노트를 작성하되, 너무 모든 것을 노트필기하려고 하면 안됩니다. 노트필기는 참고용으로 빠르게 훑어볼 때 유용합니다. 노트필기 중 좋은 방법은 익숙하지 않은 개념을 필기하고 간결한 글머리 기호를 이용해 작성하는 것입니다. 또한 나중에 더 짚고 넘어가고 싶은 주제에 대한 별도의 메모를 작성하는 것도 좋습니다.",
                    "학습 과정을 몇 시간 만에 완료할 수도 있지만, 각 단계를 여러 날에 걸처 진행하는 것이 좋습니다. 이렇게 하면 자신의 집중력을 최대치로 끌어내서 공부할 수 있습니다."
                },
                Challenges = new List<string>
                {
                    "자격증을 발급 받은 후에는 <a target='_blank' href='https://thecsharpacademy.com/project/53'>수학 게임</a> 프로젝트를 튜토리얼 영상을 보지 않고 직접 완성해 보세요. 무작정 스스로 무언가를 만드는 것이 처음이라면 어려울 수도 있지만, 이러한 방식은 배우는 속도를 높일 수 있습니다.",
                }
            },
        };
    }

    internal static List<Project> GetProjectsInRussian()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "Сертификация C# от FreeCodeCamp",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Пройдите эту профессиональную сертификацию на C#",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="В течение долгого времени Microsoft прилагала много усилий к созданию учебных материалов для .NET и C#. Есть ресурсы в их <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>технической документации</a> и <a href='https://learn.microsoft.com/en-us/training/' target='blank'>обучающая платформа</a>, ориентированная от абсолютных новичков до опытных разработчиков, стремящихся улучшить свои навыки. Недостатком такой обширной библиотеки является то, что иногда возникает путаница, особенно если учесть разнообразие технологий, их различные версии на протяжении многих лет и постоянную эволюцию .NET."
                    },
                    new Paragraph
                    {
                        Body="В августе 2023 года FreeCodeCamp и Microsoft объединились, чтобы предложить единый унифицированный учебный ресурс, по завершении которого учащиеся получают профессиональную сертификацию. Эта сертификация включает в себя пошаговый список тем учебной программы, предоставляемой freeCodeCamp, но изучение и завершение модулей происходит в рамках учебных материалов Microsoft. Это фантастический ресурс, который не дает учащимся заблудиться в \"tutorial hell\" при изучении основ. "
                    }
                },
                Requirements = new List<string>
                {
                    @"Вам необходимо пройти сертификацию FreeCodeCamp<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Базовый C# с Microsoft",
                    $@"После завершения вам необходимо отправить скриншот вашего сертификата либо через <a target='blank' href='{DiscordLink}'> наш сервер Discord (канал проверки кода)</a>, либо <a target='blank' href='mailto:thecsharpacademy@gmail.com'>по электронной почте</a>, вместе с именем пользователя/электронной почтой, которые вы используете для входа в академию."
                },
                Tips = new List<string>
                {
                    "У вас может возникнуть соблазн ускорить прохождение сертификации, пропустив темы, с которыми вы, возможно, знакомы. Вместо этого внимательно прочитайте каждый абзац. В ваших знаниях всегда есть пробелы. Мы не знаем того, чего мы не знаем.",
                    "Вам не нужно выполнять задания по кодированию в сертификации, чтобы отметить раздел как выполненный. Но мы рекомендуем вам действительно выполнить их, какими бы простыми они ни были. Если упражнение слишком простое, попробуйте использовать подход, который вы раньше не использовали.",
                    "Делайте много заметок, но не попадайтесь в ловушку, записывая ВСЕ подряд. Заметки полезны, когда вы можете быстро просмотреть их для справки. Хороший подход - записывать краткие основные моменты с концепциями, с которыми вы не были знакомы. У вас также могут быть отдельные заметки с дополнительными темами, которые вы хотите изучить",
                    "Хотя вы можете пройти сертификацию за несколько часов, мы рекомендуем выполнять каждый раздел в другой день, чтобы вы всегда учились с максимальной сосредоточенностью"
                },
                Challenges = new List<string>
                {
                    "По завершении вашего проекта попробуйте завершить проект <a target='_blank' href='https://thecsharpacademy.com/project/53'>Math Game (Математическая игра)</a>, не просматривая видеоурок на странице проекта. Это может быть непросто, если вы впервые создаете что-то самостоятельно, но такой подход ускорит ваше обучение.",
                }
            }
        };
    }
    internal static List<Project> GetProjectsInTraditionalChinese()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "FreeCodeCamp C# 認證",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "開始來完成這項專業的 C# 認證",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Microsoft 在 .NET 和 C# 的教材方面付出長期的努力。他們的<a href='https://learn.microsoft.com/en-au/docs/' target='blank'>技術文檔</a>和<a href='https://learn.microsoft.com/en-us/training/' target='blank'>學習平台</a>，針對從初學者到尋求提升技術的高級開發人員。但這個廣泛的程式庫有些缺點和有時會令人困惑，特別是在考慮到技術的多樣性、多年來不同的版本以及 .NET 的不斷的演進。"
                    },
                    new Paragraph
                    {
                        Body="2023年8月，FreeCodeCamp和Microsoft攜手提供一個統一的學習資源，完成時可獲得專業認證。該認證由FreeCodeCamp提供課程內容的逐步主題列表構成，但模組的學習和完成是在Microsoft的教材中進行的。這是個很棒的教學資源，防止初學者迷失於雜亂的教材之中。"
                    }
                },
                Requirements = new List<string>
                {
                    @"你需要完成FreeCodeCamp的<a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> 基礎 C# 並獲得 Microsoft 認證</a>",
                    $@"完成後，請你通過<a target='blank' href='{DiscordLink}'>我們的 Discord 伺服器（程式碼檢查頻道）</a>或<a target='blank' href='mailto:thecsharpacademy@gmail.com'>電子郵件</a>提交你證書的螢幕截圖，並附上你在學院登錄時使用的用戶名/電子郵件。"
                },
                Tips = new List<string>
                {
                    "你可能會有衝動想要快些完成認證和跳過你可能已經熟悉的主題。但請不要這樣和請仔細閱讀每一段文字。因為你的知識中總是存在空隙。我們不知道自己不知道什麼。",
                    "你不需要完成認證中的編程挑戰就能標記一個部分為完成。但我們建議你實際地完成它們，無論它們有多容易。如果覺得練習太容易，試著使用另一種你以前沒有使用過的方法去完成吧。",
                    "請記錄多點的筆記，但不要陷入將每一個細節都寫下來的陷阱。當你需要用到這份筆記時，會發現簡潔的重點對筆記非常有用。一個好的方法是寫下簡潔的重點，涉及到你之前不熟悉的概念。你也可以製作單獨的筆記，記錄你想要進一步學習的主題。",
                    "雖然你可以在幾小時內完成認證，但我們建議每天專注於完成不同的部分，這樣你就能始終以最大的注意力進行學習。"
                },
                Challenges = new List<string>
                {
                    "完成項目後，請嘗試完成<a target='_blank' href='https://thecsharpacademy.com/project/53'>數學遊戲</a>項目，而無需觀看項目頁面上的視頻教程。如果這是你第一次獨立構建項目，這可能會有些挑戰，但這種方法將加快你的學習進度。",
                }
            },
        };
    }

    internal static List<Project> GetProjectsInPolish()
    {
        return new List<Project>
        {
             new Project
             {
                Id = 75,
                Title = "Certyfikacja C# od Free Code Camp ",
                IconUrl = "freecodecamp.jpg",
                Slug = "freecodecamp-certification",
                BannerUrl = "",
                LanguageHeadings = new EnglishHeadings(),
                Description = "Zdobądź profesjonalną certyfikację C#.",
                Area = Area.StandAlone,
                Level = Level.Green,
                ExperiencePoints = 20,
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Przez długi czas, Microsoft wkładał wiele wysiłku w tworzenie materiałów edukacyjnych dla .NET i C#. Ich <a href='https://learn.microsoft.com/en-au/docs/' target='blank'>dokumentacja</a> i <a href='https://learn.microsoft.com/en-us/training/' target='blank'>platforma szkoleniowa</a> oferują zasoby przeznaczone dla osób na wszystkich poziomach umiejętności - od zupełnie początkujących po doświadczonych profesjonalistów, którzy chcą rozwinąć swoje umiejętności. Wadą tak wielkiej biblioteki jest to, że czasami powoduje ona dezorientację u studentów, zwłaszcza biorąc pod uwagę różnorodność technologii, różne wersje C# na przestrzeni lat i ciągłą ewolucje platformy .NET."
                    },
                    new Paragraph
                    {
                        Body="W sierpniu roku 2023 organizacja Free Code Camp i firma Microsoft połączyły siły, aby stworzyć jednolity program nauczania, po którego ukończeniu studenci mogą uzyskać profesjonalny certyfikat. Sylabus opracowany przez Free Code Camp zawiera odpowiednio ułożoną listę tematów, natomiast nauka i zaliczanie modułów odbywają się w materiałach szkoleniowych firmy Microsoft. To fantastyczne źródło wiedzy które chroni przed zagubieniem się w “tutorial hell” podczas nauki podstaw.\r\n"
                    }
                },
                Requirements = new List<string>
                {
                    @"Musisz ukończyć certyfikację <a target='blank' href='https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Podstawy C# z Microsoftem</a>oferowaną przez Free Code Camp. ",
                    $@"Po ukończeniu, przyślij zrzut ekranu twojego certyfikatu poprzez nasz <a target='blank' href='{DiscordLink}'> serwer Discord (kanał Code Reviews) </a> lub poprzez <a target='blank' href='mailto:thecsharpacademy@gmail.com'>e-mail.</a>, wraz z twoją nazwą użytkownika/ mailem którym logujesz się do Akademii. "
                },
                Tips = new List<string>
                {
                    "Możesz mieć ochotę szybko przejść przez certyfikację, pomijając tematy z którymi jesteś już zaznajomiony. Zamiast tego, dokładnie przeczytaj każdy akapit. Zawsze istnieją luki w twojej wiedzy. Nie wiemy tego czego nie wiemy.",
                    "Ukończenie wyzwań programistycznych nie jest konieczne do oznaczenia modułu jako ukończony. Mimo to zalecamy ich wykonanie, niezależnie od ich poziomu trudności. Jeżeli jakieś ćwiczenie jest za trudne, spróbuj rozwiązać je w nowy sposób.",
                    "Pisz dużo notatek, ale nie wpadnij w pułapkę notowania WSZYSTKIEGO. Notatki są przydatne, gdy możesz szybko rzucić na nie okiem.  Dobrym podejściem jest zapisywanie zwięzłych punktów z konceptami z którymi nie jesteś jeszcze zaznajomiony. Możesz też mieć osobne notatki z tematami do dalszej nauki.",
                    "Mimo że można ukończyć certyfikację w ciągu kilku godzin, zalecamy wykonywanie każdej sekcji w innym dniu. Pozwoli to zachować maksymalną koncentrację podczas nauki."
                },
                Challenges = new List<string>
                {
                    "Po ukończeniu twojego projektu, spróbuj swoich sił z projektem <a target='_blank' href='https://thecsharpacademy.com/project/53'>Gra Matematyczna</a> nie oglądając instruktażu wideo umieszczonego na stronie internetowej. Budowanie czegoś samodzielnie po raz pierwszy może nie być łatwe, ale takie podejście przyspieszy twoją naukę.",
                }
            },
        };
    }
}