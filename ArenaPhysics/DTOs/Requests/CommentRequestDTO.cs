using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArenaPhysics.DTOs.Requests
{
    public class CommentRequestDTO : BaseRequestDTO
    {
        public int UserId { get; set; }
        public int ProblemId { get; set; }
        public string Content { get; set; }
    }
}
