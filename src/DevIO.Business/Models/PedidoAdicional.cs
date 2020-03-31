

namespace DevIO.Business.Models
{
    public class PedidoAdicional : Entity
    {
        public int PedidoId { get; set; }
        public int  AdicionalId { get; set; }
        public Pedido Pedido { get; set; }
        public Adicional Adicional { get; set; }
    }
}
