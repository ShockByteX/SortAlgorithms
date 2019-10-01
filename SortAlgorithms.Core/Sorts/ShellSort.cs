using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class ShellSort<T> : SortBase<T> where T : IComparable
    {
        public ShellSort() { }
        public ShellSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            int step = _array.Length;
            while ((step /= 2) > 0)
            {
                for (int i = step; i < _array.Length; i++)
                {
                    for (int j = i; j >= step; j -= step)
                    {
                        if (Compare(j, j - step) == -1) Swap(j, j - step); else break;
                    }
                }
            }
        }
    }
}
