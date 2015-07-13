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
        public void FilterWithVowels()
        {
            string result = "";

            try { result = filter.Filter("abEcdAAefg"); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "bcdfg");
        }


        [Test]
        public void FilterNoVowels()
        {
            string result = "";

            try { result = filter.Filter("bcdfg"); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "bcdfg");
        }


        [Test]
        public void FilterOnlyVowels()
        {
            string result = "";

            try { result = filter.Filter("aaAAaeiEaIou"); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "");
        }

    }
}