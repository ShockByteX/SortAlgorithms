using System;

namespace SortAlgorithms.Helpers
{
    public static class ArrayExtensions
    {
        private static Random _rand = new Random();
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
