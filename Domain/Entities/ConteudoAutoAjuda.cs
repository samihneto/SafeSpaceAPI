using SafeSpaceAPI.Domain.Enums;

namespace SafeSpaceAPI.Domain.Entities
{
    public class ConteudoAutoAjuda
    {
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string URL { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataPublicacao { get; private set; }
        public TipoConteudo TipoConteudo { get; private set; }

        public ConteudoAutoAjuda(string titulo, string uRL, string descricao, DateTime dataPublicacao, TipoConteudo tipoConteudo)
        {
            Titulo = titulo;
            URL = uRL;
            Descricao = descricao;
            DataPublicacao = dataPublicacao;
            TipoConteudo = tipoConteudo;
        }
    }
}
