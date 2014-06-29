using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public class ShellSorter : SorterBase
    {
        protected override void SortCore<T>(T[] source)
        {
            var step = source.Length/2;
            while (step >= 1)
            {
                for (var i = step; i < source.Length; i++)
                {
                    var index = i;
                    while (index - step >= 0)
                    {
                        if (source[index].CompareTo(source[index - step]) < 0)
                        {
                            var temp = source[index];
                            source[index] = source[index - step];
                            source[index - step] = temp;
                            index = index - step;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                step = step / 2;
            }
        }
    }
}
