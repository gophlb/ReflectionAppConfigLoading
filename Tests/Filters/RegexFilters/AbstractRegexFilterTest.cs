using Filters;
using NUnit.Framework;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{

    public abstract class AbstractRegexFilterTest
    {
        protected IFilter filter { get; set; }


        [Test]
        public void FilterNull()
        {
            string result = "";

            try { result = filter.Filter(null); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "exception");
        }


        [Test]
        public void FilterEmpty()
        {
            string result = "";

            try { result = filter.Filter(""); }
            catch { result = "exception"; }

            Assert.AreEqual(result, "");
        }
    }
}