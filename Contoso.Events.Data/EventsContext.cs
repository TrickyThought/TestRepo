using Contoso.Events.Models;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Events.Data
{
    /// <summary>
    /// This class represents database context for events 
    /// </summary>
    public class EventsContext : DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options) 
            : base(options)
        { }

        public DbSet<Event> Events { get; set; }
    }
}