
using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface ITamanhoService : IDisposable
    {
        Task Adicionar(Tamanho tamanho);
        Task Atualizar(Tamanho tamanho);
        Task Remover(int id);
    }
}
