using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services;
using ArenaPhysics.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArenaPhysics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User,Admin")]
    public class UserProblemController : ControllerBase
    {
        private readonly IUserProblemService _userProblemService;

        public UserProblemController(IUserProblemService userProblemService)
        {
            _userProblemService = userProblemService;
        }

        // GET api/<UserProblemController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserProblemResponseDTO>> GetUserProblem(int id)
        {
            return await _userProblemService.GetUserProblemByIdAsync(id);
        }

        // POST api/<UserProblemController>
        [HttpPost]
        public async Task<ActionResult<UserProblemResponseDTO>> PostUserProblem(UserProblemRequestDTO userProblem)
        {
            await _userProblemService.AddUserProblemAsync(userProblem);
            return CreatedAtAction("GetUserProblem", new { id = userProblem.Id }, userProblem);
        }

        // PUT api/<UserProblemController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserProblem(int id, UserProblemRequestDTO userProblem)
        {
            if (id != userProblem.Id)
            {
                return BadRequest();
            }

            await _userProblemService.UpdateUserProblemAsync(userProblem);
            return NoContent();
        }
    }
}
