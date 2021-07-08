using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Castle.Windsor.MsDependencyInjection;
using markaz.EntityFrameworkCore.Seed;
using markaz.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;

namespace markaz.EntityFrameworkCore
{
    [DependsOn(
        typeof(markazCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class markazEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {

            //Configuration.Modules.AbpEfCore().AddDbContext<markazDbContext>(options => options.UseSql("Data Source=conferences.db"));


            //if (!SkipDbContextRegistration)
            //{

            //    Configuration.Modules.AbpEfCore().AddDbContext<markazDbContext>(options =>
            //    {
            //        if (options.ExistingConnection != null)
            //        {
            //            markazDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
            //        }
            //        else
            //        {
            //            markazDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
            //        }
            //    });
            //}
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(markazEntityFrameworkModule).GetAssembly());
            //IocManager.Register(typeof(markazDbContext), Abp.Dependency.DependencyLifeStyle.Transient);

            //var services = new ServiceCollection();

            //IdentityRegistrar.Register(services);


            //var serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);

            //var builder = new DbContextOptionsBuilder<markazDbContext>();

            //// This line is for db context registration

            //IocManager.IocContainer.Register(
            //    Component
            //        .For<DbContextOptions<markazDbContext>>()
            //        .Instance(builder.Options)
            //        .LifestyleSingleton()
            //);
        }

        public override void PostInitialize()
        {
            //if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
