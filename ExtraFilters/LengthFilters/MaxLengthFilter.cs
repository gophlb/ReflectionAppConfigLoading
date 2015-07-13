using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters.LengthFilters
{
    public class MaxLengthFilter : IFilter
    {
        private int MAX_LENGTH = 5;

        public string Filter(string target)
        {
            if (target == null) { throw new ArgumentNullException(); }

            if (target.Length > MAX_LENGTH)
            {
                target = target.Substring(0, MAX_LENGTH);
            }
            
            return target;
        }
    }
}
