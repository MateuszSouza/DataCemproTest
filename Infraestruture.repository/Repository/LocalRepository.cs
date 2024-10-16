using Domain.Model;
using Domain.Repository;

namespace Infraestruture.repository.Repository
{
    public class LocalRepository : IUsuarioRepository
    {
        private LinkedList<Usuario> usuarios;

        public LocalRepository()
        {
            usuarios = new LinkedList<Usuario>();
            usuarios.AddLast(new Usuario
            {
                Email = "Josias@Email.com",
                Nome = "Josias",
                Nivel = "Gerente",
                Senha = "JosiasSenha"
            });
            usuarios.AddLast(new Usuario
            {
                Email = "Josi@Email.com",
                Nome = "Josi",
                Nivel = "Vendedor",
                Senha = "JosiSenha"
            });
        }

        public Usuario GetUsuario(string email, string senha)
        {
            return usuarios.FirstOrDefault(u => u.Email.Equals(email));
        }
    }
}