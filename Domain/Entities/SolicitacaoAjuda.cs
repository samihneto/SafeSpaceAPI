namespace SafeSpaceAPI.Domain.Entities
{
    public class SolicitacaoAjuda
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataSolicitacao { get; private set; }
        public Guid IdUsuarioSS { get; set; }

        public SolicitacaoAjuda(Guid id, string descricao, DateTime dataSolicitacao, Guid idUsuarioSS)
        {
            Id = id;
            Descricao = descricao;
            DataSolicitacao = dataSolicitacao;
            IdUsuarioSS = idUsuarioSS;
        }
    }
}
