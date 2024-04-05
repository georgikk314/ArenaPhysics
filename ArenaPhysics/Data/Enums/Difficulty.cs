using System.ComponentModel.DataAnnotations;

namespace ArenaPhysics.Data.Enums
{
    public enum Difficulty
    {
        [Display(Name = "Easy")]
        EASY = 0,
        [Display(Name = "Medium")]
        MEDIUM = 1,
        [Display(Name = "Hard")]
        HARD = 2,
        [Display(Name = "Very hard")]
        VERYHARD = 3
    }
}
