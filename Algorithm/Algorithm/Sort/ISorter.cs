using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public interface ISorter
    {
        void Sort<T>(T[] source) where T : IComparable<T>;
    }
}
