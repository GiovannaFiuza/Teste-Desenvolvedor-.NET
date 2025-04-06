
namespace TesteDesenvolvedor.Domain.Entities
{
    public sealed class Inscricao
    {
        public int Id { get; private set; }
        public int NumInscricao { get; private set; }
        public DateTime Data { get; private set; }
        public string Status { get; private set; }

        public Inscricao(int numInscricao, DateTime data, string status) 
        {
            NumInscricao = numInscricao;
            Data = data;
            Status = status;       
        }

        public int LeadId { get; set; }
        public Lead Lead { get; set; }
        public int ProcessoSeletivoId { get; set; }
        public ProcessoSeletivo ProcessoSeletivo { get; set; }
        public int OfertaId { get; set; }
        public Oferta Oferta { get; set; }

    }
}
