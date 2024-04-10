using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using AutoMapper;

namespace ArenaPhysics.Profiles
{
    public class ProblemProfile : Profile
    {
        public ProblemProfile()
        {
            CreateMap<Problem, ProblemResponseDTO>();
            CreateMap<ProblemRequestDTO, Problem>();
        }
    }
}
