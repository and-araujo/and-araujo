
using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class SaborViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int TempoAdicional { get; set; }
    }
}
