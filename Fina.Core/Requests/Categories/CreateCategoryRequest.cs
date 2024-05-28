using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Titulo invalido")]
    [MaxLength(80, ErrorMessage = "O titulo deve conter")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descricao invalida")]
    public string Description { get; set; } = string.Empty;

}