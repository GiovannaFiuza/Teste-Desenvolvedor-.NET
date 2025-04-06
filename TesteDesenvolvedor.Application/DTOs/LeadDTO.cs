using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace TesteDesenvolvedor.Application.DTOs
{
    public class LeadDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, insira um nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, insira um e-mail para contato.")]
        [EmailAddress(ErrorMessage ="Formato de e-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, insira um telefone para contato.")]
        [Phone(ErrorMessage ="Formate de telefone é inválido.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por favor, insira o CPF do lead/candidato.")]
        public string CPF { get; set; }
    }
}
