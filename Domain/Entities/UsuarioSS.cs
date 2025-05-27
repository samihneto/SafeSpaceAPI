using SafeSpaceAPI.Domain.Enums;

namespace SafeSpaceAPI.Domain.Entities
{
    public class UsuarioSS
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public TipoUsuario TipoUsuario { get; private set; }

        public DateTime DataCadastro { get; set; }

        public UsuarioSS(string nome, string email, string telefone, string senha, TipoUsuario tipoUsuario, DateTime dataCadastro)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            TipoUsuario = tipoUsuario;
            DataCadastro = dataCadastro;
        }
    }
}
