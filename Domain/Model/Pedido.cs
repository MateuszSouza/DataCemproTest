
using System.Linq;


namespace Domain.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public char situação { get; set; }
        public Usuario usuario { get; set; }
        public DateTime DataInclusao { get; set; }
        public List<Produto> PedidoItem { get; set; }
        public Cliente Cliente { get; set; }
    }
}