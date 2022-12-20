using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using ConsoleApp1;

try
{
    //BenchmarkRunner.Run<SleepVsDelayBenchmark>();
    //BenchmarkRunner.Run<ThreadStartVsThreadPoolQueueVsTaskRunBenchmark>(DefaultConfig.Instance.AddColumn(StatisticColumn.P95));
    BenchmarkRunner.Run<StringConcatVsStringBuilderBenchmark>();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}



