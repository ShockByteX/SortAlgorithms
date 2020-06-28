using System;

namespace SortAlgorithms.Core.Sorts
{
    public class ShellSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            var step = items.Length;

            while ((step /= 2) > 0)
            {
                for (var i = step; i < items.Length; i++)
                {
                    for (var j = i; j >= step; j -= step)
                    {
                        if (sortOperator.Compare(items, j, j - step) == -1)
                        {
                            sortOperator.Swap(items, j, j - step);
                        }
                        else break;
                    }
                }
            }
        }
    }
}