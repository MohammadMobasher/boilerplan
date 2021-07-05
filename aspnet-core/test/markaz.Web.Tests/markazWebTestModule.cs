using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using markaz.EntityFrameworkCore;
using markaz.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace markaz.Web.Tests
{
    [DependsOn(
        typeof(markazWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class markazWebTestModule : AbpModule
    {
        public markazWebTestModule(markazEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(markazWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(markazWebMvcModule).Assembly);
        }
    }
}