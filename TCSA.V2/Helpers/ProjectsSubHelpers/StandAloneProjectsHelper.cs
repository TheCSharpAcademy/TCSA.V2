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
}
