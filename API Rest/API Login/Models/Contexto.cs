using Microsoft.EntityFrameworkCore;

namespace API_Login.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Usuario> TodoItems { get; set; }
    }
}
