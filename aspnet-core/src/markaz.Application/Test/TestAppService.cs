using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using markaz.Extentions;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using markaz.Authorization;
using markaz.Test.Dto;
using markaz.TestTable;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Domain.Uow;
using markaz.EntityFrameworkCore;
using Abp.EntityFrameworkCore;

namespace markaz.Test
{

    //[AbpAuthorize(PermissionNames.Pages_Tests)]
    //[AbpAuthorize(PermissionNames.Pages_Tenants)]
    public class TestAppService : AsyncCrudAppService<TestTbl, TestDto, int, PagedTestResultRequestDto, CreateTestTblDto, TestDto>, ITestAppService
    {
       

        public IRepository<TestTbl> _testTblRepository { get; }
        private readonly IUnitOfWorkManager _unitOfWorkManager;


        public TestAppService(
            IDbContextProvider<markazDbContext> _sampleDbContextProvider,
            IRepository<TestTbl> repository,
            IUnitOfWorkManager unitOfWorkManager) : base(repository)
        {
            _testTblRepository = repository;
            //var d = _sampleDbContextProvider.GetDbContext().TestTbl.AsQueryable();
            _unitOfWorkManager = unitOfWorkManager;

        }

        //[AbpAuthorize(PermissionNames.Pages_Tests_List)]
        [HttpPost]
            //, Route("ddddd")]
        public async override Task<PagedResultDto<TestDto>> GetAllAsync([FromBody]PagedTestResultRequestDto input)
        {

            var d = this._unitOfWorkManager.Current;
            using (_unitOfWorkManager.Current.SetTenantId(1))
            {


                var count = await this._testTblRepository.CountAsync();
                var items = this._testTblRepository
                    .GetAll()
                    .PageBy(input)



                    //MaxResultCount
                    //.ApplyFiltering(input.filter)
                    ;


                //this.ApplySorting(items, input);

                //.ApplyFiltering()
                ////.Where(input)
                //.PageBy(input)
                //.OrderBy(x => x.Id)
                //.ToListAsync();

                return new PagedResultDto<TestDto>
                {
                    Items = this.ObjectMapper.Map<List<TestDto>>(items),
                    //Items = items.MapTo<List<TestDto>>(),
                    TotalCount = count,
                };
            }

        }

    }
}
