using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class PedidoSimuladoViewModel
    {
        [Key]
        public int Id { get; set; }
        public SaborViewModel SaborPedido { get; set; }
        public TamanhoViewModel TamanhoPedido { get; set; }
        public IEnumerable<AdicionalViewModel> PedidoAdicionais { get; set; }
        public int TempoTotalParaPreparo { get; set; }
        public decimal ValorTotalDoPedido { get; set; }
    }
}
