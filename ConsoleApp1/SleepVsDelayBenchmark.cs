using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    public class SleepVsDelayBenchmark
    {
        [Params(1, 5, 50)]
        public int Duration { get; set; }

        [Benchmark]
        public void ThreadSleep() => Thread.Sleep(Duration);

        [Benchmark]
        public Task TaskDelay() => Task.Delay(Duration);
    }
}
