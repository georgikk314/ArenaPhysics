using ArenaPhysics.Data.Enums;
using ArenaPhysics.DTOs.Abstractions;

namespace ArenaPhysics.DTOs.Requests
{
    public class ProblemRequestDTO : BaseRequestDTO
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
        public string Answer { get; set; }//formula1|formula2|...
        public string OfficialAnswers { get; set; } //filename
    }
}
