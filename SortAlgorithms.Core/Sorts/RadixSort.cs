using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.Core.Sorts
{
    public class RadixSort<T> : SortBase<T> where T : IComparable
    {
        public RadixSort() { }
        public RadixSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            Queue<T>[] buckets = new Queue<T>[10];
            for (int i = 0; i < buckets.Length; i++) buckets[i] = new Queue<T>();
            int maxDigits = GetMaxDigitsCount();
            for (int digit = 0; digit < maxDigits; digit++)
            {
                foreach (T item in _array) buckets[GetDigit(item.GetHashCode(), digit)].Enqueue(item);
                int i = 0;
                foreach (Queue<T> bucket in buckets)
                {
                    while (bucket.Count > 0)
                    {
                        Compare(0, 0);
                        _array[i++] = bucket.Dequeue();
                    }
                }
            }
        }
        private int CountDigits(int value) => (int)Math.Log10(value) + 1;
        private int GetMaxDigitsCount()
        {
            int length = 0;
            foreach (T item in _array)
            {
                int value = item.GetHashCode();
                if (value < 0) throw new ArgumentException("Radix-sort doesn't supports negative values.", nameof(item));
                int l = CountDigits(value);
                if (l > length) length = l;
            }
            return length;
        }
        private int GetDigit(int value, int digitNumber) => value / (int)Math.Pow(10, digitNumber) % 10;
    }
}
