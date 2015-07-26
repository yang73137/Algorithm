using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Algorithm.Search;
using Algorithm.Sort;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var atr = "ABCABCABCDABC";
            var pattern = "abacab";

            KMP kmp = new KMP();
            Console.WriteLine(String.Join(",", kmp.GetNextArray(pattern)));

            return;

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

    public class KMP
    {
        public int[] GetNextArray(string pattern)
        {
            // next 数组
            var nextArr = new int[pattern.Length];

            // next 的索引0 为 0
            nextArr[0] = 0;

            // 已经匹配的前缀、后缀的最长子串长度
            var prevNextValue = nextArr[0];

            for (var i = 1; i < pattern.Length; i++)
            {
                // 如果当前字符不能据需匹配，并且prevNextValue > 0，递减prevNextValue
                while (prevNextValue > 0 && pattern[i] != pattern[prevNextValue])
                {
                    prevNextValue = nextArr[prevNextValue - 1];
                }

                // 如果当前的字符继续能够匹配，当前字符的next为前一个next+1
                if (pattern[i] == pattern[prevNextValue])
                {
                    prevNextValue++;
                }

                nextArr[i] = prevNextValue;
            }

            return nextArr;
        }

        public int IndexOf(string source, string pattern)
        {
            var nextArr = this.GetNextArray(pattern);
            var patternIndex = 0;
            for (var i = 0; i < source.Length - pattern.Length - 1; i++)
            {
                Console.WriteLine(i);

                while (pattern[patternIndex] == source[i + patternIndex])
                {
                    patternIndex++;
                    
                    if (patternIndex == pattern.Length)
                    {
                        return i;
                    }
                }
                
                i += nextArr[patternIndex];
                patternIndex = 0;
            }

            return -1;
        }
    }
}
