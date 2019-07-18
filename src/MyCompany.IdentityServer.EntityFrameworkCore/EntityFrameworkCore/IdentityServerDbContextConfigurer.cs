using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.IdentityServer.EntityFrameworkCore
{
    public static class IdentityServerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IdentityServerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString, t => t.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<IdentityServerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection, t => t.UseRowNumberForPaging());
        }
    }
}
