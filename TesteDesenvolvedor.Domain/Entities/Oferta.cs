
namespace TesteDesenvolvedor.Domain.Entities
{
    public sealed class Oferta
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set;}
        public int VagasDisponiveis { get; private set; }

        public Oferta(string nome, string descricao, int vagasDisponiveis)
        {
            Nome = nome;
            Descricao = descricao;
            VagasDisponiveis = vagasDisponiveis;
        }
        public ICollection<Inscricao> Inscricoes { get; set; }
    }
}
