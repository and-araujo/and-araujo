
using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface IPedidoService : IDisposable
    {
        Task Adicionar(Pedido pedido);
        Task Atualizar(Pedido pedido);
        Task Remover(int id);
        Task SimularPedido(Pedido pedido);
    }
}
