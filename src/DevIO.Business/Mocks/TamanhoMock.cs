using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Mocks
{
    public class TamanhoMock
    {
        public IEnumerable<Tamanho> Mock { get; private set; }
        public TamanhoMock()
        {
            var mock = new List<Tamanho>();
            mock.Add(new Tamanho { Id = 1, Descricao = "Pequeno (300ml)", TempoPreparo = 5, Valor = 10 });
            mock.Add(new Tamanho { Id = 2, Descricao = "Médio (500ml)", TempoPreparo = 7, Valor = 13 });
            mock.Add(new Tamanho { Id = 3, Descricao = "Grande (700ml)", TempoPreparo = 10, Valor = 15 });
            Mock = mock;
        }
    }
}
