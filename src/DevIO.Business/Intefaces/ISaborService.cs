using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface ISaborService : IDisposable
    {
        Task Adicionar(Sabor sabor);
        Task Atualizar(Sabor sabor);
        Task Remover(int id);
    }
}
