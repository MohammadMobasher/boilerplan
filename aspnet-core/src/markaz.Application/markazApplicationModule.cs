
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using markaz.Authorization;

namespace markaz
{
    [DependsOn(
        typeof(markazCoreModule), 
        typeof(AbpAutoMapperModule)
        )]
    public class markazApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<markazAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(markazApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
