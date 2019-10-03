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
            for (int i = 1; i < _array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (Compare(j, j - 1) == -1) Swap(j, j - 1); else break;
                }
            }
        }
    }
}
