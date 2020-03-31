using DevIO.Business.Intefaces;
using DevIO.Business.Mocks;
using DevIO.Business.Models;
using DevIO.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class AdicionalRepository : Repository<Adicional>, IAdicionalRepository
    {
        public AdicionalRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<Adicional>> ObterAdicionaisDisponiveis() => await Task.Run(() => new AdicionaisMock().Mock);
        
        public async Task<Adicional> ObterPorId(int id)
        {
            return await Task.Run(() => new AdicionaisMock().Mock.FirstOrDefault(s => s.Id == id));
        }
    }
}
