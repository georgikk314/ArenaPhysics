using ArenaPhysics.Data.Entities;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArenaPhysics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User,Admin")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET api/Problem/<CommentController>/5
        [HttpGet("Problem/{problemId}")]
        public async Task<ActionResult<List<CommentResponseDTO>>> GetCommentsByProblemId(int problemId)
        {
            return await _commentService.GetCommentsByProblemIdAsync(problemId);
        }

        [HttpGet("{commentId}")]
        public async Task<ActionResult<CommentResponseDTO>> GetComment(int commentId)
        {
            return await _commentService.GetCommentByIdAsync(commentId);
        }

        // POST api/<CommentController>
        [HttpPost]
        public async Task<ActionResult<CommentResponseDTO>> PostComment(CommentRequestDTO comment)
        {
            await _commentService.AddCommentAsync(comment);
            return NoContent();
        }

        // PUT api/<CommentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment(int id, CommentRequestDTO comment)
        {
            if(comment.Id != id)
            {
                return BadRequest();
            }

            await _commentService.UpdateCommentAsync(comment);
            return NoContent();
        }

        // DELETE api/<CommentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _commentService.DeleteCommentByIdAsync(id);
            return NoContent();
        }
    }
}
