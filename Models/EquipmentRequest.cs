using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
  public class EquipmentRequest
  {
    public User User { get; set; }
    public EquipmentType EquipmentType { get; set; }
    public String RequestDetails { get; set; }
    [Required(ErrorMessage = "Please specify a duration")]
    [Range(1, 100, ErrorMessage = "Duration must be greater than 0")]
    public int Duration { get; set; }
  }
}
