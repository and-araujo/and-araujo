using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Data.Context;

namespace DevIO.Data.Repository
{
    public class PedidoAdicionalRepository : Repository<PedidoAdicional>, IPedidoAdicionalRepository
    {
        public PedidoAdicionalRepository(MeuDbContext context) : base(context) { }
    }
}
