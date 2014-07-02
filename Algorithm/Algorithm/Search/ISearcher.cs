using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Search
{
    public interface ISearcher
    {
        int Find<T>(IEnumerable<T> source, T target) where T : IComparable<T>;
    }
}
