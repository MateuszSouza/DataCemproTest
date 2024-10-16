using MediatR;

namespace Domain.Login
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}