using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Models;

namespace DevIO.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Sabor, SaborViewModel>().ReverseMap();
            CreateMap<Tamanho, TamanhoViewModel>().ReverseMap();
            CreateMap<Adicional, AdicionalViewModel>().ReverseMap();
            CreateMap<Pedido, PedidoViewModel>().ReverseMap();
            CreateMap<Pedido, PedidoSimuladoViewModel>().ReverseMap();
        }
    }
}