using Filters;
using NUnit.Framework;
using System;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{

    public abstract class AbstractRegexFilterTest
    {
        protected IFilter filter { get; set; }


        [Test]
        [TestCase(null)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FilterNull(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);
        }


        [Test]
        [TestCase("")]
        public void FilterEmpty(string stringToFilter)
        {
            string result = filter.Filter(stringToFilter);

            Assert.AreEqual(result, string.Empty);
        }
    }
}