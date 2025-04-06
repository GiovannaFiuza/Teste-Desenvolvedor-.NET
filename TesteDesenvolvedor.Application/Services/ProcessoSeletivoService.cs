using AutoMapper;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;

namespace TesteDesenvolvedor.Application.Services
{
    public class ProcessoSeletivoService : IProcessoSeletivoService
    {
        private readonly IMapper _mapper;
        private IProcessoSeletivoRepository _repository;
        public ProcessoSeletivoService(IProcessoSeletivoRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Add(ProcessoSeletivoDTO processoSeletivoDTO)
        {
            var processoSeletivoEntity = _mapper.Map<ProcessoSeletivo>(processoSeletivoDTO);
            await _repository.Add(processoSeletivoEntity);
        }

        public async Task Delete(int id)
        {
            var processoSeletivoEntity = await _repository.GetById(id);
            await _repository.Delete(processoSeletivoEntity);
        }

        public async Task<IEnumerable<ProcessoSeletivoDTO>> GetAll()
        {
            var processoSeletivoEntity = await _repository.GetAll();
            return _mapper.Map<IEnumerable<ProcessoSeletivoDTO>>(processoSeletivoEntity);
        }

        public async Task<ProcessoSeletivoDTO> GetById(int id)
        {
            var processoSeletivoEntity = await _repository.GetById(id);
            return _mapper.Map<ProcessoSeletivoDTO>(processoSeletivoEntity);
        }

        public async Task Update(ProcessoSeletivoDTO processoSeletivoDTO)
        {
            var processoSeletivoEntity = _mapper.Map<ProcessoSeletivo>(processoSeletivoDTO);
            await _repository.Update(processoSeletivoEntity);
        }
    }
}
