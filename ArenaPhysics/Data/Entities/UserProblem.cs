using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace ArenaPhysics.Data.Entities
{
    public class UserProblem : BaseEntity
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        [ForeignKey(nameof(Problem))]
        public int ProblemId { get; set; }
        public double Points { get; set; }
        public string PointsDistribution { get; set; }
        public bool IsSolved { get; set; }
        public string UserAnswer { get; set; } //formula1|formula2|....
        public string? UserAnswerFileName { get; set; }
        //public virtual List<Problem>? Problems { get; set; }
        //public virtual List<User>? Users { get; set; }
    }
}
