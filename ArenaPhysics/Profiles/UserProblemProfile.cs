using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using AutoMapper;

namespace ArenaPhysics.Profiles
{
    public class UserProblemProfile : Profile
    {
        public UserProblemProfile()
        {
            CreateMap<UserProblem, UserProblemResponseDTO>();
            CreateMap<UserProblemRequestDTO, UserProblem>();
        }
    }
}
