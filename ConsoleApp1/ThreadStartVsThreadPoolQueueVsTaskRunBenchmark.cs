using BenchmarkDotNet.Attributes;

namespace ConsoleApp1;

public class ThreadStartVsThreadPoolQueueVsTaskRunBenchmark
{
    [Benchmark(Baseline = true)]
    public void ThreadStart()
    {
        bool b = default;
        var thread = new Thread(() => b = true);
        thread.Start();
        while (!Volatile.Read(ref b)) { }
    }

    [Benchmark]
    public void ThreadPoolQueue()
    {
        bool b = default;
        ThreadPool.QueueUserWorkItem(o => b = true);
        while (!Volatile.Read(ref b)) { }
    }
    
    [Benchmark]
    public void TaskRun()
    {
        bool b = default;
        Task.Run(() => b = true);
        while (!Volatile.Read(ref b)) { }
    }
}