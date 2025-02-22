using System.ComponentModel.DataAnnotations;

namespace Fina.Domain.Requests.Account;

public class RegisterRequest : Request 

{
    [Required(ErrorMessage = "E-mail")]
    [EmailAddress(ErrorMessage="E-mail inválido")]

    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "Senha Inválida")]
    public string Password { get; set; } = string.Empty;
}
