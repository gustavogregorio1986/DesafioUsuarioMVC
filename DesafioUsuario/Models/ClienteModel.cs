namespace DesafioUsuario.Models
{
    public class ClienteModel
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public byte Upload { get; set; }
    }
}
