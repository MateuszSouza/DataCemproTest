using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cadastrar

{
    using Domain.CadastrarPedido;
    using Domain.Model;
    using MediatR;

    public class CreatePedidoCommand : IRequest<PedidoResponse>
    {
        public DateTime DataEmissao { get; set; }
        public char Situacao { get; set; }
        public int UsuarioId { get; set; } // supondo que o usuário é referenciado por um ID
        public DateTime DataInclusao { get; set; }
        public List<Produto> PedidoItem { get; set; }
        public int ClienteId { get; set; } // supondo que o cliente é referenciado por um ID
    }

}
