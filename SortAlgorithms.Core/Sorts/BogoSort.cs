using System;
using SortAlgorithms.Core.Extensions;

namespace SortAlgorithms.Core.Sorts
{
    public class BogoSort<T> : ISort<T> where T : IComparable
    {
        private static readonly Random Random = new Random();

        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            while (!items.IsSorted())
            {
                for (var i = 0; i < items.Length; i++)
                {
                    sortOperator.Swap(items, 0, Random.Next(0, items.Length));
                }
            }
        }
    }
}