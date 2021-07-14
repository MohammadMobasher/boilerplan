using Abp.EntityFrameworkCore;
using markaz.TestTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.EntityFrameworkCore.Repositories
{
    public class TestTblRepository : markazRepositoryBase<TestTbl, int>, ITestTblRepository
    {
        public TestTblRepository(IDbContextProvider<markazDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        }
    }
}
