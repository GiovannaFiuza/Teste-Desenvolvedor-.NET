using System.ComponentModel.DataAnnotations;
using TesteDesenvolvedor.Domain.Entities;
using System.Text.Json.Serialization;


namespace TesteDesenvolvedor.Application.DTOs
{
    public class InscricaoDTO
    {
        public int Id { get; set; }

        [Range(1, 9999, ErrorMessage ="O Id deve ser um número inteiro entre 1 e 9999")]
        public int NumInscricao { get; set; }

        [Required(ErrorMessage ="Por favor, insira a data de inscrição.")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Por favor, insira os status que se encontra a inscrição.")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Por favor, o Id do candidato vinculado a sua inscrição.")]
        public int LeadId { get; set; }

        [JsonIgnore]
        public Lead? Lead { get; set; }

        [Required(ErrorMessage = "Por favor, o Id do processo seletivo vinculado a sua inscrição.")]
        public int ProcessoSeletivoId { get; set; }
        [JsonIgnore]
        public ProcessoSeletivo? ProcessoSeletivo { get; set; }

        [Required(ErrorMessage = "Por favor, o Id do curso vinculado a sua inscrição.")]
        public int OfertaId { get; set; }
        [JsonIgnore]
        public Oferta? Oferta { get; set; }
    }
}
