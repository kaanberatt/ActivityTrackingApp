using ActivityTrackingApp.Entities.BaseEntity;

namespace ActivityTrackingApp.Entities.Concrete;

public class Event : Entity
{
    // Spotify , Youtube , Belgesel, Kitap vs.
    public string Name { get; set; }
    public int EventTypeId { get; set; }
    public virtual EventType EventType { get; set; }
}
