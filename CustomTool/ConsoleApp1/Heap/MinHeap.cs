using System;
using System.Collections.Generic;
using System.Text;

namespace Tool.ExternContainer
{
    public class MinHeap<T> : Heap<T> where T:System.IComparable<T>
    {
        public MinHeap() : base() { }

        protected override int Compare(T l, T r)
        {
            return l.CompareTo(r);
        }
    }
}
