using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompany.IdentityServer.Authorization.Accounts.Dto;

namespace MyCompany.IdentityServer.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
