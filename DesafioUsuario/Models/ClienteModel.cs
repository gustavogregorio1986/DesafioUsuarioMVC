using System.ComponentModel.DataAnnotations;

namespace DesafioUsuario.Models
{
    public class ClienteModel
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        public string Senha { get; set; }

        public byte Upload { get; set; }
    }
}
