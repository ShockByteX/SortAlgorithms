using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class RadixSort<T> : ISort<T> where T : IComparable
    {
        public void Sort(T[] items, ISortOperator<T> sortOperator)
        {
            var buckets = new Queue<T>[10];

            for (var i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new Queue<T>();
            }

            var maxDigits = GetMaxDigitsCount(items);

            for (var digit = 0; digit < maxDigits; digit++)
            {
                foreach (T item in items)
                {
                    buckets[GetDigit(item.GetHashCode(), digit)].Enqueue(item);
                }

                int i = 0;

                foreach (var bucket in buckets)
                {
                    while (bucket.Count > 0)
                    {
                        sortOperator.Compare(items, 0, 0); // Just for visual

                        items[i++] = bucket.Dequeue();
                    }
                }
            }
        }

        private static int CountDigits(int value) => (int)Math.Log10(value) + 1;

        private static int GetMaxDigitsCount(T[] items)
        {  
            var length = 0;

            foreach (T item in items)
            {
                var value = item.GetHashCode();

                if (value < 0)
                {
                    throw new ArgumentException("Radix-sort doesn't supports negative values.", nameof(item));
                }

                var digitsCount = CountDigits(value);

                if (digitsCount > length)
                {
                    length = digitsCount;
                }
            }

            return length;
        }

        private static int GetDigit(int value, int digitNumber) => value / (int)Math.Pow(10, digitNumber) % 10;
    }
}