using System;

namespace SortAlgorithms.Core.Sorts
{
    public class GnomeSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            var length = items.Length - 1;

            for (var i = 0; i < length; i++)
            {
                while (i >= 0 && sortOperator.Compare(items, i, i + 1) == 1)
                {
                    sortOperator.Swap(items, i, i + 1);
                    i--;
                }
            }
        }
    }
}