
namespace TesteDesenvolvedor.Domain.Entities
{
    public sealed class ProcessoSeletivo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }

        public ProcessoSeletivo(string nome, DateTime dataInicio, DateTime dataTermino)
        {
            Nome = nome;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
        }

        public ICollection<Inscricao> Inscricoes { get; set;}
    }
}
