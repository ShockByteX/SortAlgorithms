using System;
using System.Collections.Generic;

namespace SortAlgorithms.Core.Sorts
{
    public class BogoSort<T> : SortBase<T> where T : IComparable
    {
        private Random _rand = new Random();
        public BogoSort() { }
        public BogoSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            while (!IsSorted())
            {
                for (int i = 0; i < _array.Length; i++) Swap(i, _rand.Next(0, _array.Length));
            }
        }
        private void Shuffle()
        {
            for (int i = 0; i < _array.Length; i++) Swap(0, _rand.Next(0, _array.Length));
        }
        private bool IsSorted()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                if (Compare(i, i - 1) == -1) return false;
            }
            return true;
        }
    }
}
