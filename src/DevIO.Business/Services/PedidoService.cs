
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class PedidoService : BaseService, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        //private readonly IPedidoAdicionalRepository _pedidoAdicionalRepository;
        private readonly IUser _user;

        public PedidoService(IPedidoRepository pedidoRepository,
                             //IPedidoAdicionalRepository pedidoAdicionalRepository,
                              INotificador notificador,
                              IUser user) : base(notificador)
        {
            _pedidoRepository = pedidoRepository;
            //_pedidoAdicionalRepository = pedidoAdicionalRepository;
            _user = user;
        }

        public async Task Adicionar(Pedido pedido)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            //var user = _user.GetUserId();

            await _pedidoRepository.Adicionar(pedido);
        }

        public async Task Atualizar(Pedido pedido)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _pedidoRepository.Atualizar(pedido);
        }

        public async Task Remover(int id)
        {
            await _pedidoRepository.Remover(id);
        }

        public async Task SimularPedido(Pedido pedido)
        {            
            await Task.Run(() => pedido.CalcularValores());
        }

        //public void VerificarValoresPedido(Pedido pedido)
        //{
        //    VerificarTempoPreparoPorSabor(pedido);
        //    VerificarTempoValorPreparoPorTamanho(pedido);
        //    VerificarTempoValorPreparoPorAdicionais(pedido);
        //}

        //public void VerificarTempoPreparoPorSabor(Pedido pedido)
        //{
        //    if (pedido.SaborPedido.Id == (int)enSabor.Kiwi)
        //    {
        //        pedido.TempoTotalParaPreparo = pedido.TempoTotalParaPreparo + 5;
        //    }
        //}

        //public void VerificarTempoValorPreparoPorTamanho(Pedido pedido)
        //{
        //    switch (pedido.TamanhoPedido.Id)
        //    {
        //        case (int)enTamanho.Pequeno:
        //            pedido.ValorTotalDoPedido += 10;
        //            pedido.TempoTotalParaPreparo += 5;
        //            break;
        //        case (int)enTamanho.Medio:
        //            pedido.ValorTotalDoPedido += 13;
        //            pedido.TempoTotalParaPreparo += 7;
        //            break;
        //        case (int)enTamanho.Grande:
        //            pedido.ValorTotalDoPedido += 15;
        //            pedido.TempoTotalParaPreparo += 10;
        //            break;
        //    }
        //}

        //public void VerificarTempoValorPreparoPorAdicionais(Pedido pedido)
        //{
        //    if (pedido.PedidoAdicionais.Count() > 0)
        //    {
        //        var valorTotalAdcionais = pedido.PedidoAdicionais.Sum(p => p.ValorAdicional);
        //        var tempoTotalAdcionais = pedido.PedidoAdicionais.Sum(p => p.TempoAdicional);

        //        pedido.ValorTotalDoPedido += valorTotalAdcionais;
        //        pedido.TempoTotalParaPreparo += tempoTotalAdcionais;
        //    }
        //}

        public void Dispose()
        {
            _pedidoRepository?.Dispose();
        }
    }
}
