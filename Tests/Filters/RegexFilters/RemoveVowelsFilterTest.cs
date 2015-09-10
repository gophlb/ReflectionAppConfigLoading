using NUnit.Framework;
using Filters.RegexFilters;
using Filters;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{
    [TestFixture]
    public class RemoveVowelsFilterTest : AbstractRegexFilterTest
    {
        override protected IFilter GetFilter()
        {
            return new RemoveVowelsFilter();
        }



        [TestCase("abEcdAAefg", ExpectedResult = "bcdfg", TestName = "FilterWithVowels")]
        [TestCase("bcdfg", ExpectedResult = "bcdfg", TestName = "FilterNoVowels")]
        [TestCase("aaAAaeiEaIou", ExpectedResult = "", TestName = "FilterOnlyVowels")]
        public string FilterTest(string stringToFilter)
        {
            IFilter filter = GetFilter();
            return filter.Filter(stringToFilter);
        }        
    }
}