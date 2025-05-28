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

        // Construtor
        public Agendamento(DateTime dataAgendamento, string descricao)
        {
            DataAgendamento = dataAgendamento;
            Descricao = descricao;
        }
    }
}
