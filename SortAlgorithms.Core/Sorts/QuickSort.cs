using System;

namespace SortAlgorithms.Core.Sorts
{
    public class QuickSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            Sort(items, sortOperator, 0, items.Length - 1);
        }

        private static void Sort(T[] items, ISortOperator<T> sortOperator, int left, int right)
        {
            if (left >= right) return;

            var pivot = Split(items, sortOperator, left, right);

            Sort(items, sortOperator, left, pivot - 1);
            Sort(items, sortOperator, pivot + 1, right);
        }

        private static int Split(T[] items, ISortOperator<T> sortOperator, int left, int right)
        {
            var pointer = left;

            for (var i = left; i <= right; i++)
            {
                if (sortOperator.Compare(items[i], items[right]) == -1)
                {
                    sortOperator.Swap(items, i, pointer++);
                }
            }

            sortOperator.Swap(items, pointer, right);

            return pointer;
        }
    }
}