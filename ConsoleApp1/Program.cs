using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ConsoleApp1;

try
{
    BenchmarkRunner.Run<ThreadStartVsThreadPoolQueueVsTaskRunBenchmark>(DefaultConfig.Instance.AddColumn(StatisticColumn.P95));
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}



