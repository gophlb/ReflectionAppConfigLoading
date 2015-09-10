using NUnit.Framework;
using Filters.RegexFilters;
using Filters;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{
    [TestFixture]
    public class RemoveNumbersFilterTest : AbstractRegexFilterTest
    {
        override protected IFilter GetFilter()
        {
            return new RemoveNumbersFilter();
        }


        [TestCase("a0b1c2d3e4f5g6", ExpectedResult = "abcdefg", TestName = "FilterWithNumbers")]
        [TestCase("bcdfg", ExpectedResult = "bcdfg", TestName = "FilterNoNumbers")]
        [TestCase("1519485", ExpectedResult = "", TestName = "FilterOnlyNumbers")]
        public string FilterTest(string stringToFilter)
        {            
            IFilter filter = GetFilter();
            return filter.Filter(stringToFilter);
        }
    }
}