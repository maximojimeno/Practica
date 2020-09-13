using Microsoft.EntityFrameworkCore;

namespace Persona.Server.Models
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions options) :base(options){}

        public DbSet<Shared.Persona> personas { get; set; }
    }
}