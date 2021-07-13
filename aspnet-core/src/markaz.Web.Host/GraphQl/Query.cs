using Abp.AspNetCore.Mvc.Authorization;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using markaz.Authorization;
using markaz.EntityFrameworkCore;
using markaz.gg;
using markaz.MultiTenancy;
using markaz.TestTable;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Transactions;

namespace markaz.Web.Host.GraphQl
{
    public class Query
    {

        //private readonly IRepository<TestTbl> _testTblRepository;

        //public Query()
        //{
        //    this._testTblRepository = testTblRepository;
        //}

        //[UnitOfWork(isTransactional: true)]
        //public virtual async Task<IQueryable<TestTbl>> GetList([Service] IRepository<TestTbl> _testTblRepository)
        //{
        //    var d = await _testTblRepository.GetAll().ToListAsync();
        //    return _testTblRepository.GetAll();
        //}


        //[UnitOfWork(isTransactional: false)]
        //public virtual IQueryable<TestTbl> GetList([Service] IRepository<TestTbl> testTblRepository)
        //{

        //    return testTblRepository.GetAll();
        //}

        //private readonly markazDbContext _context;
        
        public Query()
        {
        }

        [UseDbContext(typeof(markazDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        //[Authorize]
        //[AbpAuthorize(PermissionNames.Pages_Roles_Create)]
        public IQueryable<TestTbl> GetTestTbl([ScopedService] markazDbContext context)
        {

            return context.TestTbl;
        }


        [UseDbContext(typeof(markazDbContext))]
        [UseProjection]

        public IQueryable<Tenant> GetTenant([ScopedService] markazDbContext context)
        {
            return context.Tenants;
        }

        [UseDbContext(typeof(markazDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] markazDbContext context)
        {
            return context.Platform;
        }

        /// <summary>
        /// Gets the queryable <see cref="Command"/>.
        /// </summary>
        /// <param name="context">The <see cref="AppDbContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(markazDbContext))]
        [UseProjection]
        public IQueryable<Command> GetCommand([ScopedService] markazDbContext context)
        {
            return context.Command;
        }



        //private readonly IRepository<TestTbl> _testTblRepository;

        //public Query(IRepository<TestTbl> testTblRepository)
        //{
        //    this._testTblRepository = testTblRepository;
        //}

        //[UnitOfWork(scope: TransactionScopeOption.RequiresNew)]
        //public virtual IQueryable<TestTbl> GetList([Service] IRepository<TestTbl> _testTblRepository)
        //{
        //    var d = _testTblRepository.GetAll();

        //    return _testTblRepository.GetAll();
        //}
    }
}
