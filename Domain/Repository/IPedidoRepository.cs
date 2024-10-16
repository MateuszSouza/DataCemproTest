using Domain.Model;

namespace Domain.Repository
{
    public  interface IPedidoRepository
    {
        Task<Pedido> AddAsync(Pedido pedido);
        Task<Pedido> GetByIdAsync(int id);
        Task<IEnumerable<Pedido>> GetAllAsync();
    }
}
