using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Runtime.Validation;
using markaz.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.Test.Dto
{
    [AutoMapTo(typeof(TestTbl))]

    public class CreateTestTblDto : IMustHaveTenant
    {
        public int TenantId { get ; set ; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
