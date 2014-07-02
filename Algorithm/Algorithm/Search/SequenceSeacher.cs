using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Search
{
    public class SequenceSearcher : SearcherBase
    {
        protected override int FindCore<T>(IEnumerable<T> source, T target)
        {
            var index = 0;
            var found = false;
            foreach (var item in source)
            {
                if (item.Equals(target))
                {
                    found = true;
                    break;
                }
                index++;
            }
            return found ? index : NotFoundIndex;
        }
    }
}
