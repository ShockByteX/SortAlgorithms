using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class SelectionSort<T> : SortBase<T> where T : IComparable
    {
        public SelectionSort() { }
        public SelectionSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < _array.Length; j++)
                {
                    if (Compare(j, minIndex) == -1) minIndex = j;
                }
                Swap(i, minIndex);
            }
        }
    }
}
