using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Sort
{
    public abstract class SorterBase : ISorter
    {
        public event EventHandler BeforeSortEvent;
        public event EventHandler AfterSortEvent;

        public virtual void OnBeforeSort<T>(T[] source)
        {
            Console.WriteLine("Before: {0}", string.Join(",", source));
            if (this.BeforeSortEvent != null)
            {
                this.BeforeSortEvent(this, new SortEventArgs<T>(source));
            }
        }

        public virtual void OnAfterSort<T>(T[] source)
        {
            Console.WriteLine("After: {0}", string.Join(",", source));
            if (this.AfterSortEvent != null)
            {
                this.AfterSortEvent(this, new SortEventArgs<T>(source));
            }
        }

        public void Sort<T>(T[] source) where T : IComparable<T>
        {
            if (source == null)
            {
                throw new ArgumentNullException("source", "source can not be null");
            }
            this.OnBeforeSort(source);
            if (source.Any() && source.Length > 1)
            {
                this.SortCore(source);
            }
            this.OnAfterSort(source);
        }

        protected abstract void SortCore<T>(T[] source) where T : IComparable<T>;
    }

    public class SortEventArgs<T> : EventArgs
    {
        public T[] Source { get; set; }

        public SortEventArgs(T[] source)
        {
            this.Source = source;
        }
    }
}
