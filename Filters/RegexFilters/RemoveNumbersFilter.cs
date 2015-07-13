using System.Text.RegularExpressions;

namespace Filters.RegexFilters
{
    public class RemoveNumbersFilter : AbstractRegexFilter
    {
        public RemoveNumbersFilter()
        {
            regex = new Regex("[0-9]");
        }        
    }
}
