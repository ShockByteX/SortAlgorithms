using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.Core.Sorts
{
    public class MySort<T> : SortBase<T> where T : IComparable
    {
        public MySort() { }
        public MySort(IEnumerable<T> items) : base(items) { }
        protected override void DoSort()
        {
            int indexOfMax = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (Compare(i, indexOfMax) == 1) indexOfMax = i;
            }
            Swap(indexOfMax, BaseArray.Length - 1);
            indexOfMax = BaseArray.Length - 1;
            while (indexOfMax != 0)
            {
                int maxIndex = 0;
                for (int i = 0; i < indexOfMax; i++)
                {
                    if (Compare(i, maxIndex) == 1) maxIndex = i;
                }
                Swap(maxIndex, --indexOfMax);
            }
        }
    }
}
