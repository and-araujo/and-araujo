using DevIO.Business.Intefaces;
using DevIO.Business.Mocks;
using DevIO.Business.Models;
using ExpectedObjects;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LojaAcai.Test
{
    public class PedidoAcaiTest
    {
        private readonly Mock<IPedidoService> _pedidoService;
        public PedidoAcaiTest()
        {
            _pedidoService = new Mock<IPedidoService>(); ;
        }

        [Fact]
        public void DeveSerPossivelAEscolhaDeUmAcaiPorPedido()
        {
            var pedidoAcaiEsperado = new
            {
                Id= 0,
                SaborPedido = new SaborMock().Mock.FirstOrDefault(),
                TamanhoPedido = new TamanhoMock().Mock.FirstOrDefault(),
                TempoTotalParaPreparo = 0,
                ValorTotalDoPedido = 0M,            
                PedidoAdicionais = new List<Adicional>()
            };

            var pedido = new Pedido(pedidoAcaiEsperado.SaborPedido, pedidoAcaiEsperado.TamanhoPedido, null);

            pedidoAcaiEsperado.ToExpectedObject().ShouldMatch(pedido);
        }

        [Fact]
        public void DeveAdicionarCincoMinutosNoPreparoAcaiSaborKiwi()
        {
            var saborKiwi = new SaborMock().Mock.FirstOrDefault(s => s.Id == (int)enSabor.Kiwi);
            var tamanhoAcai = new TamanhoMock().Mock.FirstOrDefault();
            var pedido = new Pedido(saborKiwi, tamanhoAcai, null);
            
            pedido.CalcularValores();

            Assert.Equal(saborKiwi.TempoAdicional + tamanhoAcai.TempoPreparo, pedido.TempoTotalParaPreparo);
        } 

        [Fact]
        public void DevePossuiTempoDePreparoEspecificoEPrecoUnicoDeAcordoComOTamnanhoGrande()
        {
            var saborBanana = new SaborMock().Mock.FirstOrDefault(s => s.Id == (int)enSabor.Banana);
            var tamanhoAcai = new TamanhoMock().Mock.FirstOrDefault(s => s.Id == (int)enTamanho.Grande);
            var pedido = new Pedido(saborBanana, tamanhoAcai, null);

            pedido.CalcularValores();

            Assert.Equal(saborBanana.ValorAdicional + tamanhoAcai.Valor, pedido.ValorTotalDoPedido);
            Assert.Equal(saborBanana.TempoAdicional + tamanhoAcai.TempoPreparo, pedido.TempoTotalParaPreparo);
        }

        [Fact]
        public void DeveSelecionarAdicionaisOpcionalVerificarTempoPreparo()
        {
            var saborBanana = new SaborMock().Mock.FirstOrDefault(s => s.Id == (int)enSabor.Banana);
            var tamanhoAcai = new TamanhoMock().Mock.FirstOrDefault(s => s.Id == (int)enTamanho.Grande);
            var adicionais = new AdicionaisMock().Mock;
            var pedido = new Pedido(saborBanana, tamanhoAcai, adicionais);
            var tempoPreparo = saborBanana.TempoAdicional + tamanhoAcai.TempoPreparo + adicionais.Sum(a => a.TempoAdicional);

            pedido.CalcularValores();

            Assert.Equal(tempoPreparo, pedido.TempoTotalParaPreparo);
        }

        [Fact]
        public void DeveSelecionarAdicionaisOpcionalVerificarValorTotal()
        {
            var saborBanana = new SaborMock().Mock.FirstOrDefault(s => s.Id == (int)enSabor.Banana);
            var tamanhoAcai = new TamanhoMock().Mock.FirstOrDefault(s => s.Id == (int)enTamanho.Grande);
            var adicionais = new AdicionaisMock().Mock;
            var pedido = new Pedido(saborBanana, tamanhoAcai, adicionais);
            var valorTotal = saborBanana.ValorAdicional + tamanhoAcai.Valor + adicionais.Sum(a => a.ValorAdicional);            

            pedido.CalcularValores();

            Assert.Equal(valorTotal, pedido.ValorTotalDoPedido);
        }
    }
}
