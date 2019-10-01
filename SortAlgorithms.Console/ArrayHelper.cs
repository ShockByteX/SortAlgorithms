using System;

namespace SortAlgorithms.ConsoleApp
{
    public static class ArrayHelper
    {
        private static Random _rand = new Random(DateTime.Now.Millisecond);
        public static void Shuffle<T>(this T[] array)
        {
            for (int i = 0; i < array.Length; i++) Swap(ref array[i], ref array[_rand.Next(0, array.Length)]);
        }
        public static void Print<T>(this T[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
