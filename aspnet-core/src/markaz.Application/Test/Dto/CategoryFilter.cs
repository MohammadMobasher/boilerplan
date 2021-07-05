using markaz.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markaz.Test.Dto
{

    public class IntegerFilter : IFilter
    {
        public IntegerFilter() { }
        public IntegerFilter(int? equals = null, int? from = null, int? to = null) { }

        public int? Equals { get; set; }
        public int? From { get; set; }
        public int? To { get; set; }
    }

    public class StringFilter : IFilter
    {
        public StringFilter() { } 
        public StringFilter(string equals = null, string contains = null) { }

        public string Equals { get; set; }
        public string Contains { get; set; }
    }
    public class TestFilter : IFilter
    {
        public IntegerFilter Id { get; set; }
        public StringFilter Name { get; set; }
        public StringFilter Title { get; set; }

        public TestFilter() { }

        public TestFilter(IntegerFilter id = null, StringFilter name = null, StringFilter title = null)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
