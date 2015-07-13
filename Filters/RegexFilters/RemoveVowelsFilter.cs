using System.Text.RegularExpressions;

namespace Filters.RegexFilters
{
    public class RemoveVowelsFilter : AbstractRegexFilter
    {
       public RemoveVowelsFilter()
        {
            regex = new Regex("[aeiouAEIOU]");
        }
    }
}
