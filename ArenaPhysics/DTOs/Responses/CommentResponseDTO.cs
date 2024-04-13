using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArenaPhysics.DTOs.Responses
{
    public class CommentResponseDTO : BaseResponseDTO
    {
        public string UserName { get; set; }
        public int ProblemId { get; set; }
        public string Content { get; set; }
    }
}
