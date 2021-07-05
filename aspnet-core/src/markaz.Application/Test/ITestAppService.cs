using Abp.Application.Services;
using markaz.Test.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.Test
{
    public interface ITestAppService : IAsyncCrudAppService<TestDto, int, PagedTestResultRequestDto, CreateTestTblDto, TestDto>
    {
    }
}
