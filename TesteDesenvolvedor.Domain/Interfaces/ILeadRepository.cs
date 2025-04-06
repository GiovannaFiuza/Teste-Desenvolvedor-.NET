
using TesteDesenvolvedor.Domain.Entities;

namespace TesteDesenvolvedor.Domain.Interfaces
{
    public interface ILeadRepository
    {
        Task<IEnumerable<Lead>> GetAll();
        Task<Lead> GetById(int id);
        Task<Lead> Add(Lead lead);
        Task<Lead> Delete(Lead lead);
        Task<Lead> Update(Lead lead);
    }
}
