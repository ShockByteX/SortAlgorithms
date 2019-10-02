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
        protected int Compare(int index1, int index2)
        {
            CompareEvent?.Invoke(this, new Tuple<int, int>(index1, index2));
            ComparsionsCount++;
            return _array[index1].CompareTo(_array[index2]);
        }
        protected void Swap(int index1, int index2)
        {
            if (index1 < _array.Length && index2 < _array.Length)
            {
                T temp = _array[index1];
                _array[index1] = _array[index2];
                _array[index2] = temp;
                SwapsCount++;
                SwapEvent?.Invoke(this, new Tuple<int, int>(index1, index2));
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
        public event EventHandler<Tuple<int, int>> CompareEvent;
        public event EventHandler<Tuple<int, int>> SwapEvent;
        public event EventHandler<Tuple<int, T>> SetEvent;
    }
}
