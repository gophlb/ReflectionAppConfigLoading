using System.Text.RegularExpressions;

namespace Filters.RegexFilters
{
    public class RemoveConsonantsFilter : AbstractRegexFilter
    {
        public RemoveConsonantsFilter()
        {
            regex = new Regex("[bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]");
        }
    }
}