using System;

namespace SortAlgorithms.GUI.Models
{
    public class SortItem : IComparable
    {
        public int Value { get; set; }
        public int Index { get; set; }
        public SortItemType Type { get; set; }
        public SortItem(int value, int index)
        {
            Value = value;
            Index = index;
        }
        public int CompareTo(object obj) => obj is SortItem item ? Value.CompareTo(item.Value) : throw new ArgumentException($"{nameof(obj)} is not {nameof(SortItem)}", nameof(obj));
        public override bool Equals(object obj) => obj is SortItem item ? Value == item.Value && Index == item.Index : false;
        public override int GetHashCode() => Value;
        public override string ToString() => $"Value: {Value}, Index: {Index}";
    }
}
