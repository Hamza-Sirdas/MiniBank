using System.ComponentModel.DataAnnotations;

namespace MiniBank.Web.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "E-posta zorunludur.")]
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta girin.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Parola zorunludur.")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;

    [Display(Name = "Beni hatırla")]
    public bool RememberMe { get; set; }
}