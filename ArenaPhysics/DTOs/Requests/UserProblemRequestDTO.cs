using ArenaPhysics.DTOs.Abstractions;

namespace ArenaPhysics.DTOs.Requests
{
    public class UserProblemRequestDTO : BaseRequestDTO
    {
        public int UserId { get; set; }
        public int ProblemId { get; set; }
        public double Points { get; set; }
        public bool isSolved { get; set; }
        public string? UserAnswerFileName { get; set; }
        public string MyProperty { get; set; }
    }
}
