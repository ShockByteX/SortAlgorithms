using System.Collections.Generic;

namespace SortAlgorithms.Core
{
    public interface ISortOperator<T> : IComparer<T>
    {
        void Set(T[] items, T item, int index);
        void Swap(T[] items, int left, int right);
        int Compare(T[] items, int left, int right);
    }
}