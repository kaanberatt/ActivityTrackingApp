using ActivityTrackingApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection.Metadata;

namespace ActivityTrackingApp.DataAccess.Context;

public class ActivityTrackingDbContect : DbContext
{
  
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Event> Events{ get; set; }
    public DbSet<EventTopic> EventTopics { get; set; }
    public DbSet<EventType> EventTypes { get; set; }
    public DbSet<UserActivities> UserActivities { get; set; }
    
    
}
