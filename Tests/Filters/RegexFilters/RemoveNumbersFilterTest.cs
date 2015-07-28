using NUnit.Framework;
using Filters.RegexFilters;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{
    [TestFixture]
    public class RemoveNumbersFilterTest : AbstractRegexFilterTest
    {
        [SetUp]
        public void Init()
        {
            filter = new RemoveNumbersFilter();
        }


        [Test]
        [TestCase("a0b1c2d3e4f5g6")]
        public void FilterWithNumbers(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, "abcdefg");
        }


        [Test]
        [TestCase("bcdfg")]
        public void FilterNoNumbers(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, "bcdfg");
        }


        [Test]
        [TestCase("1519485")]
        public void FilterOnlyNumbers(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, string.Empty);
        }

    }
}