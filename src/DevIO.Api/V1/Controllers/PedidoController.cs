using AutoMapper;
using DevIO.Api.Controllers;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Api.V1.Controllers
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Pedidos")]
    public class PedidoController : MainController
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IPedidoService _pedidoService;
        private readonly ISaborRepository _saborRepository;
        private readonly IAdicionalRepository _adicionalRepository;
        private readonly ITamanhoRepository _tamanhoRepository;

        private readonly IMapper _mapper;

        public PedidoController(INotificador notificador,
                                  IPedidoRepository pedidoRepository,
                                  IPedidoService pedidoService,
                                  ISaborRepository saborRepository,
                                  IAdicionalRepository adicionalRepository,
                                  ITamanhoRepository tamanhoRepository,
                                  IMapper mapper,
                                  IUser user) : base(notificador, user)
        {
            _pedidoRepository = pedidoRepository;
            _pedidoService = pedidoService;
            _adicionalRepository = adicionalRepository;
            _saborRepository = saborRepository;
            _tamanhoRepository = tamanhoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("simularPedido")]
        public async Task<ActionResult<SaborViewModel>> SimularPedido(PedidoViewModel pedidoViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            Pedido simulacao = await MontarPedido(pedidoViewModel);

            await _pedidoService.SimularPedido(simulacao);

            return CustomResponse(_mapper.Map<PedidoSimuladoViewModel>(simulacao));
        } 

        private async Task<Pedido> MontarPedido(PedidoViewModel pedidoViewModel)
        {
            var sabor = await _saborRepository.ObterPorId((int)pedidoViewModel.Sabor);
            var tamanho = await _tamanhoRepository.ObterPorId((int)pedidoViewModel.Tamanho);

            List<Adicional> listaAdicionais = new List<Adicional>();
            foreach (var adicional in pedidoViewModel.Adicionais)
            {
                var ad = await _adicionalRepository.ObterPorId((int)adicional);
                listaAdicionais.Add(ad);
            }

            Pedido simulacao = new Pedido(sabor, tamanho, listaAdicionais);
            return simulacao;
        }
    }
}
