namespace TCSA.V2.Models.Responses;

public class BaseResponse
{
    public ResponseStatus Status { get; set; }
    public string Message { get; set; } = "";
}

public enum ResponseStatus
{
    Success,
    Fail
}

public class CodeWarsResponse : BaseResponse
{
    public List<CodeWarsChallenge>? Challenges { get; set; }
}

public class CodeWarsApiResponse
{
    public int totalPages { get; set; }
    public int totalItems { get; set; }
    public List<CompletedChallenge> data { get; set; }
}

public class CompletedChallenge
{
    public string id { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
    public List<string> completedLanguages { get; set; }
    public DateTime completedAt { get; set; }
}

