using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Search
{
    public abstract class SearcherBase : ISearcher
    {
        protected const int NotFoundIndex = -1;

        public int Find<T>(IEnumerable<T> source, T target) where T : IComparable<T>
        {
            if (source == null)
            {
                throw new ArgumentNullException("source", "source can not be null");
            }

            if (!source.Any())
            {
                return NotFoundIndex;
            }

            return this.FindCore(source, target);
        }

        protected abstract int FindCore<T>(IEnumerable<T> source, T target) where T : IComparable<T>;
    }
}
