namespace TCSA.V2.Helpers;

public class Enums
{
    public enum CardType
    {
        Article,
        Project,
        Card
    }

    public enum Language
    {
        English,
        Portuguese,
        Dutch,
        Turkish,
        Korean,
        Croatian,
        Russian,
        TraditionalChinese,
        Polish
    }

    public enum DashboardState
    {
        Area,
        Pending,
        Completed
    }

    public enum ProjectStatus
    {
        Pending,
        Completed,
        None
    }

    public enum AlertType
    {
        Primary,
        Secondary,
        Success,
        Danger,
        Warning,
        Info,
        Light,
        Dark,
        TCSA
    }
}
