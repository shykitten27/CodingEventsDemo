using Microsoft.EntityFrameworkCore;
using System;
using CodingEventsDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEventsDemo.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {

        }
    }
}
