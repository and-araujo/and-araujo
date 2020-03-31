using DevIO.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface ISaborRepository : IRepository<Sabor>
    {
        Task<IEnumerable<Sabor>> ObterSaboresDisponiveis();
        Task<Sabor> ObterPorId(int id);
    }
}
