namespace TCSA.V2.Models.LanguageModels;

public record PortugueseHeadings : ILanguageHeadings
{
    public string Introduction => "Introdução";

    public string Requirements => "Requerimentos";

    public string Learn => "O que você irá aprender";

    public string Resources => "Recursos";

    public string Tips => "Dicas";

    public string Challenges => "Desafios";

    public string RoadmapStepCompleted => "Você completou este passo do Roadmap";

    public string PendingReview => "Este projeto está sendo revisando";

    public string ReviewRepository => "Repositório Github";
}
