using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Assignment1.Models
{
  public class User
  {
    [Required(ErrorMessage = "Please input a name")]
    public String Name { get; set; }
    [Required(ErrorMessage = "An email is required")]
    [EmailAddress]
    public String Email { get; set; }

    [Required(ErrorMessage = "Please input a phone number")]
    [Phone]
    public String PhoneNumber { get; set; }
    [Required(ErrorMessage = "Please specify a role")]
    public Role Role { get; set; }
  }
}
