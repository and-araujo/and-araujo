
using System.Collections.Generic;
using System.Linq;

namespace DevIO.Business.Models
{
    public class Pedido : Entity
    {
        public Sabor SaborPedido { get; private set; }
        public Tamanho TamanhoPedido { get; private set; }
        public int TempoTotalParaPreparo { get; private set; }
        public decimal ValorTotalDoPedido { get; private set; }

        public IEnumerable<Adicional> PedidoAdicionais { get; private set; }

        public Pedido()
        {
        }

        public Pedido(Sabor sabor, Tamanho tamanho, IEnumerable<Adicional> adicionais = null)
        {
            TempoTotalParaPreparo = 0;
            ValorTotalDoPedido = 0;
            SaborPedido = sabor;
            TamanhoPedido = tamanho;
            PedidoAdicionais = adicionais == null ? new List<Adicional>() : adicionais;
        }

        public void CalcularValores()
        {
            ValorSabor();
            ValorTamanho();
            ValorAdicionais();
        }

        private void ValorSabor()
        {
            TempoTotalParaPreparo += SaborPedido.TempoAdicional;
        }

        private void ValorTamanho()
        {
            ValorTotalDoPedido += TamanhoPedido.Valor;
            TempoTotalParaPreparo += TamanhoPedido.TempoPreparo;
        }

        private void ValorAdicionais()
        {
            if (PedidoAdicionais.Count() > 0)
            {
                var valorTotalAdcionais = PedidoAdicionais.Sum(p => p.ValorAdicional);
                var tempoTotalAdcionais = PedidoAdicionais.Sum(p => p.TempoAdicional);

                ValorTotalDoPedido += valorTotalAdcionais;
                TempoTotalParaPreparo += tempoTotalAdcionais;
            }
        }
    }    
}

