using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using markaz.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.Test.Dto
{
    [AutoMapFrom(typeof(TestTbl))]

    public class TestDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual long? DeleterUserId { get; set; }
        //public virtual long? LastModifierUserId { get; set; }
        public virtual DateTime? DeletionTime { get; set; } 
        public virtual DateTime CreationTime { get; set; } 
        public virtual DateTime? LastModificationTime { get; set; }
    }
}
