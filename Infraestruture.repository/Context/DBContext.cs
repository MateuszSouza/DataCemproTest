using Domain.Model;
using Microsoft.EntityFrameworkCore;


namespace Infraestruture.repository.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
