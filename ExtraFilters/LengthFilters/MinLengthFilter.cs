using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters.LengthFilters
{
    public class MinLengthFilter : IFilter
    {
        private int MIN_LENGTH = 10;

        public string Filter(string target)
        {
            if (target == null) { throw new ArgumentNullException(); }

            if (target.Length < MIN_LENGTH)
            {
                target = target.PadLeft(MIN_LENGTH, '#');
            }
            
            return target;
        }
    }
}
