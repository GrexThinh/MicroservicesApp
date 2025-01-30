using Microservices.Services.EmailAPI.Message;
using Microservices.Services.EmailAPI.Models.Dto;

namespace Microservices.Services.EmailAPI.Service
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
