using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class GnomeSort<T> : SortBase<T> where T : IComparable
    {
        public GnomeSort() { }
        public GnomeSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            int length = _array.Length - 1;
            for (int i = 0; i < length; i++)
            {
                while (i >= 0 && Compare(i, i + 1) == 1)
                {
                    Swap(i, i + 1);
                    i--;
                }
            }
        }
    }
}
