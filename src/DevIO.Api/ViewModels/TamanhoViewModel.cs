
using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class TamanhoViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public int TempoPreparo { get; set; }
    }
}
