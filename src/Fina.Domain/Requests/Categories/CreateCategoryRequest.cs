using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Requests.Categories;

public class CreateCategoryRequest : Request

{
    [Required(ErrorMessag e= "Título inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Descrição inválida")]
    Public string Description { get; set; } = string.Empty; 
}