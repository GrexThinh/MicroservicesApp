using Microservices.Services.RewardAPI.Message;

namespace Microservices.Services.RewardAPI.Service
{
    public interface IRewardService
    {
        Task UpdateRewards (RewardsMessage rewardsMessage);
    }
}
