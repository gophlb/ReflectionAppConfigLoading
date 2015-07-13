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
        public void FilterWithNumbers()
        {
            string result = "";

            try { result = filter.Filter("a0b1c2d3e4f5g6"); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "abcdefg");
        }


        [Test]
        public void FilterNoNumbers()
        {
            string result = "";

            try { result = filter.Filter("bcdfg"); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "bcdfg");
        }


        [Test]
        public void FilterOnlyNumbers()
        {
            string result = "";

            try { result = filter.Filter("1519485"); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "");
        }
        
    }
}