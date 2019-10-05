using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SortAlgorithms.Core
{
    public abstract class SortBase<T> where T : IComparable
    {
        protected T[] _array;
        public T[] BaseArray => _array;
        public int ComparsionsCount { get; protected set; }
        public int SwapsCount { get; protected set; }
        public int SetsCount { get; protected set; }
        public SortBase() { }
        public SortBase(IEnumerable<T> items) => ApplyArray(items);
        public void ApplyArray(IEnumerable<T> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            _array = items.ToArray();
            Clear();
        }
        public TimeSpan Sort()
        {
            Clear();
            Stopwatch sw = Stopwatch.StartNew();
            DoSort();
            sw.Stop();
            return sw.Elapsed;
        }
        protected abstract void DoSort();
        protected int Compare(int left, int right) => Compare(_array[left], _array[right]);
        protected int Compare(T left, T right)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(left, right));
            ComparsionsCount++;
            return left.CompareTo(right);
        }
        protected void Swap(int left, int right)
        {
            if (left < _array.Length && right < _array.Length)
            {
                T temp = _array[left];
                _array[left] = _array[right];
                _array[right] = temp;
                SwapsCount++;
                SwapEvent?.Invoke(this, new Tuple<int, int>(left, right));
            }
        }
        protected void Set(int index, T item)
        {
            if (index < _array.Length)
            {
                SetEvent?.Invoke(this, new Tuple<int, T>(index, item));
                _array[index] = item;
                SetsCount++;
            }
        }
        protected void Clear()
        {
            ComparsionsCount = 0;
            SwapsCount = 0;
            SetsCount = 0;
        }
        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<int, int>> SwapEvent;
        public event EventHandler<Tuple<int, T>> SetEvent;
    }
}
