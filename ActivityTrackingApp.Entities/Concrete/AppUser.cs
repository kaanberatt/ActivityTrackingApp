using ActivityTrackingApp.Entities.BaseEntity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace ActivityTrackingApp.Entities.Concrete;

public class AppUser : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Tc { get; set; }
    public int Age { get; set; }
    public string Gender{ get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }
    public string Education { get; set; }
    public DateTime BirthDate { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool EmailConfirmed { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public int AccessFailedCount { get; set; }
    public string Role { get; set; } 
    public DateTime TokenExpiryDate { get; set; }
    public string? Token { get; set; }
    public bool IsActived { get; set; }

    [NotMapped]
    public string Password { get; set; } 
    [NotMapped]
    public string FullName { get { return this.FirstName + " " + this.LastName; } }
}
