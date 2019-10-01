using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.Core.Sorts
{
    public class CocktailSort<T> : SortBase<T> where T : IComparable
    {
        public CocktailSort() { }
        public CocktailSort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            bool isDone = false;
            int left = 0, right = _array.Length - 1;
            while (!isDone)
            {
                isDone = true;
                for (int i = left; i < right; i++)
                {
                    if (Compare(i, i + 1) == 1)
                    {
                        Swap(i, i + 1);
                        isDone = false;
                    }
                }
                if (isDone) return;
                right--;
                for (int i = right; i > left; i--)
                {
                    if (Compare(i, i - 1) == -1)
                    {
                        Swap(i, i - 1);
                        isDone = false;
                    }
                }
                left++;
            }
        }
    }
}
