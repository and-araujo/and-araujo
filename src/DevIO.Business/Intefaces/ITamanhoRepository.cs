
using DevIO.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface ITamanhoRepository : IRepository<Tamanho>
    {
        Task<IEnumerable<Tamanho>> ObterTamanhosDisponiveis();
    }
}
