using TesteDesenvolvedor.Domain.Entities;

namespace TesteDesenvolvedor.Domain.Interfaces
{
    public interface IInscricaoRepository
    {
        Task<IEnumerable<Inscricao>> GetAll();
        Task<Inscricao> GetById(int id);
        Task<Inscricao> Add(Inscricao inscricao);
        Task<Inscricao> Delete(Inscricao inscricao);
        Task<Inscricao> Update(Inscricao inscricao);
        Task<IEnumerable<Inscricao>> GetByCpf(string cpf);
        Task<IEnumerable<Inscricao>> GetByOferta(int ofertaId);

    }
}
