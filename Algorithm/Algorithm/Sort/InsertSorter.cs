using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public class InsertSorter : SorterBase
    {
        protected override void SortCore<T>(T[] source)
        {
            var index = 1;
            while (index < source.Length)
            {
                while (source[index] > source[index-1])
                {
                    
                }
            }
        }
    }
}
