using SafeSpaceAPI.Domain.Enums;
using System.Collections.Generic;

namespace SafeSpaceAPI.Domain.Entities
{
    public class UsuarioSS
    {
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Senha { get; private set; }

        public TipoUsuario TipoUsuario { get; private set; }

        public DateTime DataCadastro { get; private set; }

        // Coleção de agendamentos do usuário
        public ICollection<Agendamento> Agendamentos { get; private set; } = new List<Agendamento>();

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
