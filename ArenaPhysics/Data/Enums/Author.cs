using System.ComponentModel.DataAnnotations;

namespace ArenaPhysics.Data.Enums
{
    public enum Author
    {
        [Display(Name = "Miroslav Abrashev")]
        MA = 0,
        [Display(Name = "Viktor Ivanov")]
        VI = 1,
        [Display(Name = "Dimitar Marvakov")]
        DM = 2,
        [Display(Name = "Maksim Maksimov")]
        MM = 3,
        [Display(Name = "Svetoslav Ivanov")]
        SI = 4,
        [Display(Name = "Luchezar Simeonov")]
        LS = 5,
        [Display(Name = "Dimo Arnaudov")]
        DA = 6,
        [Display(Name = "Ivan Petkov")]
        IP = 7,
        [Display(Name = "Maya Zhekova")]
        MZ = 8,
        [Display(Name = "Teodosii Teodosiev")]
        TT = 9,
        [Display(Name = "International Author")]
        INTERNATIONAL = 10,
        [Display(Name = "Unknown")]
        UNKNOWN = 11,
        [Display(Name = "Other")]
        OTHER = 12
    }
}
