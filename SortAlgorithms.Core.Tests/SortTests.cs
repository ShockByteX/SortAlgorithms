using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms.Core.Sorts;
using System;

namespace SortAlgorithms.Core.Tests
{
    [TestClass()]
    public class SortTests
    {
        public const int LENGTH = 5000;
        private Random _rand = new Random();
        private int[] _array, _sorted;
        [TestInitialize]
        public void Initialize()
        {
            _array = new int[LENGTH];
            _sorted = new int[LENGTH];
            for (int i = 0; i < LENGTH; i++)
            {
                _array[i] = i;
                _sorted[i] = i;
            }
            for (int i = 0; i < LENGTH; i++)
            {
                int index = _rand.Next(0, LENGTH);
                int temp = _array[i];
                _array[i] = _array[index];
                _array[index] = temp;
            }
        }
        [TestMethod()]
        public void BubbleSortTest() => TestSort(new BubbleSort<int>(_array));
        [TestMethod()]
        public void CocktailSortTest() => TestSort(new CocktailSort<int>(_array));
        [TestMethod()]
        public void GnomeSortTest() => TestSort(new GnomeSort<int>(_array));
        [TestMethod()]
        public void SelectionSortTest() => TestSort(new SelectionSort<int>(_array));
        [TestMethod()]
        public void InsertionSortTest() => TestSort(new InsertionSort<int>(_array));
        [TestMethod()]
        public void ShellSortTest() => TestSort(new ShellSort<int>(_array));
        [TestMethod()]
        public void RadixSortTest() => TestSort(new RadixSort<int>(_array));
        [TestMethod()]
        public void TreeSortTest() => TestSort(new TreeSort<int>(_array));
        [TestMethod()]
        public void HeapSortTest() => TestSort(new HeapSort<int>(_array));
        [TestMethod()]
        public void MergeSortTest() => TestSort(new MergeSort<int>(_array));
        private void TestSort(SortBase<int> sort)
        {
            sort.Sort();
            for (int i = 0; i < LENGTH; i++) Assert.AreEqual(_sorted[i], sort.BaseArray[i]);
        }
    }
}
