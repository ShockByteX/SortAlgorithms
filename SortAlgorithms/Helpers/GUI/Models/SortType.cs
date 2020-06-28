using System;

namespace SortAlgorithms.GUI.Models
{
    public class SortType
    {
        public Type Type { get; private set; }
        public SortType(Type type) => Type = type;
        public override string ToString() => Type.Name.Remove(Type.Name.Length - 2, 2);
    }
}
