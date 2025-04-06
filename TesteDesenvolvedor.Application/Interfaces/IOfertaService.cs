
using TesteDesenvolvedor.Application.DTOs;

namespace TesteDesenvolvedor.Application.Interfaces
{
    public interface IOfertaService
    {
        Task<IEnumerable<OfertaDTO>> GetAll();
        Task<OfertaDTO> GetById(int id);
        Task Update(OfertaDTO oferta);
        Task Add(OfertaDTO oferta);
        Task Delete(int id);
    }
}
