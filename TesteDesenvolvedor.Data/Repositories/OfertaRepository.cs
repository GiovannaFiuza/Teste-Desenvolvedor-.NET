using Microsoft.EntityFrameworkCore;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;
using TesteDesenvolvedor.Infra.Ioc.Context;

namespace TesteDesenvolvedor.Data.Repositories
{
    public class OfertaRepository : IOfertaRepository
    {
        ApplicationDbContext _context;
        public OfertaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Oferta> Add(Oferta oferta)
        {
            _context.Add(oferta);
            await _context.SaveChangesAsync();
            return oferta;
        }

        public async Task<Oferta> Delete(Oferta oferta)
        {
            _context.Remove(oferta);
            await _context.SaveChangesAsync();
            return oferta;
        }

        public async Task<IEnumerable<Oferta>> GetAll()
        {
            return await _context.Ofertas.ToListAsync();
        }

        public async Task<Oferta> GetById(int id)
        {
            return await _context.Ofertas.FindAsync(id);
        }

        public async Task<Oferta> Update(Oferta oferta)
        {
            _context.Update(oferta);
            await _context.SaveChangesAsync();
            return oferta;
        }
    }
}
