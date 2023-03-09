using ActivityTrackingApp.Core.Helper;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace ActivityTrackingApp.DataAccess.Context;

public class ActivityTrackingDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string connection = "Server=LAPTOP-C3UMDF3J;Database=ActivityTrackingDb;Integrated Security = True;";
        optionsBuilder.UseSqlServer(connection);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed data'lar oluşturuldu.

        #region Created Event Topic 
        EventTopic topic = new EventTopic()
        {
            Id = 1,
            Name = "Aksiyon",
            createdDate = DateTime.Now,
        };
        EventTopic topic2 = new EventTopic()
        {
            Id = 2,
            Name = "Bilim-Kurgu",
            createdDate = DateTime.Now,
        };
        modelBuilder.Entity<EventTopic>().HasData(topic, topic2);
        #endregion
        
        #region Created Event Type 
        EventType type1 = new EventType()
        {
            Id = 1,
            Name = "Okuma",
            createdDate = DateTime.Now,
        };
        EventType type2 = new EventType()
        {
            Id = 2,
            Name = "Dinleme",
            createdDate = DateTime.Now,
        };
        modelBuilder.Entity<EventType>().HasData(type1, type2);
        #endregion

        #region Created new AppUser
        var user1 = new AppUser()
        {
            Id = 1,
            FirstName = "Kaan Berat",
            LastName = "Tokat",
            Tc = "31112554896",
            Email = "kaan@gmail.com",
            EmailConfirmed = true,
            Phone = "05348952284",
            Education = "Üniversite",
            City = "Sakarya",
            Age = 30,
            Gender = "Erkek",
            PhoneNumberConfirmed = true,
            IsActived = true,
            Role = RoleEnums.User.ToString(),
            createdDate = DateTime.Now,
        };
        HashingHelper.CreatePasswordHash("123456Aa", out var passwordHash, out var passwordSalt);
        user1.PasswordSalt = passwordSalt;
        user1.PasswordHash = passwordHash;
        modelBuilder.Entity<AppUser>().HasData(user1);
        #endregion

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Event> Events{ get; set; }
    public DbSet<EventTopic> EventTopics { get; set; }
    public DbSet<EventType> EventTypes { get; set; }
    public DbSet<UserActivities> UserActivities { get; set; }

}
