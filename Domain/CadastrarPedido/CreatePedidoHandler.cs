using Domain.Cadastrar;
using Domain.Model;
using Domain.Repository;
using MediatR;

namespace Domain.CadastrarPedido
{
    public class CreatePedidoHandler : IRequestHandler<CreatePedidoCommand, PedidoResponse>
    {
        private readonly IPedidoRepository _pedidoRepository;
        public CreatePedidoHandler(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public Task<PedidoResponse> Handle(CreatePedidoCommand request, CancellationToken cancellationToken)
        {
            var perdido = new Pedido
            {
                DataEmissao = request.DataEmissao,
                PedidoItem = request.PedidoItem,

            };

            try
            {
                _pedidoRepository.AddAsync(perdido);
            }
            catch (Exception)
            {
                throw;
            }

            return Task.FromResult(new PedidoResponse
            {
                status = "sucesso"
            });
        }
    }
}
