using System.ComponentModel.DataAnnotations;

namespace ArenaPhysics.Data.Enums
{
    public enum Competition
    {
        [Display(Name = "Autumn Physics Competition")]
        ESENNI = 0,
        [Display(Name = "Spring Physics Competition")]
        PROLETNI = 1,
        [Display(Name = "National Physics Olympiad Final Round")]
        NACKRUG = 2,
        [Display(Name = "National Team Selection Test")]
        PODBOR = 3,
        [Display(Name = "International Olympiad in Physics")]
        IPHO = 4,
        [Display(Name = "Russian Olympiad in Physics")]
        RPHO = 5,
        [Display(Name = "American Olympiad in Physics")]
        USAPHO = 6,
        [Display(Name = "Other")]
        OTHER = 7
    }
}
