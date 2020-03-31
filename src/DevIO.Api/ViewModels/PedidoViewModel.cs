using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class PedidoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, 99999, ErrorMessage = "O campo {0} é obrigatório")]
        public int Sabor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1, 999999, ErrorMessage = "O campo {0} é obrigatório")]
        public int Tamanho { get; set; }

        public List<int> Adicionais { get; set; }
    }
}
