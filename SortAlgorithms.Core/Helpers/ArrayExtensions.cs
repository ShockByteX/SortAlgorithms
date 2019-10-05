using System;

namespace SortAlgorithms.Core.Helpers
{
    public static class ArrayExtensions
    {
        public static T[] Take<T>(this T[] array, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, index, result, 0, length);
            return result;
        }
    }
}
