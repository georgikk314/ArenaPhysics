using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Requests;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArenaPhysics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfigurationSection _jwtSettings;

        public AuthController(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _jwtSettings = configuration.GetSection("JwtSettings");
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(UserRequestDTO userModel)
        {
            var authUser = await _userManager.FindByNameAsync(userModel.Username);

            if (authUser != null && await _userManager.CheckPasswordAsync(authUser, userModel.Password))
            {
                var signingCredentials = GetSigningCredentials();
                var claims = GetClaims(authUser);
                var tokenOptions = GenerateTokenOptions(signingCredentials, await claims);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(token);
            }
            else
            {
                return Unauthorized("Invalid Auth");
            }

        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(UserRegisterRequestDTO userModel)
        {
            var user = new User()
            {
                Username = userModel.Username,
                Email = userModel.Email,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Age = userModel.Age,
                DateOfCreation = userModel.DateOfCreation,
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
            var userCreated = await _userManager.CreateAsync(user, userModel.Password);

            if (userCreated.Succeeded)
            {
                // Assign roles after successful user creation
                
                var userRole = "User";
                if (user.Username == "admin")
                {
                    userRole = "Admin";
                }

                await _userManager.AddToRoleAsync(user, userRole);

                return StatusCode(201);
            }
            else
            {
                return BadRequest(userCreated.Errors);
            }
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtSettings.GetSection("validIssuer").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings.GetSection("expiryInMinutes").Value)),
                signingCredentials: signingCredentials
                );
            return tokenOptions;
        }

        private async Task<List<Claim>> GetClaims(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtSettings.GetSection("securityKey").Value);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
    }
}
