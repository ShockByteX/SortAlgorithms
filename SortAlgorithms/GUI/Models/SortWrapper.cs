using SortAlgorithms.Core;
using System;

namespace SortAlgorithms.GUI.Models
{
    public class SortWrapper
    {
        public SortWrapper(string name, ISort<int> sort)
        {
            Name = name;
            Sort = sort;
        }

        public string Name { get; }
        public ISort<int> Sort { get; }

        public override string ToString() => Name;

        public static SortWrapper Create(Type type)
        {
            var name = type.Name.Remove(type.Name.Length - 2, 2);
            var sort = (ISort<int>)Activator.CreateInstance(type.MakeGenericType(typeof(int)));

            return new SortWrapper(name, (ISort<int>)sort);
        }
    }
}