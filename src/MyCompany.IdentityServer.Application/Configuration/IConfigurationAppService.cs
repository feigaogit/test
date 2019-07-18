using System.Threading.Tasks;
using MyCompany.IdentityServer.Configuration.Dto;

namespace MyCompany.IdentityServer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
