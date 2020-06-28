using System;

namespace SortAlgorithms.Core.Sorts
{
    public class CocktailSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            var isDone = false;
            var left = 0;
            var right = items.Length - 1;

            while (!isDone)
            {
                isDone = true;

                for (var i = left; i < right; i++)
                {
                    if (sortOperator.Compare(items, i, i + 1) == 1)
                    {
                        sortOperator.Swap(items, i, i + 1);
                        isDone = false;
                    }
                }

                if (isDone) return;

                right--;

                for (var i = right; i > left; i--)
                {
                    if (sortOperator.Compare(items, i, i - 1) == -1)
                    {
                        sortOperator.Swap(items, i, i - 1);
                        isDone = false;
                    }
                }

                left++;
            }
        }
    }
}