
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class TamanhoService : BaseService, ITamanhoService
    {
        private readonly ITamanhoRepository _tamanhoRepository;
        private readonly IUser _user;

        public TamanhoService(ITamanhoRepository tamanhoRepository,
                              INotificador notificador,
                              IUser user) : base(notificador)
        {
            _tamanhoRepository = tamanhoRepository;
            _user = user;
        }

        public async Task Adicionar(Tamanho tamanho)
        {
            await _tamanhoRepository.Adicionar(tamanho);
        }

        public async Task Atualizar(Tamanho tamanho)
        {
            await _tamanhoRepository.Atualizar(tamanho);
        }

        public async Task Remover(int id)
        {
            await _tamanhoRepository.Remover(id);
        }

        public void Dispose()
        {
            _tamanhoRepository?.Dispose();
        }
    }
}
