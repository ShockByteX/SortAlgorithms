using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SortAlgorithms.Core.SortOperators;

namespace SortAlgorithms.Core.Tests
{
    [TestClass()]
    public class SortTests
    {
        public const int ArrayLength = 5000;

        private static readonly Random Random = new Random();

        private int[] _shuffledArray;
        private int[] _sortedArray;

        private ISorter<int> _sorter;

        [TestInitialize]
        public void Initialize()
        {
            _shuffledArray = new int[ArrayLength];
            _sortedArray = new int[ArrayLength];

            for (var i = 0; i < ArrayLength; i++)
            {
                _shuffledArray[i] = i;
                _sortedArray[i] = i;
            }

            for (var i = 0; i < ArrayLength; i++)
            {
                var index = Random.Next(0, ArrayLength);
                var temp = _shuffledArray[i];

                _shuffledArray[i] = _shuffledArray[index];
                _shuffledArray[index] = temp;
            }

            _sorter = new Sorter<int>();
        }
        [TestMethod()]
        public void BubbleSortTest() => TestSort(SortFactory<int>.CreateBubbleSort());
        [TestMethod()]
        public void CocktailSortTest() => TestSort(SortFactory<int>.CreateCocktailSort());
        [TestMethod()]
        public void GnomeSortTest() => TestSort(SortFactory<int>.CreateGnomeSort());
        [TestMethod()]
        public void SelectionSortTest() => TestSort(SortFactory<int>.CreateSelectionSort());
        [TestMethod()]
        public void InsertionSortTest() => TestSort(SortFactory<int>.CreateInsertionSort());
        [TestMethod()]
        public void ShellSortTest() => TestSort(SortFactory<int>.CreateShellSort());
        [TestMethod()]
        public void RadixSortTest() => TestSort(SortFactory<int>.CreateRadixSort());
        [TestMethod()]
        public void TreeSortTest() => TestSort(SortFactory<int>.CreateTreeSortt());
        [TestMethod()]
        public void HeapSortTest() => TestSort(SortFactory<int>.CreateHeapSort());
        [TestMethod()]
        public void MergeSortTest() => TestSort(SortFactory<int>.CreateMergeSort());
        [TestMethod()]
        public void QuickSortTest() => TestSort(SortFactory<int>.CreateQuickSort());

        private void TestSort(ISort<int> sort)
        {
            var clone = new int[ArrayLength];

            Array.Copy(_shuffledArray, clone, ArrayLength);

            _sorter.Sort(clone, sort);

            for (var i = 0; i < ArrayLength; i++)
            {
                Assert.AreEqual(_sortedArray[i], clone[i]);
            }
        }
    }
}