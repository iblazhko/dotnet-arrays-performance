using System;
using ArraysPerformance.Strategies;

namespace ArraysPerformance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Comparing performance of iterating over an array of objects.");
            Console.WriteLine("");
 
            var data = GenerateTestData(50000000);
            
            var forStrategy = new ForSumRunStrategy();
            var foreachStrategy = new ForeachSumRunStrategy();
            var linqStrategy = new LinqSumRunStrategy();
            
            var runner = new PerformanceTestRunner();

            var logger = new Action<TestRunResult>(
                result => Console.WriteLine($"Strategy {result.StrategyName}: {result.ItemsCount} iterated over in {result.Duration}"));

            runner.Run(data, forStrategy, logger);
            runner.Run(data, foreachStrategy, logger);
            runner.Run(data, linqStrategy, logger);
        }
        
        private static TestData[] GenerateTestData(int count)
        {
            var rnd = new Random();
            var data = new TestData[count];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = new TestData
                {
                    Name = $"Item {i}",
                    Value = rnd.Next(count)
                };
            }

            return data;
        }
    }
}
