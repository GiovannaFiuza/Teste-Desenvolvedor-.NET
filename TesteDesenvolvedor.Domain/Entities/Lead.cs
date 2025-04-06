
namespace TesteDesenvolvedor.Domain.Entities
{
    public sealed class Lead
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string CPF { get; private set; }

        public Lead(string nome, string email, string telefone, string CPF)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            this.CPF = CPF;
        }
        public ICollection<Inscricao> Inscricoes { get; set; }
    }
}
