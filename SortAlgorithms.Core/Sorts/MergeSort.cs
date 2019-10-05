using System;
using System.Collections.Generic;
using SortAlgorithms.Core.Helpers;

namespace SortAlgorithms.Core.Sorts
{
    public class MergeSort<T> : SortBase<T> where T : IComparable
    {
        public MergeSort() { }
        public MergeSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            //Stack<Tuple<MergedArray, MergedArray>> stack = new Stack<Tuple<MergedArray, MergedArray>>();
            //Split(stack, new MergedArray(0, _array.Length));
            //while (stack.Count > 0)
            //{
            //    Merge(stack.Pop());
            //}
            T[] array = Sort(_array);
            for (int i = 0; i < array.Length; i++) Set(i, array[i]);
        }
        private T[] Sort(T[] array)
        {
            if (array.Length == 1) return array;
            T[] left = array.Take(0, array.Length / 2);
            T[] right = array.Take(left.Length, array.Length - left.Length);
            return Merge(Sort(left), Sort(right));
        }
        private T[] Merge(T[] left, T[] right)
        {
            T[] array = new T[left.Length + right.Length];
            for (int i = 0, iLeft = 0, iRight = 0; i < array.Length; i++)
            {
                if (iLeft < left.Length)
                {
                    if (iRight < right.Length)
                    {
                        if (Compare(left[iLeft], right[iRight]) == -1) array[i] = left[iLeft++]; else array[i] = right[iRight++];
                    }
                    else array[i] = left[iLeft++];
                }
                else array[i] = right[iRight++];
            }
            return array;
        }
        //private void Split(Stack<Tuple<MergedArray, MergedArray>> stack, MergedArray array)
        //{
        //    MergedArray left = new MergedArray(array.Index, array.Length / 2);
        //    MergedArray right = new MergedArray(left.Index + left.Length, array.Length - left.Length);
        //    stack.Push(new Tuple<MergedArray, MergedArray>(left, right));
        //    if (left.Length > 1) Split(stack, left);
        //    if (right.Length > 1) Split(stack, right);
        //}
        //private MergedArray Merge(Tuple<MergedArray, MergedArray> tuple)
        //{
        //    MergedArray left = tuple.Item1;
        //    MergedArray right = tuple.Item2;
        //    MergedArray merged = new MergedArray(left.Index, left.Length + right.Length);
        //    Queue<int> indexes = new Queue<int>();
        //    for (int i = 0, iLeft = left.Index, iRight = right.Index; i < merged.Length; i++)
        //    {
        //        if (iLeft < left.Index + left.Length)
        //        {
        //            if (iRight < right.Index + right.Length)
        //            {
        //                if (Compare(iLeft, iRight) == -1) indexes.Enqueue(iLeft++); else indexes.Enqueue(iRight++);
        //            }
        //            else indexes.Enqueue(iLeft++);
        //        }
        //        else indexes.Enqueue(iRight++);
        //    }
        //    while (indexes.Count > 0)
        //    {
        //        //Swap();
        //    }
        //    return merged;
        //}
        //private struct MergedArray
        //{
        //    public int Index;
        //    public int Length;
        //    public MergedArray(int index, int length)
        //    {
        //        Index = index;
        //        Length = length;
        //    }
        //}
    }
}
