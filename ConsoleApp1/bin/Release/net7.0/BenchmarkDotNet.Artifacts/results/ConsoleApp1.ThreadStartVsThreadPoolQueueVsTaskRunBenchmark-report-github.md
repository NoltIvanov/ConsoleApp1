``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2364)
Intel Core i5-6500 CPU 3.20GHz (Skylake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|          Method |         Mean |       Error |      StdDev |          P95 | Ratio |
|---------------- |-------------:|------------:|------------:|-------------:|------:|
|     ThreadStart | 108,266.5 ns | 2,157.29 ns | 2,308.28 ns | 111,011.8 ns | 1.000 |
| ThreadPoolQueue |     776.5 ns |    15.31 ns |    20.44 ns |     809.1 ns | 0.007 |
|         TaskRun |     802.4 ns |    15.63 ns |    13.86 ns |     821.3 ns | 0.007 |
