using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public class QuickSorter : SorterBase
    {
        protected override void SortCore<T>(T[] source)
        {
            this.InnerSort(source, 0, source.Length - 1);
        }

        private void InnerSort<T>(T[] source, int left, int right) where T : IComparable<T>
        {
            if (left >= right)
            {
                return;
            }
            var copyLeft = left;
            var copyRight = right;
            var pivot = source[left];
            while (left < right)
            {
                while (left < right && source[right].CompareTo(pivot) >= 0)
                {
                    right--;
                }
                source[left] = source[right];

                while (left < right && source[left].CompareTo(pivot) <= 0)
                {
                    left++; 
                }
                source[right] = source[left];
            }

            source[left] = pivot;
            InnerSort(source, copyLeft, left - 1);
            InnerSort(source, left + 1, copyRight);
        }
    }
}
