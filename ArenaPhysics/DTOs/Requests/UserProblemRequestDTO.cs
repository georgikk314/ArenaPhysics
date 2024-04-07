using ArenaPhysics.DTOs.Abstractions;

namespace ArenaPhysics.DTOs.Requests
{
    public class UserProblemRequestDTO : BaseRequestDTO
    {
        public double Points { get; set; }
        public bool isSolved { get; set; }
        public string? UserAnswerFileName { get; set; }
        public string MyProperty { get; set; }
    }
}
