using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.Dtos
{
    public class EventTypeDto
    {
        [Required(ErrorMessage = "Please enter the name")]
        public string Name { get; set; }
    }
}
