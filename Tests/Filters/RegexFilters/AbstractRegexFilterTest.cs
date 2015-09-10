using Filters;
using NUnit.Framework;
using System;

namespace ReflectionLoading.Filters.RegexFilters.Tests
{
    [TestFixture]
    public abstract class AbstractRegexFilterTest
    {
        protected abstract IFilter GetFilter();


        [TestCase(null, ExpectedException = typeof(ArgumentNullException), TestName = "FilterNull")]
        [TestCase("", ExpectedResult = "", TestName = "FilterEmpty")]
        public string FilterNull(string stringToFilter)
        {
            IFilter filter = GetFilter();
            return filter.Filter(stringToFilter);            
        }

        /*
        [TestCase(null)]
        public void FilterNull(string stringToFilter)
        {
            IFilter filter = GetFilter();
            ArgumentNullException ex = Assert.Catch<ArgumentNullException>(() => filter.Filter(stringToFilter));
            StringAssert.Contains("string available", ex.Message);
        }
        */
    }
}