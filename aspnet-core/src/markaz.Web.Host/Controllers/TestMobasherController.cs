using Abp.Authorization;
using markaz.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace markaz.Web.Host.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestMobasherController : markazControllerBase
    {
        public TestMobasherController()
        {

        }

        [HttpGet, AbpAuthorize]
        public IActionResult JustReturnOk()
        {
            return Ok();
        }
    }
}
