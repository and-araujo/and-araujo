using DevIO.Business.Intefaces;
using DevIO.Business.Mocks;
using DevIO.Business.Models;
using DevIO.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class SaborRepository : Repository<Sabor>, ISaborRepository
    {
        public SaborRepository(MeuDbContext context) : base(context) { }
        
        public async Task<IEnumerable<Sabor>> ObterSaboresDisponiveis()
        {
            return await Task.Run(() => new SaborMock().Mock);
        }

        public async Task<Sabor> ObterPorId(int id)
        {
            return await Task.Run(() => new SaborMock().Mock.FirstOrDefault(s => s.Id == id));
        }
    }
}
