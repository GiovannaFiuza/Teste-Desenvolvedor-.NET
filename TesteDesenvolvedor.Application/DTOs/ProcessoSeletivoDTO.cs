
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TesteDesenvolvedor.Application.DTOs
{
    public class ProcessoSeletivoDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Por favor, insira o nome do processo seletivo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira a data de início do processo seletivo")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, insira a data de término do processo seletivo")]   
        [DataType(DataType.Date)]
        public DateTime DataTermino { get; set; }
    }
}
