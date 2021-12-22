using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingEventsDemo.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<EventTag> EventTags {get; set;}

        public EventDbContext(DbContextOptions<EventDbContext> options)
            : base(options)
        {
        }

        //called on initial app startup and customize model config using modelbuilder instance
        //specifies that EventTag entity should have a compound key of the pair EventId and TagId
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventTag>().HasKey(et => new { et.EventId, et.TagId });
        }
    }
}
