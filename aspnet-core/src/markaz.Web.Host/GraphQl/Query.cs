using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using HotChocolate;
using markaz.EntityFrameworkCore;
using markaz.TestTable;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markaz.Web.Host.GraphQl
{
    public class Query
    {
        //private readonly IRepository<TestTbl> _testTblRepository;

        //public Query()
        //{
        //    this._testTblRepository = testTblRepository;
        //}

        [UnitOfWork(isTransactional: true)]
        public virtual async Task<IQueryable<TestTbl>> GetList([Service] IRepository<TestTbl> _testTblRepository)
        {
            var d = await _testTblRepository.GetAll().ToListAsync();
            return _testTblRepository.GetAll();
        }


        //[UnitOfWork(isTransactional: false)]
        //public virtual IQueryable<TestTbl> GetList([Service] IRepository<TestTbl> testTblRepository)
        //{

        //    return testTblRepository.GetAll();
        //}

        //private readonly markazDbContext _context;
        //public Query(markazDbContext context)
        //{
        //    this._context = context;
        //}


        //public IQueryable<TestTbl> GetList([Service] markazDbContext context)
        //{

        //    return context.TestTbl;
        //}
    }
}
