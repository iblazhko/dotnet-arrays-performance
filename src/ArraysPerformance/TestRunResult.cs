using System;

namespace ArraysPerformance
{
    public class TestRunResult
    {
        public string StrategyName { get; set; }
        public int ItemsCount { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
