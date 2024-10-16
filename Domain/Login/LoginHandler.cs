using Domain.Model;
using Domain.Repository;
using Domain.Token;
using MediatR;

namespace Domain.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        public IUsuarioRepository loginRepository { get; set; }
        public TokenService tokenService { get; set; }

        public LoginHandler(TokenService tokenService, IUsuarioRepository loginRepository)
        {
            this.tokenService = tokenService;
            this.loginRepository = loginRepository;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            Usuario usuario = loginRepository.GetUsuario(request.Email, request.Senha);
            LoginResponse response;
            if (IsValid(usuario, request.Senha))
            {
                var token = tokenService.GeradorDeToken(usuario);
                response = new LoginResponse
                {
                    Token = token,
                    Code = "200",
                    Message = string.Empty
                };
                return response;
            }

            response = new LoginResponse
            {
                Code = "401",
                Message = "Usuario ou senha incoretos",
                Token = string.Empty
            };
            return response;
        }

        private bool IsValid(Usuario usuario, string senha)
        {
            if (usuario is not null)
            {
                if (usuario.Senha.Equals(senha))
                    return true;
            }
            return false;
        }
    }
}