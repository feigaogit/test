using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompany.IdentityServer.MultiTenancy.Dto;

namespace MyCompany.IdentityServer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

