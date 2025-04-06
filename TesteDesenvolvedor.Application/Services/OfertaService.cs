
using AutoMapper;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Application.Interfaces;
using TesteDesenvolvedor.Domain.Entities;
using TesteDesenvolvedor.Domain.Interfaces;

namespace TesteDesenvolvedor.Application.Services
{
    public class OfertaService : IOfertaService
    {
        private readonly IMapper _mapper;
        private IOfertaRepository _repository;
        public OfertaService(IOfertaRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Add(OfertaDTO ofertaDTO)
        {
            var ofertaEntity = _mapper.Map<Oferta>(ofertaDTO);
            await _repository.Add(ofertaEntity);
        }

        public async Task Delete(int id)
        {
            var ofertaEntity = await _repository.GetById(id);
            await _repository.Delete(ofertaEntity);
        }

        public async Task<IEnumerable<OfertaDTO>> GetAll()
        {
            var ofertaEntity = await _repository.GetAll();
            return _mapper.Map<IEnumerable<OfertaDTO>>(ofertaEntity);
        }

        public async Task<OfertaDTO> GetById(int id)
        {
            var ofertaEntity = await _repository.GetById(id);
            return _mapper.Map<OfertaDTO>(ofertaEntity);
        }

        public async Task Update(OfertaDTO ofertaDTO)
        {
            var ofertaEntity = _mapper.Map<Oferta>(ofertaDTO);
            await _repository.Update(ofertaEntity);
        }
    }
}
