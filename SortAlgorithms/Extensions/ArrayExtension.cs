using System;

namespace SortAlgorithms.Extensions
{
    public static class ArrayExtensions
    {
        private static readonly Random Random = new Random();

        public static void FillShuffle(this int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (var i = 0; i < array.Length; i++)
            {
                var index = Random.Next(0, array.Length);
                var temp = array[i];

                array[i] = array[index];
                array[index] = temp;
            }
        }

        public static void FillRandom(this int[] array, int min, int max)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = Random.Next(min, max);
            }             
        }
    }
}