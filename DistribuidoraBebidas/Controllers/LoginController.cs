using Domain.Login;
using Domain.Token;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DistribuidoraBebidas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly TokenService _tokenService;

        public LoginController(IMediator mediator, TokenService tokenService)
        {
            this.mediator = mediator;
            _tokenService = tokenService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public ActionResult<string> Login([FromBody] LoginRequest request)
        {
            var response = mediator.Send(request).Result;
            if (string.IsNullOrEmpty(response.Token))
            {
                return Ok(JsonConvert.SerializeObject(response));
            }
            return Unauthorized(JsonConvert.SerializeObject(response));
        }
    }
}