using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Domain.Entities;

namespace TesteDesenvolvedor.Application.Interfaces
{
    public interface IInscricaoService
    {
        Task<IEnumerable<InscricaoDTO>> GetAll();
        Task<InscricaoDTO> GetById(int id);
        Task Update(InscricaoDTO inscricao);
        Task Add(InscricaoDTO inscricao);
        Task Delete(int id);
        Task<IEnumerable<InscricaoDTO>> GetByCpf(string cpf);
        Task<IEnumerable<InscricaoDTO>> GetByOferta(int ofertaId);
    }
}
