using Abp.Authorization;
using MyCompany.IdentityServer.Authorization.Roles;
using MyCompany.IdentityServer.Authorization.Users;

namespace MyCompany.IdentityServer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
