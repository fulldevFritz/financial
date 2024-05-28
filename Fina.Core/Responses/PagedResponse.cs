using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public abstract class PagedResponse<TData> : Response<TData>
{
    // Construtores    
    public int CurrentPAge { get; set; }
    public int TotalPAges { get; set; }
}