using ArenaPhysics.Data.Entities;
using ArenaPhysics.Data.Repositories.Abstractions;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services.Abstractions;
using AutoMapper;

namespace ArenaPhysics.Services
{
    public class UserProblemService : IUserProblemService
    {
        private readonly IRepository<UserProblem> _repository;
        private readonly IMapper _mapper;
        public UserProblemService(IRepository<UserProblem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task AddUserProblemAsync(UserProblemRequestDTO userProblem)
        {
            var entity = _mapper.Map<UserProblem>(userProblem);

            return _repository.AddAsync(entity);
        }

        public async Task<UserProblemResponseDTO> GetUserProblemByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<UserProblemResponseDTO>(entity);
        }


        public Task UpdateUserProblemAsync(UserProblemRequestDTO userProblem)
        {
            var entity = _mapper.Map<UserProblem>(userProblem);
            return _repository.UpdateAsync(entity);
        }
    }
}
