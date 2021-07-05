using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace markaz.EntityFrameworkCore
{
    public static class markazDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<markazDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<markazDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
