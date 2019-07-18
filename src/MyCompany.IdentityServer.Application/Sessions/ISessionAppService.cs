using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompany.IdentityServer.Sessions.Dto;

namespace MyCompany.IdentityServer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
