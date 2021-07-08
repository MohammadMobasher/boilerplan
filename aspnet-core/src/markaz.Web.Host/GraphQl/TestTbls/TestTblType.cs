using HotChocolate.Types;
using markaz.TestTable;

namespace markaz.Web.Host.GraphQl.TestTbls
{
    public class TestTblType : ObjectType<TestTbl>
    {

        protected override void Configure(IObjectTypeDescriptor<TestTbl> descriptor)
        {

            descriptor.Description("this is test description");
             descriptor.Field(x => x.Id).Ignore();
            descriptor.Field(x => x.Name).Description("mohammad: this is test from ObjectType file");
            base.Configure(descriptor);
        }

        
    }
}
