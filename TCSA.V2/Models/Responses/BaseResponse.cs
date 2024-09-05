namespace TCSA.V2.Models.Responses;

public class BaseResponse
{
    public ResponseStatus Status { get; set; }
    public string Message { get; set; } = "";
    public object? Data { get; set; }
}

public enum ResponseStatus
{
    Success,
    Fail
}

