using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.Dtos;

public class AppUserSignInDto
{
    [Required(ErrorMessage = "Please Enter Email")]
    [EmailAddress(ErrorMessage = "Please enter in email format.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Please Enter Password")]
    public string Password { get; set; }

}
