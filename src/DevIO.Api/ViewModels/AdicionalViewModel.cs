using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class AdicionalViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal ValorAdicional { get; set; }

        public int TempoAdicional { get; set; }
    }
}
