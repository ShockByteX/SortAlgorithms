using System;
using SortAlgorithms.Core.Sorts;

namespace SortAlgorithms.Core
{
    public static class SortFactory<T> where T : IComparable
    {
        public static ISort<T> CreateBubbleSort()
        {
            return new BubbleSort<T>();
        }

        public static ISort<T> CreateCocktailSort()
        {
            return new CocktailSort<T>();
        }

        public static ISort<T> CreateGnomeSort()
        {
            return new GnomeSort<T>();
        }

        public static ISort<T> CreateHeapSort()
        {
            return new HeapSort<T>();
        }

        public static ISort<T> CreateInsertionSort()
        {
            return new InsertionSort<T>();
        }

        public static ISort<T> CreateMergeSort()
        {
            return new MergeSort<T>();
        }

        public static ISort<T> CreateQuickSort()
        {
            return new QuickSort<T>();
        }

        public static ISort<T> CreateRadixSort()
        {
            return new RadixSort<T>();
        }

        public static ISort<T> CreateSelectionSort()
        {
            return new SelectionSort<T>();
        }

        public static ISort<T> CreateShellSort()
        {
            return new ShellSort<T>();
        }

        public static ISort<T> CreateTreeSortt()
        {
            return new TreeSort<T>();
        }
    }
}