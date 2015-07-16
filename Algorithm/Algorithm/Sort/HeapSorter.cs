using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public class HeapSorter : SorterBase
    {
        protected override void SortCore<T>(T[] source)
        {
            this.BuildHeap(source);
            this.HeapSort(source);
        }

        private void AdjustHeap<T>(T[] source, int currentIndex, int size) where T : IComparable<T>
        {
            var leftChildIndex = currentIndex * 2 + 1;
            var rightChildIndex = leftChildIndex + 1;
            var maxIndex = currentIndex;

            if (currentIndex > size / 2)
            {
                return;
            }

            if (leftChildIndex < size && source[currentIndex].CompareTo(source[leftChildIndex]) < 0)
            {
                var temp = source[currentIndex];
                source[currentIndex] = source[leftChildIndex];
                source[leftChildIndex] = temp;
                maxIndex = leftChildIndex;
            }

            if (rightChildIndex < size && source[currentIndex].CompareTo(source[rightChildIndex]) < 0)
            {
                var temp = source[currentIndex];
                source[currentIndex] = source[rightChildIndex];
                source[rightChildIndex] = temp;
                maxIndex = rightChildIndex;
            }

            if (maxIndex != currentIndex)
            {
                AdjustHeap(source, maxIndex, size);
            }
        }

        private void BuildHeap<T>(T[] source) where T : IComparable<T>
        {
            var index = source.Length / 2 - 1;
            for (var i = index; i >= 0; i--)
            {
                AdjustHeap(source, i, source.Length);
            }
        }

        private void HeapSort<T>(T[] source) where T : IComparable<T>
        {
            for (var i = source.Length - 1; i > 0; i--)
            {
                var max = source[0];
                source[0] = source[i];
                source[i] = max;
                AdjustHeap(source, 0, i - 1);
            }
        }
    }
}
