using Domain.Model;
using Domain.Repository;


namespace Infraestruture.repository.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly List<Pedido> _pedidos = new(); // Meu docker não quis funcionar :(

        public Task<Pedido> AddAsync(Pedido pedido)
        {
            pedido.Id = _pedidos.Count > 0 ? _pedidos.Max(p => p.Id) + 1 : 1;
            _pedidos.Add(pedido);
            return Task.FromResult(pedido);
        }

        public Task<Pedido> GetByIdAsync(int id)
        {
            var pedido = _pedidos.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(pedido);
        }

        public Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return Task.FromResult((IEnumerable<Pedido>)_pedidos);
        }
    }
}