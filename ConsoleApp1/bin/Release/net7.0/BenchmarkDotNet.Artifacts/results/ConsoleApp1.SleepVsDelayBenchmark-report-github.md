``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2364)
Intel Core i5-6500 CPU 3.20GHz (Skylake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|      Method | Duration |     Mean |    Error |   StdDev |
|------------ |--------- |---------:|---------:|---------:|
| **ThreadSleep** |        **1** | **15.42 ms** | **0.031 ms** | **0.028 ms** |
|   TaskDelay |        1 | 15.45 ms | 0.048 ms | 0.045 ms |
| **ThreadSleep** |        **5** | **15.54 ms** | **0.095 ms** | **0.084 ms** |
|   TaskDelay |        5 | 15.53 ms | 0.033 ms | 0.029 ms |
| **ThreadSleep** |       **50** | **62.20 ms** | **0.376 ms** | **0.351 ms** |
|   TaskDelay |       50 | 61.88 ms | 0.299 ms | 0.250 ms |
