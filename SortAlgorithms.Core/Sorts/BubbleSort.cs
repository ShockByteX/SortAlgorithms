using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class BubbleSort<T> : SortBase<T> where T : IComparable
    {
        public BubbleSort() { }
        public BubbleSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            bool isDone = false;
            int length = _array.Length - 1;
            while (!isDone)
            {
                isDone = true;
                for (int i = 0; i < length; i++)
                {
                    if (Compare(i, i + 1) == 1)
                    {
                        Swap(i, i + 1);
                        isDone = false;
                    }
                }
                length--;
            }
        }
    }
}
