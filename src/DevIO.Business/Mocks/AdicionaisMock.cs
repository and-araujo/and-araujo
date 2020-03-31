
using DevIO.Business.Models;
using System.Collections.Generic;

namespace DevIO.Business.Mocks
{
    public class AdicionaisMock
    {
        public IEnumerable<Adicional> Mock { get; private set; }

        public AdicionaisMock()
        {
            var mock = new List<Adicional>();
            mock.Add(new Adicional { Id = 1, Descricao = "Granola", TempoAdicional = 0, ValorAdicional = 0 });
            mock.Add(new Adicional { Id = 2, Descricao = "Paçoca", TempoAdicional = 3, ValorAdicional = 3 });
            mock.Add(new Adicional { Id = 3, Descricao = "Leite Ninho", TempoAdicional = 0, ValorAdicional = 3 });
            Mock = mock;
        }
    }
}
