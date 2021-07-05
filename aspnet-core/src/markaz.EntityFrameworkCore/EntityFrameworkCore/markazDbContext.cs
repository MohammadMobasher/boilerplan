using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using markaz.Authorization.Roles;
using markaz.Authorization.Users;
using markaz.MultiTenancy;
using markaz.TestTable;


namespace markaz.EntityFrameworkCore
{
    public class markazDbContext : AbpZeroDbContext<Tenant, Role, User, markazDbContext>
    {
        /* Define a DbSet for each entity of the application */

        
        public virtual DbSet<TestTbl> TestTbl { get; set; }


        public markazDbContext(DbContextOptions<markazDbContext> options)
            : base(options)
        {
        }

        
    }
}
