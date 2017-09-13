using System;

namespace ArraysPerformance.Strategies
{
    public class ForeachSumRunStrategy : IRunStrategy
    {
        public string Name { get; } = "<foreach> SUM";
        public long Sum { get; private set; }

        public void Run(TestData[] data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            long sum = 0;

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var t in data)
            {
                sum += t.Value;
            }

            Sum = sum;
        }
    }
}
