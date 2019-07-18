using Abp.Application.Services.Dto;

namespace MyCompany.IdentityServer.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

