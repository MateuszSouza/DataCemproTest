using Domain.Model;
using Domain.Repository;
using Infraestruture.repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestruture.repository.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DBContext _dbContext;

        public UsuarioRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Usuario GetUsuario(string email, string senha)
        {
            return _dbContext.usuarios.AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == email).Result;
            
        }
    }
}
