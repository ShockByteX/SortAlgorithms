using System;

namespace SortAlgorithms.Core.Sorts
{
    public class InsertionSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            for (var i = 1; i < items.Length; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    if (sortOperator.Compare(items, j, j - 1) == -1)
                    {
                        sortOperator.Swap(items, j, j - 1);
                    }
                    else break;
                }
            }
        }
    }
}