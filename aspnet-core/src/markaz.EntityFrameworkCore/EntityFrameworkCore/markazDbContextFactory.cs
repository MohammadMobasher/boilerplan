using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using markaz.Configuration;
using markaz.Web;

namespace markaz.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class markazDbContextFactory : IDesignTimeDbContextFactory<markazDbContext>
    {
        public markazDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<markazDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            markazDbContextConfigurer.Configure(builder, configuration.GetConnectionString(markazConsts.ConnectionStringName));

            return new markazDbContext(builder.Options);
        }
    }
}
