using AutoMapper;
using TesteDesenvolvedor.Application.DTOs;
using TesteDesenvolvedor.Domain.Entities;

namespace TesteDesenvolvedor.Application.Mappings
{
    public class MappingDtoEntity : Profile
    {
        public MappingDtoEntity()
        {
            CreateMap<Inscricao, InscricaoDTO>().ReverseMap();
            CreateMap<Lead, LeadDTO>().ReverseMap();
            CreateMap<Oferta, OfertaDTO>().ReverseMap();
            CreateMap<ProcessoSeletivo, ProcessoSeletivoDTO>().ReverseMap();
        }
    }
}
