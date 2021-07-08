using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using markaz.Configuration;
using markaz.EntityFrameworkCore;

namespace markaz.Web.Host.Startup
{
    [DependsOn(
       typeof(markazWebCoreModule)
       )]
    public class markazWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public markazWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(markazWebHostModule).GetAssembly());
        }
    }
}
