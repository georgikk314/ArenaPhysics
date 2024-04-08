using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Abstractions;
using AutoMapper;

namespace ArenaPhysics.Profiles
{
    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            CreateMap<BaseEntity, BaseResponseDTO>();
            CreateMap<BaseRequestDTO, BaseEntity>();
        }
    }
}
