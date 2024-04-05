using System.ComponentModel.DataAnnotations;

namespace ArenaPhysics.Data.Enums
{
    public enum Branch
    {
        [Display(Name = "Mechanics")]
        MECH = 0,
        [Display(Name = "Electricity and magnetism")]
        ELEC = 1,
        [Display(Name = "Thermodynamics and statistical physics")]
        THERMO = 2,
        [Display(Name = "Geometrical and wave optics")]
        OPTICS = 3,
        [Display(Name = "Waves theory")]
        WAVES = 4,
            [Display(Name = "General theory of relativity")]
        RELATIVITY = 5,
        [Display(Name = "Modern Physics")]
        MODERN = 6,
        [Display(Name = "Other")]
        OTHER = 7
    }
}
