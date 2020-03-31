using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Models
{
    public class Adicional : Entity
    {
        public string Descricao { get; set; }
        public decimal ValorAdicional { get; set; }
        public int TempoAdicional { get; set; }
        public ICollection<PedidoAdicional> PedidoAdicionais { get; set; }
    }
}
