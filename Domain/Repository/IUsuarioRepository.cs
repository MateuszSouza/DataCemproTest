using Domain.Model;

namespace Domain.Repository
{
    public interface IUsuarioRepository
    {
        public Usuario GetUsuario(string email, string senha);
    }
}