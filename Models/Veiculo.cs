using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace GoopCadastroDeVeiculos.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória.")]
        public string Marca { get; set; }
        
        [Required(ErrorMessage = "O modelo é obrigatório.")]
        public string Modelo { get; set; }
        
        [Range(1900, 2024, ErrorMessage = "O ano digitado é inválido, por favor, digite um ano entre 1900 e 2024.")]
        public int Ano { get; set; }
        
        [Required(ErrorMessage = "A cor é obrigatória")]
        public string Cor { get; set; }
    }
}
