using Abp.MultiTenancy;
using MyCompany.IdentityServer.Authorization.Users;

namespace MyCompany.IdentityServer.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
