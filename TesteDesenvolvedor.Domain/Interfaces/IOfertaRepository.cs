using TesteDesenvolvedor.Domain.Entities;

namespace TesteDesenvolvedor.Domain.Interfaces
{
    public interface IOfertaRepository
    {
        Task<IEnumerable<Oferta>> GetAll();
        Task<Oferta> GetById(int id);
        Task<Oferta> Add(Oferta oferta);
        Task<Oferta> Delete(Oferta oferta);
        Task<Oferta> Update(Oferta oferta);
    }
}
