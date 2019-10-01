using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class HeapSort<T> : SortBase<T> where T : IComparable
    {
        private T[] _temp;
        public HeapSort() : base() { }
        public HeapSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            HeapArrayTransformation();
            for (int i = 0; i < _array.Length; i++) _array[i] = RemoveMax(_temp.Length - i);
        }
        private void HeapArrayTransformation()
        {
            _temp = new T[_array.Length];
            Array.Copy(_array, 0, _temp, 0, _array.Length);
            for (int i = 0; i < _temp.Length; i++)
            {
                _array[i] = _temp[i];
                int currentIndex = i;
                int parentIndex = GetParentIndex(i);
                while (currentIndex > 0 && Compare(currentIndex, parentIndex) == 1)
                {
                    Swap(currentIndex, parentIndex);
                    currentIndex = parentIndex;
                    parentIndex = GetParentIndex(currentIndex);
                }
            }
            Array.Copy(_array, 0, _temp, 0, _array.Length);
        }
        private T RemoveMax(int cursor)
        {
            T item = _temp[0];
            _temp[0] = _temp[cursor - 1];
            Sort(cursor);
            return item;
        }
        private void Sort(int cursor)
        {
            for (int i = 0, maxIndex = i; i < cursor; i = maxIndex)
            {
                int leftIndex = GetLeftIndex(i);
                int rightIndex = GetRightIndex(i);
                if (leftIndex < cursor && Compare(ref _temp, leftIndex, maxIndex) == 1) maxIndex = leftIndex;
                if (rightIndex < cursor && Compare(ref _temp, rightIndex, maxIndex) == 1) maxIndex = rightIndex;
                if (i == maxIndex) return;
                Swap(ref _temp, i, maxIndex);
            }
        }
        private int GetParentIndex(int index) => (index - 1) >> 1;
        private int GetLeftIndex(int index) => (index << 1) + 1;
        private int GetRightIndex(int index) => (index << 1) + 2;

    }
}
