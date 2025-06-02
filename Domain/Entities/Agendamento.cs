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

        public string Descricao { get; set; }

        public Guid UsuarioSSId { get; set; }

        public UsuarioSS? UsuarioSS { get; set; }

        public Agendamento() { } // Necessário para o binding do ASP.NET

        public Agendamento(DateTime dataAgendamento, string descricao, Guid usuarioSSId)
        {
            DataAgendamento = dataAgendamento;
            Descricao = descricao;
            UsuarioSSId = usuarioSSId;
        }
    }
}
