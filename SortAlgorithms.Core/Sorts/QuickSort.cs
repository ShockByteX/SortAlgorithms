using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class QuickSort<T> : SortBase<T> where T : IComparable
    {
        private Random _rand = new Random();
        public QuickSort() { }
        public QuickSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            QSort(0, _array.Length - 1);
        }
        private void QSort(int left, int right)
        {
            if (left >= right) return;
            int pivot = Partition(left, right);
            QSort(left, pivot - 1);
            QSort(pivot + 1, right);
        }
        private int Partition(int left, int right)
        {
            int pointer = left; // Опорный элемент находится под right
            for (int i = left; i <= right; i++)
            {
                if (Compare(_array[i], _array[right]) == -1) Swap(i, pointer++);
            }
            Swap(pointer, right);
            return pointer;
        }
    }
}
