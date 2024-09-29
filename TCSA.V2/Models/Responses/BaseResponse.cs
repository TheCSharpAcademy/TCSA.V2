﻿namespace TCSA.V2.Models.Responses;

public class BaseResponse
{
    public ResponseStatus Status { get; set; }
    public string Message { get; set; } = string.Empty;
}

public class BaseResponse<T>
{
    public ResponseStatus Status { get; set; }
    public string Message { get; set; } = string.Empty;
    public T? Data { get; set; }
}

public enum ResponseStatus
{
    Success,
    Fail
}

