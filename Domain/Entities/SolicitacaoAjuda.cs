namespace SafeSpaceAPI.Domain.Entities
{
    public class SolicitacaoAjuda
    {
        public Guid Id { get; set; }
        public string Descricao { get; private set; }
        public DateTime DataSolicitacao { get; private set; }

        public SolicitacaoAjuda(string descricao, DateTime dataSolicitacao)
        {
            Descricao = descricao;
            DataSolicitacao = dataSolicitacao;
        }
    }
}
