using ArenaPhysics.Data.Entities;
using ArenaPhysics.Data.Repositories.Abstractions;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ArenaPhysics.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _repository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        public CommentService(IRepository<Comment> repository, IMapper mapper, UserManager<User> userManager)
        {
            _repository = repository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task AddCommentAsync(CommentRequestDTO comment)
        {
            var user = await _userManager.FindByNameAsync(comment.UserName);
            var entity = new Comment()
            {
                UserId = user.Id,
                ProblemId = comment.ProblemId,
                Content = comment.Content
            };

            await _repository.AddAsync(entity);
        }

        public async Task<List<CommentResponseDTO>> GetCommentsByProblemIdAsync(int problemId)
        {
            var list = await _repository.GetAsync(item => item.ProblemId == problemId);
            return _mapper.Map<List<CommentResponseDTO>>(list);
        }

        public async Task<CommentResponseDTO> GetCommentByIdAsync(int commentId)
        {
            var item = await _repository.GetByIdAsync(commentId);
            return _mapper.Map<CommentResponseDTO>(item);
        }


        public async Task UpdateCommentAsync(CommentRequestDTO comment)
        {
            var user = await _userManager.FindByNameAsync(comment.UserName);
            var entity = new Comment()
            {
                Id = comment.Id,
                UserId = user.Id,
                ProblemId = comment.ProblemId,
                Content = comment.Content
            };

            await _repository.UpdateAsync(entity);
        }

        public Task DeleteCommentByIdAsync(int id)
        {
            return _repository.DeleteByIdAsync(id);
        }
    }
}
