using System;

namespace SortAlgorithms.Core
{
    public interface ISort<T> where T : IComparable
    {
        void Sort(T[] items, ISortOperator<T> sortOperator);
    }
}