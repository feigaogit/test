﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyCompany.IdentityServer.Configuration;
using MyCompany.IdentityServer.Web;

namespace MyCompany.IdentityServer.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class IdentityServerDbContextFactory : IDesignTimeDbContextFactory<IdentityServerDbContext>
    {
        public IdentityServerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<IdentityServerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IdentityServerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(IdentityServerConsts.ConnectionStringName));

            return new IdentityServerDbContext(builder.Options);
        }
    }
}
