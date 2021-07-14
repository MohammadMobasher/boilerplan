using Abp.Domain.Repositories;
using markaz.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.EntityFrameworkCore.Repositories
{
    public interface ITestTblRepository : IRepository<TestTbl, int>
    {
    }
}
