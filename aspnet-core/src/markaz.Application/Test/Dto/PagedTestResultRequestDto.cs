using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.Test.Dto
{
    public class PagedTestResultRequestDto : PagedAndSortedResultRequestDto
    {
        public TestFilter filter { get; set; }
    }
}
