using AutoMapper;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;

namespace TesteDesenvolvedor.Application.Services
{
    public class LeadService : ILeadService
    {
        private readonly IMapper _mapper;
        private ILeadRepository _repository;
        public LeadService(ILeadRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Add(LeadDTO inscricaoDTO)
        {
            var leadEntity = _mapper.Map<Lead>(inscricaoDTO);
            await _repository.Add(leadEntity);
        }

        public async Task Delete(int id)
        {
            var leadEntity = await _repository.GetById(id);
            await _repository.Delete(leadEntity);
        }

        public async Task<IEnumerable<LeadDTO>> GetAll()
        {
            var leadEntity = await _repository.GetAll();
            return _mapper.Map<IEnumerable<LeadDTO>>(leadEntity);
        }

        public async Task<LeadDTO> GetById(int id)
        {
            var leadEntity = await _repository.GetById(id);
            return _mapper.Map<LeadDTO>(leadEntity);
        }

        public async Task Update(LeadDTO leadDTO)
        {
            var leadEntity = _mapper.Map<Lead>(leadDTO);
            await _repository.Update(leadEntity);
        }
    }
}
