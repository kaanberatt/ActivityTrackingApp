using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.Dtos;

public class AppUserSignInDto
{
    [Required(ErrorMessage = "Lütfen e-posta adresinizi boş geçmeyiniz.")]
    [EmailAddress(ErrorMessage = "Lütfen uygun formatta e-posta giriniz.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Lütfen şifre alanını boş geçmeyiniz.")]
    public string Password { get; set; }

}
