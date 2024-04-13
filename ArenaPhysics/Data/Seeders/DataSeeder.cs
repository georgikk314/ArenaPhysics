using ArenaPhysics.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace ArenaPhysics.Data.Seeders
{
    public class DataSeeder
    {
        public static async Task SeedRolesAndUsers(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            // Seed roles
            await SeedRoles(roleManager);

            // Seed users
            await SeedUsers(userManager);
        }

        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            // Check if roles exist, if not create them
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await roleManager.RoleExistsAsync("User"))
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
        }

        private static async Task SeedUsers(UserManager<User> userManager)
        {
            // Check if admin user exists, if not create it
            var adminUser = await userManager.FindByNameAsync("admin");
            if (adminUser == null)
            {
                var newAdminUser = new User
                {
                    UserName = "admin",
                    Email = "gogomen2005@gmail.com",
                    FirstName = "Georgi",
                    LastName = "Kostadinov",
                    Age = 18,
                    DateOfCreation = DateTime.Now,
                    ProblemsPoints = 0.0,
                    NumberOfProblemsSolved = 0,
                    MechProblemsPoints = 0.0,
                    MechProblemsSolved = 0,
                    ElecProblemsPoints = 0.0,
                    ElecProblemsSolved = 0,
                    ThermoProblemsPoints = 0.0,
                    ThermoProblemsSolved = 0,
                    OpticsProblemsPoints = 0.0,
                    OpticsProblemsSolved = 0,
                    WavesProblemsPoints = 0.0,
                    WavesProblemsSolved = 0,
                    RelProblemsPoints = 0.0,
                    RelProblemsSolved = 0,
                    ModernProblemsPoints = 0.0,
                    ModernProblemsSolved = 0,
                    EasyProblemsPoints = 0.0,
                    EasyProblemsSolved = 0,
                    MediumProblemsPoints = 0.0,
                    MediumProblemsSolved = 0,
                    HardProblemsPoints = 0.0,
                    HardProblemsSolved = 0,
                    VeryHardProblemsPoints = 0.0,
                    VeryHardProblemsSolved = 0,
                    SeventhGradeProblemsSolved = 0,
                    EighthGradeProblemsSolved = 0,
                    NinthGradeProblemsSolved = 0,
                    TenthGradeProblemsSolved = 0,
                    EleventhGradeProblemsSolved = 0,
                    TwelvethGradeProblemsSolved = 0,
                    SpecialProblemsSolved = 0,
                    InternationalCompetitionsProblemsSolved = 0
                };
                var result = await userManager.CreateAsync(newAdminUser, "AdminPassword123!"); // Set your desired password
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newAdminUser, "Admin");
                }
                else
                {
                    throw new Exception();
                }
            }

            // Check if regular user exists, if not create it
            var regularUser = await userManager.FindByNameAsync("user");
            if (regularUser == null)
            {
                var newRegularUser = new User
                {
                    UserName = "user",
                    Email = "user@abv.bg",
                    FirstName = "Delyan",
                    LastName = "Peevski",
                    Age = 30,
                    DateOfCreation = DateTime.Now,
                    ProblemsPoints = 0.0,
                    NumberOfProblemsSolved = 0,
                    MechProblemsPoints = 0.0,
                    MechProblemsSolved = 0,
                    ElecProblemsPoints = 0.0,
                    ElecProblemsSolved = 0,
                    ThermoProblemsPoints = 0.0,
                    ThermoProblemsSolved = 0,
                    OpticsProblemsPoints = 0.0,
                    OpticsProblemsSolved = 0,
                    WavesProblemsPoints = 0.0,
                    WavesProblemsSolved = 0,
                    RelProblemsPoints = 0.0,
                    RelProblemsSolved = 0,
                    ModernProblemsPoints = 0.0,
                    ModernProblemsSolved = 0,
                    EasyProblemsPoints = 0.0,
                    EasyProblemsSolved = 0,
                    MediumProblemsPoints = 0.0,
                    MediumProblemsSolved = 0,
                    HardProblemsPoints = 0.0,
                    HardProblemsSolved = 0,
                    VeryHardProblemsPoints = 0.0,
                    VeryHardProblemsSolved = 0,
                    SeventhGradeProblemsSolved = 0,
                    EighthGradeProblemsSolved = 0,
                    NinthGradeProblemsSolved = 0,
                    TenthGradeProblemsSolved = 0,
                    EleventhGradeProblemsSolved = 0,
                    TwelvethGradeProblemsSolved = 0,
                    SpecialProblemsSolved = 0,
                    InternationalCompetitionsProblemsSolved = 0
                };
                var result = await userManager.CreateAsync(newRegularUser, "UserPassword123!"); // Set your desired password
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newRegularUser, "User");
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
