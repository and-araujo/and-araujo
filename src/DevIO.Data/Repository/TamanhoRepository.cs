using DevIO.Business.Intefaces;
using DevIO.Business.Mocks;
using DevIO.Business.Models;
using DevIO.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class TamanhoRepository : Repository<Tamanho>, ITamanhoRepository
    {
        public TamanhoRepository(MeuDbContext context) : base(context) { }
        
        public async Task<IEnumerable<Tamanho>> ObterTamanhosDisponiveis()
        {
            return await Task.Run(() => new TamanhoMock().Mock);
        }

        public async Task<Tamanho> ObterPorId(int id)
        {
            return await Task.Run(() => new TamanhoMock().Mock.FirstOrDefault(s => s.Id == id));
        }
    }    
}
