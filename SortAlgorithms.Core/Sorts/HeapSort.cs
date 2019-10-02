using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class HeapSort<T> : SortBase<T> where T : IComparable
    {
        private int _count;
        public HeapSort() { }
        public HeapSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            _count = 0;
            for (int i = _array.Length; i >= 0; i--)
            {
                Sort(i);
                _count++;
            }
            for (int i = _count - 1; i >= 0; i--)
            {
                Swap(0, i);
                Sort(0, i);
            }
        }
        private T RemoveTop()
        {
            T item = _array[0];
            _array[0] = _array[--_count];
            Sort(0);
            return item;
        }
        private void Sort(int currentIndex, int maxLength = -1)
        {
            maxLength = maxLength == -1 ? _array.Length : maxLength;
            for (int i = currentIndex, maxIndex = i; currentIndex < maxLength; i = maxIndex)
            {
                int leftIndex = GetLeftIndex(i);
                int rightIndex = GetRightIndex(i);
                if (leftIndex < maxLength && Compare(leftIndex, maxIndex) == 1) maxIndex = leftIndex;
                if (rightIndex < maxLength && Compare(rightIndex, maxIndex) == 1) maxIndex = rightIndex;
                if (i == maxIndex) return;
                Swap(i, maxIndex);
            }
        }
        private int GetParentIndex(int index) => (index - 1) >> 1;
        private int GetLeftIndex(int index) => (index << 1) + 1;
        private int GetRightIndex(int index) => (index << 1) + 2;
    }
}
