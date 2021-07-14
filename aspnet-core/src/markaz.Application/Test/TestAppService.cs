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
using markaz.EntityFrameworkCore.Repositories;

namespace markaz.Test
{

    //[AbpAuthorize(PermissionNames.Pages_Tests)]
    //[AbpAuthorize(PermissionNames.Pages_Tenants)]
    public class TestAppService : AsyncCrudAppService<TestTbl, TestDto, int, PagedTestResultRequestDto, CreateTestTblDto, TestDto>, ITestAppService
    {
       

        public IRepository<TestTbl> _testTblRepository { get; }
        private readonly IUnitOfWorkManager _unitOfWorkManager;
        private readonly TestTblRepository _testTblRepository2;

        public TestAppService(
            IDbContextProvider<markazDbContext> _sampleDbContextProvider,
            IRepository<TestTbl> repository,
            IUnitOfWorkManager unitOfWorkManager,
            TestTblRepository testTblRepository,
            IPermissionChecker  permissionChecker,
            IPermissionManager permissionManager) : base(repository)
        {
            _testTblRepository = repository;
            //var d = _sampleDbContextProvider.GetDbContext().TestTbl.AsQueryable();
            _unitOfWorkManager = unitOfWorkManager;
            this._testTblRepository2 = testTblRepository;
            var d = permissionManager.GetAllPermissions();


        }

        
        //[AbpAuthorize(PermissionNames.Pages_Tests_List, PermissionNames.Pages_Tenants)]
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
