using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using AutoMapper;

namespace ArenaPhysics.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentResponseDTO>();
            CreateMap<CommentRequestDTO, Comment>();
        }
    }
}
