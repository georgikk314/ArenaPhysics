using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;

namespace ArenaPhysics.Services.Abstractions
{
    public interface IProblemService
    {
        Task<ProblemResponseDTO> GetProblemByIdAsync(int id); // see problem
        Task AddProblemAsync(ProblemRequestDTO problem); // add problem
        Task UpdateProblemAsync(ProblemRequestDTO problem); // edit problem
    }
}
