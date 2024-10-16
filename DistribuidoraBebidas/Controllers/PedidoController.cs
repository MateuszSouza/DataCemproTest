using Domain.Token;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DistribuidoraBebidas.Controllers
{
    public class PedidoController : Controller
    {

        private readonly IMediator mediator;

        public PedidoController(IMediator mediator)
        {
            this.mediator = mediator;  
        }


        [HttpPost]
        
        public async Task<IActionResult> CreatePedido([FromBody] CreatePedidoCommand command)
        {
            if (command == null)
            {
                return BadRequest("Comando inválido");
            }

            var pedido = await mediator.Send(command);

            return CreatedAtAction(nameof(CreatePedido), new { id = pedido.Id }, pedido);
        }
    }
}
