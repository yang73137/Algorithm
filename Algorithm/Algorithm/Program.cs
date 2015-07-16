using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithm.Search;
using Algorithm.Sort;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 2, 3, 8, 9, 1, 2 };

            var bubbleSorter = new BubbleSorter();
            var selectSorter = new SelectSorter();
            var insertSorter = new InsertSorter();
            var quickSorter = new QuickSorter();
            var shellSorter = new ShellSorter();
            var healSorter = new HeapSorter();

            bubbleSorter.Sort(CopyArray(arr));
            selectSorter.Sort(CopyArray(arr));
            insertSorter.Sort(CopyArray(arr));
            quickSorter.Sort(CopyArray(arr));
            shellSorter.Sort(CopyArray(arr));
            healSorter.Sort(CopyArray(arr));

            var sequenceSearcher = new SequenceSearcher();
            Console.WriteLine(sequenceSearcher.Find(arr, 1));

            var binarySearcher = new BinarySearcher();
            Console.WriteLine(binarySearcher.Find(new []{ 1, 2, 3, 4, 5 }, 1));

            Console.ReadLine();
            
        }

        static T[] CopyArray<T>(T[] source)
        {
            var arr = new T[source.Length];
            for (var i = 0; i < source.Length; i++)
            {
                arr[i] = source[i];
            }
            return arr;
        }
    }
}
