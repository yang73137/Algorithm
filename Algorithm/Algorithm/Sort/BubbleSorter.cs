using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public class BubbleSorter : SorterBase
    {
        protected override void SortCore<T>(T[] source)
        {
            for (var i = 0; i < source.Length - 1; i++)
            {
                for (var j = 0; j < source.Length - i - 1; j++)
                {
                    if (source[j].CompareTo(source[j + 1]) > 0)
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }
    }
}
