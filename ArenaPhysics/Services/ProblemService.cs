using ArenaPhysics.Data.Entities;
using ArenaPhysics.Data.Repositories.Abstractions;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services.Abstractions;
using AutoMapper;

namespace ArenaPhysics.Services
{
    public class ProblemService : IProblemService
    {
        private readonly IRepository<Problem> _repository;
        private readonly IMapper _mapper;
        public ProblemService(IRepository<Problem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task AddProblemAsync(ProblemRequestDTO problem)
        {
            var entity = _mapper.Map<Problem>(problem);

            return _repository.AddAsync(entity);
        }

        public async Task<ProblemResponseDTO> GetProblemByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<ProblemResponseDTO>(entity);
        }


        public Task UpdateProblemAsync(ProblemRequestDTO problem)
        {
            var entity = _mapper.Map<Problem>(problem);
            return _repository.UpdateAsync(entity);
        }
    }
}
