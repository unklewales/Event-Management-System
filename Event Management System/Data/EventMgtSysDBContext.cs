using Event_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Data
{
    public class EventMgtSysDBContext : DbContext
    {
        public EventMgtSysDBContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<EventModel> Events { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
