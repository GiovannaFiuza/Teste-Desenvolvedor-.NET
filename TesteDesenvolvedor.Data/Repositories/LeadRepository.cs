using Microsoft.EntityFrameworkCore;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;
using TesteDesenvolvedor.Infra.Ioc.Context;

namespace TesteDesenvolvedor.Data.Repositories
{
    public class LeadRepository : ILeadRepository
    {
        ApplicationDbContext _context;
        public LeadRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Lead> Add(Lead lead)
        {
            _context.Add(lead);
            await _context.SaveChangesAsync();
            return lead;
        }

        public async Task<Lead> Delete(Lead lead)
        {
            _context.Remove(lead);
            await _context.SaveChangesAsync();
            return lead;
        }

        public async Task<IEnumerable<Lead>> GetAll()
        {
            return await _context.Leads.ToListAsync();
        }

        public async Task<Lead> GetById(int id)
        {
            return await _context.Leads.FindAsync(id);
        }

        public async Task<Lead> Update(Lead lead)
        {
            _context.Update(lead);
            await _context.SaveChangesAsync();
            return lead;
        }
    }
}
