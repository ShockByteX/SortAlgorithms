using System;

namespace SortAlgorithms.Core
{
    public interface ISortResult
    {
        TimeSpan TimeSpent { get; }
        int ComparsionsCount { get; }
        int SwapsCount { get; }
        int SetsCount { get; }
    }

    internal class SortResult : ISortResult
    {
        public TimeSpan TimeSpent { get; set; }
        public int ComparsionsCount { get; set; }
        public int SwapsCount { get; set; }
        public int SetsCount { get; set; }
    }
}