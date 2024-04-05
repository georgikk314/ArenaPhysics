using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace ArenaPhysics.Data.Entities
{
    public class UserProblem
    {
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        [ForeignKey(nameof(Problem))]
        public int ProblemId { get; set; }
        public double Points { get; set; }
        public bool IsSolved { get; set; }
        public string? UserAnswerFileName { get; set; }
        //public virtual List<Problem>? Problems { get; set; }
        //public virtual List<User>? Users { get; set; }
    }
}
