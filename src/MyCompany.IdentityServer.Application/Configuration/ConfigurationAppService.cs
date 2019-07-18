using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyCompany.IdentityServer.Configuration.Dto;

namespace MyCompany.IdentityServer.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : IdentityServerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
