
using TesteDesenvolvedor.Domain.Entities;

namespace TesteDesenvolvedor.Domain.Interfaces
{
    public interface IProcessoSeletivoRepository
    {
        Task<IEnumerable<ProcessoSeletivo>> GetAll();
        Task<ProcessoSeletivo> GetById(int id);
        Task<ProcessoSeletivo> Add(ProcessoSeletivo processoSeletivo);
        Task<ProcessoSeletivo> Delete(ProcessoSeletivo processoSeletivo);
        Task<ProcessoSeletivo> Update(ProcessoSeletivo processoSeletivo);
    }
}
