using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Search
{
    /// <summary>
    /// 结合必须有序
    /// </summary>
    public class BinarySearcher : SearcherBase
    {
        protected override int FindCore<T>(IEnumerable<T> source, T target)
        {
            var low = 0;
            var high = source.Count() - 1;
            while (low <= high)
            {
                var middle = (low + high)/2;
                if (source.ElementAt(middle).CompareTo(target) == 0)
                {
                    return middle;
                }
                
                if (target.CompareTo(source.ElementAt(middle)) > 0)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return NotFoundIndex;
        }
    }
}
