using System;
using System.Diagnostics;

namespace ArraysPerformance
{
    public class PerformanceTestRunner
    {
        public void Run(TestData[] data, IRunStrategy strategy, Action<TestRunResult> logResult)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (strategy == null) throw new ArgumentNullException(nameof(strategy));
            if (logResult == null) throw new ArgumentNullException(nameof(logResult));
            
            var watch = Stopwatch.StartNew();
            strategy.Run(data);
            watch.Stop();

            var result = new TestRunResult
            {
                StrategyName = strategy.Name,
                ItemsCount = data.Length,
                Duration = watch.Elapsed
            };

            logResult(result);
        }
    }
}
