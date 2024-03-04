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

//public class CodeWarsResponse: BaseResponse
//{
//    public List<CodeWarsChallenge>? Challenges { get; set; }
//}
