using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class AdicionalService : BaseService, IAdicionalService
    {
        private readonly IAdicionalRepository _adicionalRepository;
        private readonly IUser _user;

        public AdicionalService(IAdicionalRepository adicionalRepository,
                              INotificador notificador,
                              IUser user) : base(notificador)
        {
            _adicionalRepository = adicionalRepository;
            _user = user;
        }

        public async Task Adicionar(Adicional adicional)
        {
            await _adicionalRepository.Adicionar(adicional);
        }

        public async Task Atualizar(Adicional adicional)
        {
            await _adicionalRepository.Atualizar(adicional);
        }

        public async Task Remover(int id)
        {
            await _adicionalRepository.Remover(id);
        }

        public void Dispose()
        {
            _adicionalRepository?.Dispose();
        }
    }
}
