using System;

namespace SortAlgorithms.Core.Sorts
{
    public class HeapSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            var count = 0;

            for (var i = items.Length; i >= 0; i--)
            {
                Sort(items, sortOperator, i);
                count++;
            }

            for (var i = count - 1; i >= 0; i--)
            {
                sortOperator.Swap(items, 0, i);
                Sort(items, sortOperator, 0, i);
            }
        }

        private void Sort(T[] items, ISortOperator<T> sortOperator, int currentIndex, int maxLength = -1)
        {
            maxLength = maxLength == -1 ? items.Length : maxLength;

            for (int i = currentIndex, maxIndex = i; currentIndex < maxLength; i = maxIndex)
            {
                var leftIndex = GetLeftIndex(i);
                var rightIndex = GetRightIndex(i);

                if (leftIndex < maxLength && sortOperator.Compare(items, leftIndex, maxIndex) == 1)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < maxLength && sortOperator.Compare(items, rightIndex, maxIndex) == 1)
                {
                    maxIndex = rightIndex;
                }

                if (i == maxIndex) return;

                sortOperator.Swap(items, i, maxIndex);
            }
        }

        private int GetLeftIndex(int index) => (index << 1) + 1;
        private int GetRightIndex(int index) => (index << 1) + 2;
    }
}