using Abp.AspNetCore.OData.Controllers;
using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Web.Models;
using markaz.Authorization;
using markaz.TestTable;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markaz.Web.Host.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [DontWrapResult]
    public class TestTblController : AbpODataEntityController<TestTbl>, ITransientDependency
    {
        public TestTblController(IRepository<TestTbl> repository)
            : base(repository)
        {
        }


        public override Task<IActionResult> Delete([FromODataUri] int key)
        {
            return base.Delete(key);
        }


        //[AbpAuthorize(
        ////    //PermissionNames.Pages_Tests_List
        //    )]
        public override IQueryable<TestTbl> Get()
        {
            return base.Get();
        }

        public override SingleResult<TestTbl> Get([FromODataUri] int key)
        {
            return base.Get(key);
        }

        public override Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<TestTbl> entity)
        {
            return base.Patch(key, entity);
        }

        public override Task<IActionResult> Post([FromBody] TestTbl entity)
        {
            return base.Post(entity);
        }

        public override Task<IActionResult> Put([FromODataUri] int key, [FromBody] TestTbl update)
        {
            return base.Put(key, update);
        }

    }
}
