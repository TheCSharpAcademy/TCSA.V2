namespace TCSA.V2.Models.LanguageModels;

public record EnglishHeadings : ILanguageHeadings
{
    public string Introduction => "Introduction";

    public string Requirements => "Requirements";

    public string Learn => "What you'll learn";

    public string Resources => "Resources";

    public string Tips => "Tips";

    public string Challenges => "Challenges";

    public string RoadmapStepCompleted => "You have completed this roadmap step.";

    public string PendingReview => "This Project Is Pending Review";

    public string ReviewRepository => "Review Repository";
}
