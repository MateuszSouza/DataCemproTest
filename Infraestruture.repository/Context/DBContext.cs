using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;


namespace Infraestruture.repository.Context
{
    public class DBContext
    {
        private NpgsqlConnection Connection;
        public DBContext(IConfiguration configuration)
        {
            Connection = new NpgsqlConnection(configuration.GetSection("ConnectionString").Value);
            Connection.Open();
        }
        public DbSet<Usuario> usuarios { get; set; }
    }
}
