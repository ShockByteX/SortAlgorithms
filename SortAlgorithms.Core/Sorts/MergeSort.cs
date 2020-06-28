using System;

namespace SortAlgorithms.Core.Sorts
{
    public class MergeSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            Sort(items, sortOperator, 0, items.Length);
        }

        private void Sort(T[] items, ISortOperator<T> sortOperator, int index, int length)
        {
            if (length == 1) return;

            var leftLength = length >> 1;
            var rightIndex = index + leftLength;
            var rightLength = length - leftLength;

            Sort(items, sortOperator, index, leftLength);
            Sort(items, sortOperator, rightIndex, rightLength);

            Merge(items, sortOperator, index, leftLength, index + leftLength, length - leftLength);
        }

        private void Merge(T[] items, ISortOperator<T> sortOperator, int leftIndex, int leftLength, int rightIndex, int rightLength)
        {
            T[] array = new T[leftLength + rightLength];

            for (int i = 0, iLeft = leftIndex, iRight = rightIndex; i < array.Length; i++)
            {
                if (iLeft < leftIndex + leftLength)
                {
                    if (iRight < rightIndex + rightLength)
                    {
                        array[i] = sortOperator.Compare(items, iLeft, iRight) == -1
                            ? items[iLeft++]
                            : items[iRight++];
                    }
                    else array[i] = items[iLeft++];
                }
                else array[i] = items[iRight++];
            }

            // Can use Buffer.BlockCopy() or MsvcrtCopy for performance
            for (var i = 0; i < array.Length; i++)
            {
                sortOperator.Set(items, array[i], i + leftIndex);
            }
        }
    }
}