
using TesteDesenvolvedor.Application.DTOs;

namespace TesteDesenvolvedor.Application.Interfaces
{
    public interface IProcessoSeletivoService
    {
        Task<IEnumerable<ProcessoSeletivoDTO>> GetAll();
        Task<ProcessoSeletivoDTO> GetById(int id);
        Task Update(ProcessoSeletivoDTO ProcessoSeletivo);
        Task Add(ProcessoSeletivoDTO ProcessoSeletivo);
        Task Delete(int id);
    }
}
