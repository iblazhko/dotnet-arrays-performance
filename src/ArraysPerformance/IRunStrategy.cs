namespace ArraysPerformance
{
    public interface IRunStrategy
    {
        string Name { get; }
        void Run(TestData[] data);
    }
}
