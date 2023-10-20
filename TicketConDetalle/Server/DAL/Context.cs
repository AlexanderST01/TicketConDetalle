using Microsoft.EntityFrameworkCore;
using TicketConDetalle.Shared.Models;
namespace TicketConDetalle.Server.DAL
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<TicketsDetalle> TicketsDetalle { get; set; }

    }
}
