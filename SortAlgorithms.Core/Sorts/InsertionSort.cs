using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class InsertionSort<T> : SortBase<T> where T : IComparable
    {
        public InsertionSort() { }
        public InsertionSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            int index = 0;
            while (++index < _array.Length)
            {
                for (int i = index; i > 0; i--)
                {
                    if (Compare(i, i - 1) == -1) Swap(i, i - 1); else break;
                }
            }
        }
    }
}
