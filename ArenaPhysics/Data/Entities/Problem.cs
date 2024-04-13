using ArenaPhysics.Data.Enums;

namespace ArenaPhysics.Data.Entities
{
    public class Problem : BaseEntity
    {
        public Branch Branches { get; set; }
        public Difficulty Difficulty { get; set; }
        public Author Author { get; set; }
        public string ProblemCode { get; set; }
        public int Year { get; set; }
        public int Grade { get; set; }
        public Competition CompetitionName { get; set; }
        public string ProblemFileName { get; set; }
        public string AdditionalInformation { get; set; }
        public int NumberOfFormulas { get; set; }
        public string PointsDistribution { get; set; } //1.3|2.2|....
        public string Answer { get; set; }//formula1|formula2|...
        public string OfficialAnswers { get; set; } //filename
        public virtual List<UserProblem>? UserProblems { get; set; }
        public virtual List<Comment>? Comments { get; set; }

    }
}
