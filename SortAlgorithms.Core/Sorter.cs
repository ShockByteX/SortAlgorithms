using SortAlgorithms.Core.SortOperators;
using System;
using System.Diagnostics;

namespace SortAlgorithms.Core
{
    public interface ISorter<T> where T : IComparable
    {
        ISortResult Sort(T[] items, ISort<T> sort);

        event EventHandler<Tuple<T, int>> SetEvent;
        event EventHandler<Tuple<int, int>> SwapEvent;
        event EventHandler<Tuple<T, T>> CompareEvent;
    }

    public class Sorter<T> : ISorter<T> where T : IComparable
    {
        private readonly ISortOperator<T> _sortOperator;

        private SortResult _result;

        public Sorter()
        {
            var sortOperator = new EventsSortOperator<T>();

            sortOperator.SetEvent += OnSet;
            sortOperator.SwapEvent += OnSwap;
            sortOperator.CompareEvent += OnCompare;

            _sortOperator = sortOperator;
        }

        public ISortResult Sort(T[] items, ISort<T> sort)
        {
            _result = new SortResult();

            Stopwatch sw = Stopwatch.StartNew();
            sort.Sort(items, _sortOperator);
            sw.Stop();

            _result.TimeSpent = sw.Elapsed;

            return _result;
        }

        private void OnSet(object sender, Tuple<T, int> e)
        {
            _result.SetsCount++;

            SetEvent?.Invoke(this, e);
        }

        private void OnSwap(object sender, Tuple<int, int> e)
        {
            _result.SwapsCount++;

            SwapEvent?.Invoke(this, e);
        }

        private void OnCompare(object sender, Tuple<T, T> e)
        {
            _result.ComparsionsCount++;

            CompareEvent?.Invoke(this, e);
        }

        public event EventHandler<Tuple<T, int>> SetEvent;
        public event EventHandler<Tuple<int, int>> SwapEvent;
        public event EventHandler<Tuple<T, T>> CompareEvent;
    }
}