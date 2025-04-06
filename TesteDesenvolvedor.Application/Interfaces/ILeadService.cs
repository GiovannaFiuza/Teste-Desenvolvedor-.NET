
using TesteDesenvolvedor.Application.DTOs;

namespace TesteDesenvolvedor.Application.Interfaces
{
    public interface ILeadService
    {
        Task<IEnumerable<LeadDTO>> GetAll();
        Task<LeadDTO> GetById(int id);
        Task Update(LeadDTO lead);
        Task Add(LeadDTO lead);
        Task Delete(int id);
    }
}
