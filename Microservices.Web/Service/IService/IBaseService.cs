using Microservices.Web.Models;
using MicroservicesApp.Web.Models;

namespace Microservices.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto>? SendAsync(RequestDto requestDto, bool withBearer = true);

    }
}
