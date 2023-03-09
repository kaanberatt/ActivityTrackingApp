using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.Dtos
{
    public class EventTopicDto
    {
        [Required(ErrorMessage = "Event Topic Name alanı boş olamaz")]
        public string Name { get; set; }
    }
}
