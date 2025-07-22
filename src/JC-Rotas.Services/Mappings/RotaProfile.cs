using AutoMapper;
using JC_Rotas.Domain.Entities;
using JC_Rotas.Services.DTOs;

namespace JC_Rotas.Services.Mappings
{
    public class RotaProfile : Profile
    {
        public RotaProfile()
        {
            CreateMap<Rota, RotaResponse>().ReverseMap();
            CreateMap<RotaCreateRequest, Rota>().ReverseMap();
        }
    }
}
