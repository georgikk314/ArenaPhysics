using Microsoft.AspNetCore.Identity;

namespace ArenaPhysics.Data.Entities
{
    public class User : IdentityUser
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfCreation { get; set; }
        public double ProblemsPoints { get; set; }
        public int NumberOfProblemsSolved { get; set; }
        public double MechProblemsPoints { get; set; }
        public int MechProblemsSolved { get; set; }
        public double ElecProblemsPoints { get; set; }
        public int ElecProblemsSolved { get; set; }
        public double ThermoProblemsPoints { get; set; }
        public int ThermoProblemsSolved { get; set; }
        public double OpticsProblemsPoints { get; set; }
        public int OpticsProblemsSolved { get; set; }
        public double WavesProblemsPoints { get; set; }
        public int WavesProblemsSolved { get; set; }
        public double RelProblemsPoints { get; set; }
        public int RelProblemsSolved { get; set; }
        public double ModernProblemsPoints { get; set; }
        public int ModernProblemsSolved { get; set; }
        public double EasyProblemsPoints { get; set; }
        public int EasyProblemsSolved { get; set; }
        public double MediumProblemsPoints { get; set; }
        public int MediumProblemsSolved { get; set; }
        public double HardProblemsPoints { get; set; }
        public int HardProblemsSolved { get; set; }
        public double VeryHardProblemsPoints { get; set; }
        public int VeryHardProblemsSolved { get; set; }
        public int SeventhGradeProblemsSolved { get; set; }
        public int EighthGradeProblemsSolved { get; set; }
        public int NinthGradeProblemsSolved { get; set; }
        public int TenthGradeProblemsSolved { get; set; }
        public int EleventhGradeProblemsSolved { get; set; }
        public int TwelvethGradeProblemsSolved { get; set; }
        public int SpecialProblemsSolved { get; set; }
        public int InternationalCompetitionsProblemsSolved { get; set; }
        public virtual List<UserProblem>? UserProblems { get; set; }
        public virtual List<Comment>? Comments { get; set; }
    }
}
