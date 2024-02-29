using TCSA.V2.Data;
using TCSA.V2.Models;

namespace TCSA.V2.Models;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }  
    public string Description { get; set; }
    public string IconUrl { get; set; }
    public string BannerUrl { get; set; }
    public Area Area { get; set; }
    public List<Block> Blocks { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int ExperiencePoints { get; set; }
    public Level Level { get; set; }
    public bool IsClosed { get; set; }
}

public class Block
{
    public string? Title { get; set; }
    public string? ImgUrl { get; set; }
    public List<Paragraph> Paragraphs { get; set; }
}

public class Paragraph
{
    public bool IsPicture { get; set; } = false;
    public bool IsVideo { get; set; } = false;
    public string? PictureUrl { get; set; }
    public string? VideoUrl { get; set; }
    public string? Body { get; set; }
}

public enum Area
{
    HowItWorks,
    StartHere,
    Console,
    StartApplying,
    MVC,
    Angular,
    React,
    Blazor,
    MAUI,
    Azure,
    FullStack,
    StandAlone,
    OpenSource,
    MonthlyChallenge,
    SQL,
    Auth,
    GraduationProject
}

