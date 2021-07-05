using System.Threading.Tasks;
using Abp.Application.Services;
using markaz.Sessions.Dto;

namespace markaz.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
