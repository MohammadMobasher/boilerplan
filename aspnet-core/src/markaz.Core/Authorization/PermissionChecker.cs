using Abp.Authorization;
using markaz.Authorization.Roles;
using markaz.Authorization.Users;

namespace markaz.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
