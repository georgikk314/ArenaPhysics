using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArenaPhysics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User,Admin")]
    public class ProblemController : ControllerBase
    {

        private readonly IProblemService _problemService;

        public ProblemController(IProblemService problemService)
        {
            _problemService = problemService;
        }

        // GET api/<ProblemController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "User,Admin")]
        public async Task<ActionResult<ProblemResponseDTO>> GetProblem(int id)
        {
            return await _problemService.GetProblemByIdAsync(id);
        }
        
        // POST api/<ProblemController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<ProblemResponseDTO>> PostProblem(ProblemRequestDTO problem)
        {
            await _problemService.AddProblemAsync(problem);
            return CreatedAtAction("GetProblem", new { id = problem.Id }, problem);
        }

        // PUT api/<ProblemController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutProblem(int id, ProblemRequestDTO problem)
        {
            if (problem.Id != id)
            {
                return BadRequest();
            }    
            await _problemService.UpdateProblemAsync(problem);
            return NoContent();
        }

    }
}
