using System;
using System.Collections.Generic;
using System.Text;

namespace Tool.ExternContainer
{
    public class MaxHeap<T> : Heap<T> where T : System.IComparable<T>
    {
        public MaxHeap() : base() { }

        protected override int Compare(T l, T r)
        {
            return r.CompareTo(l);
        }
    }
}
