using System;

namespace SortAlgorithms.Core.SortOperators
{
    public class EventsSortOperator<T> : ISortOperator<T> where T : IComparable
    {
        public void Set(T[] array, T item, int index)
        {
            array[index] = item;

            SetEvent?.Invoke(this, new Tuple<T, int>(item, index));
        }

        public void Swap(T[] items, int x, int y)
        {
            SwapEvent?.Invoke(this, new Tuple<int, int>(x, y));

            T temp = items[x];
            items[x] = items[y];
            items[y] = temp;
        }

        public int Compare(T[] items, int x, int y)
        {
            return Compare(items[x], items[y]);
        }

        public int Compare(T x, T y)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(x, y));

            return x.CompareTo(y);
        }

        public event EventHandler<Tuple<T, int>> SetEvent;
        public event EventHandler<Tuple<int, int>> SwapEvent;
        public event EventHandler<Tuple<T, T>> CompareEvent;
    }
}