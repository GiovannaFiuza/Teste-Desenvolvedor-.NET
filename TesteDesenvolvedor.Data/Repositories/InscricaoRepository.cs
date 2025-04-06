using Microsoft.EntityFrameworkCore;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;
using TesteDesenvolvedor.Infra.Ioc.Context;

namespace TesteDesenvolvedor.Data.Repositories
{
    public class InscricaoRepository : IInscricaoRepository
    {
        ApplicationDbContext _context;
        public InscricaoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Inscricao> Add(Inscricao inscricao)
        {
            _context.Add(inscricao);
            await _context.SaveChangesAsync();
            return inscricao;
        }

        public async Task<Inscricao> Delete(Inscricao inscricao)
        {
            _context.Remove(inscricao);
            await _context.SaveChangesAsync();
            return inscricao;
        }

        public async Task<IEnumerable<Inscricao>> GetAll()
        {
            return await _context.Inscricoes.ToListAsync();
        }

        public async Task<Inscricao> GetById(int id)
        {
           return await _context.Inscricoes.FindAsync(id);
        }

        public async Task<Inscricao> Update(Inscricao inscricao)
        {
            _context.Update(inscricao);
            await _context.SaveChangesAsync();
            return inscricao;
        }
        public async Task<IEnumerable<Inscricao>> GetByCpf(string cpf)
        {
            return await _context.Inscricoes
                .Include(i => i.Lead)
                .Where(i => i.Lead.CPF == cpf)
                .ToListAsync();
        }

        public async Task<IEnumerable<Inscricao>> GetByOferta(int ofertaId)
        {
            return await _context.Inscricoes
                .Include(i => i.Oferta)
                .Where(i => i.Oferta.Id == ofertaId)
                .ToListAsync();
        }
    }
}
