
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TesteDesenvolvedor.Application.DTOs
{
    public class OfertaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Por favor, insira o nome da oferta/curso")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira a descrção da oferta/curso")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, insira quantas vagas há disponíveis para a oferta/curso")]
        [Range(1, 9999)]
        public int VagasDisponiveis { get; set; }
    }
}
