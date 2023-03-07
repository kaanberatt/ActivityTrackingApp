using ActivityTrackingApp.Entities.BaseEntity;

namespace ActivityTrackingApp.Entities.Concrete;

public class UserActivities : Entity
{
    public DateTime StartDate { get; set; }
    public DateTime FinishDate { get; set; }
    public int AppUserId { get; set; }
    public int EventId { get; set; }
    public virtual AppUser AppUser { get; set; }
    public virtual Event Event { get; set; }

}
