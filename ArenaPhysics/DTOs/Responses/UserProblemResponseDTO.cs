using ArenaPhysics.DTOs.Abstractions;

namespace ArenaPhysics.DTOs.Responses
{
    public class UserProblemResponseDTO : BaseResponseDTO
    {
        public double Points { get; set; }
        public bool isSolved { get; set; }
        public string PointsDistribution { get; set; }
        public string? UserAnswerFileName { get; set; }
        public string MyProperty { get; set; }
    }
}
