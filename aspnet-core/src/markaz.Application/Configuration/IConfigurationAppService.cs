using System.Threading.Tasks;
using markaz.Configuration.Dto;

namespace markaz.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
