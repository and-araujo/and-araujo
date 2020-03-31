using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface IAdicionalService : IDisposable
    {
        Task Adicionar(Adicional sabor);
        Task Atualizar(Adicional sabor);
        Task Remover(int id);
    }
}
