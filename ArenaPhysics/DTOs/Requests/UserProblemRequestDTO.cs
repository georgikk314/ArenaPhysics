using ArenaPhysics.DTOs.Abstractions;

namespace ArenaPhysics.DTOs.Requests
{
    public class UserProblemRequestDTO : BaseRequestDTO
    {
        public string UserName { get; set; }
        public int ProblemId { get; set; }
        public string? UserAnswerFileName { get; set; }
        public string UserAnswer { get; set; }
    }
}
