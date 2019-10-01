using System;
using SortAlgorithms.GUI.Models;

namespace SortAlgorithms.Helpers
{
    public static class ArrayExtensions
    {
        private static Random _rand = new Random();
        //public static void FillShuffle(this SortItem[] array)
        //{
        //    for (int i = 0; i < array.Length; i++) array[i] = new SortItem(i, i);
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int index = _rand.Next(0, array.Length);
        //        SortItem temp = array[i];
        //        array[i] = array[index];
        //        array[i].Index = index;
        //        array[index] = temp;
        //        array[index].Index = temp.Index;
        //    }
        //}
        //public static void FillRandom(this SortItem[] array, int min, int max)
        //{
        //    for (int i = 0; i < array.Length; i++) array[i] = new SortItem(_rand.Next(min, max), i);
        //}
        public static void FillShuffle(this int[] array)
        {
            for (int i = 0; i < array.Length; i++) array[i] = i;
            for (int i = 0; i < array.Length; i++)
            {
                int index = _rand.Next(0, array.Length);
                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }
        public static void FillRandom(this int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++) array[i] = _rand.Next(min, max);
        }
    }
}
