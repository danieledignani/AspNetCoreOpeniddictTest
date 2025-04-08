namespace OpeniddictServer.ViewModels.Account;

using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Le password non coincidono.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Display(Name = "Scuola")]
    public string Scuola { get; set; }
}
