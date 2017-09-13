using System;
using System.Linq;

namespace ArraysPerformance.Strategies
{
    public class LinqSumRunStrategy : IRunStrategy
    {
        public string Name { get; } = "<LINQ Aggregate> SUM";
        public long Sum { get; private set; }

        public void Run(TestData[] data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            Sum = data.Aggregate<TestData, long>(0, (current, t) => current + t.Value);
        }
    }
}
