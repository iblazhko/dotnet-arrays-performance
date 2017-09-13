using System;

namespace ArraysPerformance.Strategies
{
    public class ForSumRunStrategy : IRunStrategy
    {
        public string Name { get; } = "<for> SUM";
        public long Sum { get; private set; }
        
        public void Run(TestData[] data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            long sum = 0;
            
            // ReSharper disable once ForCanBeConvertedToForeach
            for (var i = 0; i < data.Length; i++)
            {
                sum += data[i].Value;
            }

            Sum = sum;
        }
    }
}