using Microsoft.EntityFrameworkCore;
using TarjetaApi.Models;

namespace TarjetaApi.Data
{
    public class TarjetaContext : DbContext
    {
        public TarjetaContext(DbContextOptions<TarjetaContext> options)
            : base(options)
        {
        }

        public DbSet<Persona> Persona { get; set; }
    }
}