using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public class SelectSorter : SorterBase
    {
        protected override void SortCore<T>(T[] source)
        {
            for (var i = 0; i < source.Length - 1; i++)
            {
                for (var j = i + 1; j < source.Length; j++)
                {
                    if (source[i].CompareTo(source[j]) > 0)
                    {
                        var temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                    }
                }
            }
        }
    }
}
