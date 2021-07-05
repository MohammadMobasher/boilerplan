using Abp.Application.Services;
using markaz.MultiTenancy.Dto;

namespace markaz.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

