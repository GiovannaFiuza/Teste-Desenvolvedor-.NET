using Microsoft.EntityFrameworkCore;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;
using TesteDesenvolvedor.Infra.Ioc.Context;

namespace TesteDesenvolvedor.Data.Repositories
{
    public class ProcessoSeletivoRepository : IProcessoSeletivoRepository
    {
        ApplicationDbContext _context;
        public ProcessoSeletivoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ProcessoSeletivo> Add(ProcessoSeletivo processoSeletivo)
        {
            _context.Add(processoSeletivo);
            await _context.SaveChangesAsync();
            return processoSeletivo;
        }

        public async Task<ProcessoSeletivo> Delete(ProcessoSeletivo processoSeletivo)
        {
            _context.Remove(processoSeletivo);
            await _context.SaveChangesAsync();
            return processoSeletivo;
        }

        public async Task<IEnumerable<ProcessoSeletivo>> GetAll()
        {
            return await _context.ProcessoSeletivos.ToListAsync();
        }

        public async Task<ProcessoSeletivo> GetById(int id)
        {
            return await _context.ProcessoSeletivos.FindAsync(id);
        }

        public async Task<ProcessoSeletivo> Update(ProcessoSeletivo processoSeletivo)
        {
            _context.Update(processoSeletivo);
            await _context.SaveChangesAsync();
            return processoSeletivo;
        }
    }
}
