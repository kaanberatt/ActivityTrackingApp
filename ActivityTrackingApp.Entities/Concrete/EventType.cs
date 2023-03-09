using ActivityTrackingApp.Entities.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.Concrete;

public class EventType : Entity
{

    // okuma , dinleme , izleme vs.
    public string Name { get; set; }

}
