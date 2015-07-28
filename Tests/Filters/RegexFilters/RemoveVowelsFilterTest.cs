using NUnit.Framework;
using Filters.RegexFilters;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{
    [TestFixture]
    public class RemoveVowelsFilterTest : AbstractRegexFilterTest
    {
        [SetUp]
        public void Init()
        {
            filter = new RemoveVowelsFilter();
        }



        [Test]
        [TestCase("abEcdAAefg")]
        public void FilterWithVowels(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, "bcdfg");
        }


        [Test]
        [TestCase("bcdfg")]
        public void FilterNoVowels(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, "bcdfg");
        }


        [Test]
        [TestCase("aaAAaeiEaIou")]
        public void FilterOnlyVowels(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, string.Empty);
        }

    }
}