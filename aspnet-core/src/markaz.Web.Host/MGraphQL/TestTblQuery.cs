//using Abp.Domain.Repositories;
//using Abp.Domain.Uow;
//using GraphQL;
//using GraphQL.Types;
//using markaz.TestTable;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace markaz.Web.Host.MGraphQL
//{
//    public class TestTblQuery : ObjectGraphType
//    {
//        private readonly IRepository<TestTbl> _reservationRepository;

//        public TestTblQuery(IRepository<TestTbl> reservationRepository)
//        {
//            _reservationRepository = reservationRepository;

//            Field<ListGraphType<TestTblType>>(
//                name: "test",
//                arguments: new QueryArguments(new List<QueryArgument>
//                {
//                    new QueryArgument<IdGraphType>
//                    {
//                        Name = "id"
//                    },
//                    new QueryArgument<StringGraphType>
//                    {
//                        Name = "name"
//                    },
//                    new QueryArgument<StringGraphType>
//                    {
//                        Name = "title"
//                    },
                    
//                }),
//                resolve: InternalResolve
//            );
//        }


//        [UnitOfWork]
//        protected virtual List<TestTbl> InternalResolve(IResolveFieldContext<object> context)
//        {
//            var query = _reservationRepository.GetAll();

//            var reservationId = context.GetArgument<int?>("id");
//            if (reservationId.HasValue)
//            {
//                return query.Where(r => r.Id == reservationId.Value).ToList();
//            }

//            var checkinName = context.GetArgument<string>("name");

//            if (!string.IsNullOrEmpty(checkinName))
//            {
//                return query.Where(r => r.Name == checkinName).ToList();
//            }

//            var checkinTitle = context.GetArgument<string>("title");

//            if (!string.IsNullOrEmpty(checkinTitle))
//            {
//                return query.Where(r => r.Title == checkinTitle).ToList();
//            }

//            return query.ToList();
//        }
//    }
//}
