namespace TCSA.V2.Models.LangugageModels;

public record PolishHeadings : ILanguageHeadings
{
    public string Introduction => "Wprowadzenie";

    public string Requirements => "Wymagania";

    public string Learn => "Nauka";

    public string Resources => "Zasoby";

    public string Tips => "Czego się nauczysz?";

    public string Challenges => "Wyzwania";

    public string RoadmapStepCompleted => "Ukończyłeś ten etap mapy drogowej.";

    public string PendingReview => "Ten projekt czeka na zatwierdzenie";

    public string ReviewRepository => "Dokonaj przeglądu repozytorium";
}
