using System;

namespace SortAlgorithms.Core.Extensions
{
    public static class ArrayExtension
    {
        public static Tuple<T, T> GetMinMax<T>(this T[] items) where T : IComparable
        {
            T min = items[0];
            T max = items[0];

            for (var i = 0; i < items.Length; i++)
            {
                var item = items[i];

                min = item.CompareTo(min) == -1 ? item : min;
                max = item.CompareTo(max) == 1 ? item : max;
            }

            return new Tuple<T, T>(min, max);
        }

        public static bool IsSorted<T>(this T[] items) where T : IComparable
        {
            for (var i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(items[i - 1]) == -1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}