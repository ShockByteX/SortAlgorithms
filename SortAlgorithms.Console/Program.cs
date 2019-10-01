using System;

namespace SortAlgorithms.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
        private static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++) array[i] = i;
            return array;
        }
    }
}
