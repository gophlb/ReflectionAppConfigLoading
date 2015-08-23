using Filters;
using NUnit.Framework;
using System;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{
    [TestFixture]
    public abstract class AbstractRegexFilterTest
    {
        protected IFilter filter { get; set; }

        
        [TestCase(null)]
        public void FilterNull(string stringToFilter)
        {
            ArgumentNullException ex = Assert.Catch<ArgumentNullException>(() => filter.Filter(stringToFilter));
            StringAssert.Contains("string available", ex.Message);
        }


        [TestCase("")]
        public void FilterEmpty(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, string.Empty);
        }
    }
}