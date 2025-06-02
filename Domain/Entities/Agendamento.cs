using SafeSpaceAPI.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafeSpaceAPI.Domain.Entities
{
    public class Agendamento
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime DataAgendamento { get; private set; }

        public string Descricao { get; private set; }

        // FK para UsuarioSS
        public Guid UsuarioSSId { get; set; }

        // Propriedade de navegação para o usuário
        public UsuarioSS UsuarioSS { get; set; }

        // Construtor
        public Agendamento(DateTime dataAgendamento, string descricao, Guid usuarioSSId)
        {
            DataAgendamento = dataAgendamento;
            Descricao = descricao;
            UsuarioSSId = usuarioSSId;
        }
    }
}
