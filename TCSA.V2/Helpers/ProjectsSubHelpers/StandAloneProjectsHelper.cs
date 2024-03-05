using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Helpers.ProjectsSubHelpers;

internal static class StandAloneProjectsHelper
{
    internal static List<Project> GetProjects ()
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
             new Project
            {
                Id = 86,
                Title = "Mark Yourself As Student of The C# Academy on LinkedIn",
                IconUrl = "icons8-student-512.png",
                BannerUrl = "",
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
                        Body="To mark yourself as a student, make sure your profile is updated your LinkedIn url. You can view and update your profile in the dashboard. Then <a target='blank' href='https://www.linkedin.com/help/linkedin/answer/a542784'>follow these instructions</a> and click on the <b>Submit For Review</b> button below. Please be aware that we don't have integration with Linkedin at this stage. Allow a few hours for this project to be marked as complete and receive your experience points."
                    }
                }
            },
             new Project
            {
                Id = 85,
                Title = "Complete Profile Task",
                IconUrl = "icons8-user-profile-264",
                BannerUrl = "",
                ExperiencePoints = 20,
                Description = "Complete your profile to get extra points",
                Area = Area.StandAlone
            },
        };
    }
    internal static List<Project> GetProjectsInPortuguese ()
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
                    @"Após completar a certificação você precisará enviar uma captura de tela do seu certificado via <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> nosso servidor do discord (Code Reviews Channel)</a> ou <a target='blank' href='mailto:thecsharpacademy@gmail.com'>por E-mail"
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

    internal static List<Project> GetProjectsInDutch ()
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
                    @"Na voltooiing moet je een screenshot van jouw certificaat indienen via <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> onze Discord Server (Code Reviews Channel)</a> of <a target='blank' href='mailto:thecsharpacademy@gmail.com'>via e-mail</a>, samen met de gebruikersnaam/e-mailadres die je gebruikt om in te loggen op de academie."
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

    internal static List<Project> GetProjectsInCroatian ()
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
                    @"Nakon završetka potrebno je dostaviti screenshot certifikata putem <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> našeg Discord Servera (Code Reviews kanal)</a> ili <a target='blank' href='mailto:thecsharpacademy@gmail.com'>poslati E-mail</a>, te navesti username/email koji koristite za prijavu na stranicu C# akademije."
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

    internal static List<Project> GetProjectsInTurkish ()
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
                    @"Programı tamamladığınızda sertifikanızın ekran görüntüsünü <a target='blank' href='https://www.cfreecodecamp.org/learn/foundational-c-sharp-with-microsoft/'> Discord sunucumuz (Code Reviews kanalı))</a> yada <a target='blank' href='mailto:thecsharpacademy@gmail.com'> E-posta </a> yolu ile göndermeniz gerekmektedir."
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
    internal static List<Project> GetProjectsInKorean ()
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

}
