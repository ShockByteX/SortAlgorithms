
using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class TreeSort<T> : SortBase<T> where T : IComparable
    {
        public TreeSort() : base() { }
        public TreeSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
       
        }
    }
}
