
using System;
using System.Threading.Tasks;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;

namespace DevIO.Business.Services
{
    public class SaborService : BaseService, ISaborService
    {
        private readonly ISaborRepository _saborRepository;
        private readonly IUser _user;

        public SaborService(ISaborRepository saborRepository,
                              INotificador notificador,
                              IUser user) : base(notificador)
        {
            _saborRepository = saborRepository;
            _user = user;
        }

        public async Task Adicionar(Sabor sabor)
        {
            await _saborRepository.Adicionar(sabor);
        }

        public async Task Atualizar(Sabor sabor)
        {
            await _saborRepository.Atualizar(sabor);
        }

        public async Task Remover(int id)
        {
            await _saborRepository.Remover(id);
        }

        public void Dispose()
        {
            _saborRepository?.Dispose();
        }
    }
}
