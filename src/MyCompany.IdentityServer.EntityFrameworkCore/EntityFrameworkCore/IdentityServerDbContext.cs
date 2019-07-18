using Abp.IdentityServer4;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCompany.IdentityServer.Authorization.Roles;
using MyCompany.IdentityServer.Authorization.Users;
using MyCompany.IdentityServer.MultiTenancy;

namespace MyCompany.IdentityServer.EntityFrameworkCore
{
    public class IdentityServerDbContext : AbpZeroDbContext<Tenant, Role, User, IdentityServerDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define a DbSet for each entity of the application */
        
        public IdentityServerDbContext(DbContextOptions<IdentityServerDbContext> options)
            : base(options)
        {
        }

        public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
