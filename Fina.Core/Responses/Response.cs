using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class Response<TData>
{
    private int code = 200;
    private readonly int _code;

    public Response() => _code = 200;

    public Response(TData? data,
        int code = 200,
        string? message = null )
    {
        Data = data;
        _code = code;
        Message = message;
    }

    public object? Data { get; set; }
    public string? Message { get; set; }

    [JsonIgnore]
    public bool IsSuccess => code is >= 200 and <= 299;
    
}