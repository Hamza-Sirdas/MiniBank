using System.ComponentModel.DataAnnotations;
namespace MiniBank.Web.Models;

public class RegisterViewModel
{

    [Required(ErrorMessage = "Ad zorunludur.")]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;


    [Required(ErrorMessage = "Soyad zorunludur.")]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;


    [Required(ErrorMessage = "E-posta zorunludur.")]
    [EmailAddress(ErrorMessage ="Geçerli e-posta girin.")]
    public string Email { get; set; } = string.Empty;


    [Required(ErrorMessage = "Parola zorunludur.")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;


    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Parolalar eşleşmiyor.")]
    public string ConfirmPassword { get; set; } = string.Empty;


}
