using ActivityTrackingApp.Entities.BaseEntity;

namespace ActivityTrackingApp.Entities.Concrete;

public class EventType : Entity
{
    // okuma , dinleme , izleme vs.
    public string Name { get; set; }

}
