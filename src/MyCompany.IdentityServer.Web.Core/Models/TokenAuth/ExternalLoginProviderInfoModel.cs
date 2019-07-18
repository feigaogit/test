using Abp.AutoMapper;
using MyCompany.IdentityServer.Authentication.External;

namespace MyCompany.IdentityServer.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
