using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.Dtos;

public class EventDto
{
    [Required(ErrorMessage = "Please Enter The Event Name")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please enter the Event Type Id")]
    public int EventTypeId { get; set; }
}
