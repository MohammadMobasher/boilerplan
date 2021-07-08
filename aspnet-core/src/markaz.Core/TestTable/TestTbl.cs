using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HotChocolate;
using markaz.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.TestTable
{
    
    public class TestTbl : Entity<int>, IHasModificationTime, IHasCreationTime, ISoftDelete, IDeletionAudited, IMustHaveTenant
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual long? DeleterUserId { get; set; }
        //public virtual long? LastModifierUserId { get; set; }
        public virtual DateTime? DeletionTime { get; set; } = DateTime.Now;
        public virtual DateTime CreationTime { get; set; } = DateTime.Now;
        public virtual DateTime? LastModificationTime { get; set; } = DateTime.Now;
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }

    }
}
