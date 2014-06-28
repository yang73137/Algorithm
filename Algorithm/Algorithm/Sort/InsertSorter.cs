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
                var currentIndex = index;
                while (currentIndex > 0 && source[currentIndex].CompareTo(source[currentIndex - 1]) < 0)
                {
                    var temp = source[currentIndex];
                    source[currentIndex] = source[currentIndex - 1];
                    source[currentIndex - 1] = temp;
                    currentIndex--;
                }
                index++;
            }
        }
    }
}
