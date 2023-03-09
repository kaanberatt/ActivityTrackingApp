using ActivityTrackingApp.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.Dtos
{
    public class UserActivityDto
    {
        [Required]
        public int EventId { get; set; }
        [Required]
        public int EventTopicId { get; set; }
    }
}
