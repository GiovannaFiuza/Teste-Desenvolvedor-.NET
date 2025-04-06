
using AutoMapper;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;

namespace TesteDesenvolvedor.Application.Services
{
    public class InscricaoService : IInscricaoService
    {
        private readonly IMapper _mapper;
        private IInscricaoRepository _repository;
        public InscricaoService(IInscricaoRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Add(InscricaoDTO inscricaoDTO)
        {
            var inscricaoEntity = _mapper.Map<Inscricao>(inscricaoDTO);
            await _repository.Add(inscricaoEntity);
        }

        public async Task Delete(int id)
        {
            var categoryEntity = await _repository.GetById(id);
            await _repository.Delete(categoryEntity);
        }

        public async Task<IEnumerable<InscricaoDTO>> GetAll()   
        {
            var categoriesEntity = await _repository.GetAll();
            return _mapper.Map<IEnumerable<InscricaoDTO>>(categoriesEntity);
        }

        public async Task<IEnumerable<InscricaoDTO>> GetByCpf(string cpf)
        {
            var categoriesEntity = await _repository.GetByCpf(cpf);
            return _mapper.Map<IEnumerable<InscricaoDTO>>(categoriesEntity);
        }

        public async Task<InscricaoDTO> GetById(int id)
        {
            var inscricaoEntity = await _repository.GetById(id);
            return _mapper.Map<InscricaoDTO>(inscricaoEntity);
        }

        public async Task<IEnumerable<InscricaoDTO>> GetByOferta(int ofertaId)
        {
            var categoriesEntity = await _repository.GetByOferta(ofertaId);
            return _mapper.Map<IEnumerable<InscricaoDTO>>(categoriesEntity);
        }

        public async Task Update(InscricaoDTO inscricaoDTO)
        {
            var inscricaoEntity = _mapper.Map<Inscricao>(inscricaoDTO); 
            await _repository.Update(inscricaoEntity);
        }
    }
}
