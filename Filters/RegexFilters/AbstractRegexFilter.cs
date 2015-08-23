using System;
using System.Text.RegularExpressions;

namespace Filters.RegexFilters
{
    public abstract class AbstractRegexFilter : IFilter
    {
        protected Regex regex { get; set; }

        
        public virtual string Filter(string target)
        {
            if (target == null) { throw new ArgumentNullException("target", "No target string available to filter."); }

            return regex.Replace(target, "");
        }
    }
}
