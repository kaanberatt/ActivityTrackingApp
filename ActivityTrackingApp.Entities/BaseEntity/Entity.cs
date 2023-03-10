using System.ComponentModel.DataAnnotations;

namespace ActivityTrackingApp.Entities.BaseEntity;

public class Entity : IEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime createdDate { get; set; }
    public DateTime? updatedDate { get; set; }
}
