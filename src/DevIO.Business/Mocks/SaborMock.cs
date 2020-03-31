

using DevIO.Business.Models;
using System.Collections.Generic;

namespace DevIO.Business.Mocks
{
    public class SaborMock
    {
        public IEnumerable<Sabor> Mock { get; private set; }
        public SaborMock()
        {
            var mock = new List<Sabor>();
            mock.Add(new Sabor { Id = 1, Descricao = "Morango", TempoAdicional = 0, ValorAdicional = 0 });
            mock.Add(new Sabor { Id = 2, Descricao = "Banana", TempoAdicional = 0, ValorAdicional = 0 });
            mock.Add(new Sabor { Id = 3, Descricao = "Kiwi", TempoAdicional = 5, ValorAdicional = 0 });
            Mock = mock;
        }
    }
}
