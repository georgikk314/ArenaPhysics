using ArenaPhysics.Data;
using ArenaPhysics.Data.Entities;
using ArenaPhysics.Data.Repositories.Abstractions;
using ArenaPhysics.DTOs.Requests;
using ArenaPhysics.DTOs.Responses;
using ArenaPhysics.Services.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Constraints;

namespace ArenaPhysics.Services
{
    public class UserProblemService : IUserProblemService
    {
        private readonly IRepository<UserProblem> _repository;
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        public UserProblemService(IRepository<UserProblem> repository, IMapper mapper, AppDbContext dbContext, UserManager<User> userManager)
        {
            _repository = repository;
            _mapper = mapper;
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task AddUserProblemAsync(UserProblemRequestDTO userProblem)
        {
           

            var problem = _dbContext.Problems.Where(p => p.Id == userProblem.ProblemId).FirstOrDefault();
            var problemAnswers = problem.Answer.Split('|').ToArray();
            var userProblemAnswers = userProblem.UserAnswer.Split('|').ToArray();
            var pointsDistributionInString = problem.PointsDistribution.Split("|").ToArray();
            int numberOfFormulas = problem.NumberOfFormulas;
            double[] pointsDistribution = new double[numberOfFormulas];
            double problemTotalPoints = 0.0;
            double totalPoints = 0.0;
            double[] userPointsDistribution = new double[numberOfFormulas];
            string userPointsDistributionInString = "";

            for (int i = 0; i < numberOfFormulas; i++)
            {
                pointsDistribution[i] = double.Parse(pointsDistributionInString[i]);
                problemTotalPoints += pointsDistribution[i];
                userPointsDistribution[i] = 0.0;
            }
            for (int i = 0; i < numberOfFormulas; i++)
            {
                if (problemAnswers[i] == userProblemAnswers[i])
                {
                    userPointsDistribution[i] = pointsDistribution[i];
                    totalPoints += userPointsDistribution[i];
                    
                }
                else
                {
                    userPointsDistribution[i] = 0.0;
                }

                userPointsDistributionInString += userPointsDistribution[i];
                userPointsDistributionInString += "|";

            }

            userPointsDistributionInString = userPointsDistributionInString.Substring(0, userPointsDistributionInString.Length - 1);
            bool isSolved = false;
            if(totalPoints == problemTotalPoints) { isSolved = true; }

            var userId = _dbContext.Users.Where(u => u.UserName == userProblem.UserName).FirstOrDefault();
            var user = await _userManager.FindByNameAsync(userProblem.UserName);

            var userProblemEntity = new UserProblem()
            {
                Id = userProblem.Id,
                UserId = user.Id,
                ProblemId = userProblem.ProblemId,
                UserAnswer = userProblem.UserAnswer,
                Points = totalPoints,
                PointsDistribution = userPointsDistributionInString,
                IsSolved = isSolved,
                UserAnswerFileName = null,

            };

            await _repository.AddAsync(userProblemEntity);
        }

        public async Task<UserProblemResponseDTO> GetUserProblemByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<UserProblemResponseDTO>(entity);
        }


        public async Task UpdateUserProblemAsync(UserProblemRequestDTO userProblem)
        {
            string? userAnswerFileName = null;
            var problem = _dbContext.Problems.Where(p => p.Id == userProblem.ProblemId).FirstOrDefault();
            var problemAnswers = problem.Answer.Split('|').ToArray();
            var userProblemAnswers = userProblem.UserAnswer.Split('|').ToArray();
            var pointsDistributionInString = problem.PointsDistribution.Split("|").ToArray();
            int numberOfFormulas = problem.NumberOfFormulas;
            double[] pointsDistribution = new double[numberOfFormulas];
            double problemTotalPoints = 0.0;
            double totalPoints = 0.0;
            double[] userPointsDistribution = new double[numberOfFormulas];
            string userPointsDistributionInString = "";

            for (int i = 0; i < numberOfFormulas; i++)
            {
                pointsDistribution[i] = double.Parse(pointsDistributionInString[i]);
                problemTotalPoints += pointsDistribution[i];
                userPointsDistribution[i] = 0.0;
            }
            for (int i = 0; i < numberOfFormulas; i++)
            {
                if (problemAnswers[i] == userProblemAnswers[i])
                {
                    userPointsDistribution[i] = pointsDistribution[i];
                    totalPoints += userPointsDistribution[i];

                }
                else
                {
                    userPointsDistribution[i] = 0.0;
                }

                userPointsDistributionInString += userPointsDistribution[i];
                userPointsDistributionInString += "|";

            }
            userPointsDistributionInString = userPointsDistributionInString.Substring(0, userPointsDistributionInString.Length - 1);
            bool isSolved = false;
            if (totalPoints == problemTotalPoints) { isSolved = true; }

            if(isSolved)
            {
                userAnswerFileName = userProblem.UserAnswerFileName;
            }

            var userId = _dbContext.Users.Where(u => u.UserName == userProblem.UserName).FirstOrDefault();
            var user = await _userManager.FindByNameAsync(userProblem.UserName);

            var userProblemEntity = new UserProblem()
            {
                Id = userProblem.Id,
                UserId = user.Id,
                ProblemId = userProblem.ProblemId,
                UserAnswer = userProblem.UserAnswer,
                Points = totalPoints,
                PointsDistribution = userPointsDistributionInString,
                IsSolved = isSolved,
                UserAnswerFileName = userAnswerFileName,

            };

            await _repository.UpdateAsync(userProblemEntity);
        }
    }
}
