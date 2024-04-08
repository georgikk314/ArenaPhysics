using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;

namespace ArenaPhysics.Services.Abstractions
{
    public interface IUserProblemService
    {
        Task<UserProblemResponseDTO> GetUserProblemByIdAsync(int id);
        Task AddUserProblemAsync(UserProblemRequestDTO userProblem); // send a solution
        Task UpdateUserProblemAsync(UserProblemRequestDTO userProblem); // edit a solution
    }
}
