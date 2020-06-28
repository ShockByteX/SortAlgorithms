using System;

namespace SortAlgorithms.Core.Sorts
{
    public class SelectionSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            for (var i = 0; i < items.Length - 1; i++)
            {
                var minIndex = i;

                for (var j = i; j < items.Length; j++)
                {
                    if (sortOperator.Compare(items, j, minIndex) == -1)
                    {
                        minIndex = j;
                    }
                }

                sortOperator.Swap(items, i, minIndex);
            }
        }
    }
}