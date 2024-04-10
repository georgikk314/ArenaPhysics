using ArenaPhysics.Data.Entities;
using ArenaPhysics.Data.Repositories.Abstractions;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services.Abstractions;
using AutoMapper;

namespace ArenaPhysics.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _repository;
        private readonly IMapper _mapper;
        public CommentService(IRepository<Comment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task AddCommentAsync(CommentRequestDTO comment)
        {
            var entity = _mapper.Map<Comment>(comment);

            return _repository.AddAsync(entity);
        }

        public async Task<List<CommentResponseDTO>> GetCommentsByProblemIdAsync(int problemId)
        {
            var list = await _repository.GetAsync(item => item.ProblemId == problemId);
            return _mapper.Map<List<CommentResponseDTO>>(list);
        }


        public Task UpdateCommentAsync(CommentRequestDTO comment)
        {
            var entity = _mapper.Map<Comment>(comment);
            return _repository.UpdateAsync(entity);
        }

        public Task DeleteCommentByIdAsync(int id)
        {
            return _repository.DeleteByIdAsync(id);
        }
    }
}
