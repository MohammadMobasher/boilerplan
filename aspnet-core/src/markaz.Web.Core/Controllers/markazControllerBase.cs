using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace markaz.Controllers
{
    public abstract class markazControllerBase: AbpController
    {
        protected markazControllerBase()
        {
            LocalizationSourceName = markazConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
