using System;

namespace SortAlgorithms.Core.Sorts
{
    public class BubbleSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            var isDone = false;
            var length = items.Length - 1;

            while (!isDone)
            {
                isDone = true;

                for (var i = 0; i < length; i++)
                {
                    if (sortOperator.Compare(items, i, i + 1) == 1)
                    {
                        sortOperator.Swap(items, i, i + 1);
                        isDone = false;
                    }
                }

                length--;
            }
        }
    }
}