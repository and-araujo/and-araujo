
using DevIO.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface IAdicionalRepository : IRepository<Adicional>
    {
        Task<IEnumerable<Adicional>> ObterAdicionaisDisponiveis();
    }
}
