using System.ComponentModel.DataAnnotations;

namespace EnqueteWeb.Models
{
    public class Resposta
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo Email não corresponde a um endereço de email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Resposta é obrigatório")]
        public bool? Sim { get; set; }
    }
}