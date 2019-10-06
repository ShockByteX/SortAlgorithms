using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class MergeSort<T> : SortBase<T> where T : IComparable
    {
        public MergeSort() { }
        public MergeSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            Sort(0, _array.Length);
        }
        private void Sort(int index, int length)
        {
            if (length == 1) return;
            int leftLength = length / 2;
            int rightIndex = index + leftLength;
            int rightLength = length - leftLength;
            Sort(index, leftLength);
            Sort(rightIndex, rightLength);
            Merge(index, leftLength, index + leftLength, length - leftLength);
        }
        private void Merge(int leftIndex, int leftLength, int rightIndex, int rightLength)
        {
            T[] array = new T[leftLength + rightLength];
            for (int i = 0, iLeft = leftIndex, iRight = rightIndex; i < array.Length; i++)
            {
                if (iLeft < leftIndex + leftLength)
                {
                    if (iRight < rightIndex + rightLength)
                    {
                        if (Compare(iLeft, iRight) == -1) array[i] = _array[iLeft++]; else array[i] = _array[iRight++];
                    }
                    else array[i] = _array[iLeft++];
                }
                else array[i] = _array[iRight++];
            }
            for (int i = 0; i < array.Length; i++) Set(i + leftIndex, array[i]); // Can use Array.Copy() for performance
        }
    }
}
