using ActivityTrackingApp.Entities.BaseEntity;

namespace ActivityTrackingApp.Entities.Concrete;

public class Event : Entity
{
    // Spotify , Youtube , Belgesel, Kitap vs.
    public string Name { get; set; }
    public string EventTopicId { get; set; }
    public string EventTypeId { get; set; }
    public virtual EventTopic EventTopic { get; set; }
    public virtual EventType EventType { get; set; }
}
