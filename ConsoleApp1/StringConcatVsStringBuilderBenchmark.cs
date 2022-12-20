using System.Text;
using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Primitives;

namespace ConsoleApp1;

[MemoryDiagnoser]
public class StringConcatVsStringBuilderBenchmark
{
    public string str1, str2, str3, str4, str5;

    public StringConcatVsStringBuilderBenchmark()
    {
        str1 = new string('t', 50);
        str2 = new string('t', 150);
        str3 = new string('t', 300);
        str4 = new string('t', 500);
        str5 = new string('t', 1500);
    }

    [Benchmark(Baseline = true)]
    public string StringConcat() => str1 + str2 + str3 + str4 + str5;

    [Benchmark]
    public string StringConcat2()
    {
        var result = string.Empty;
        result += str1;
        result += str2;
        result += str3;
        result += str4;
        result += str5;
        return result;
    }

    [Benchmark]
    public string StringBuilder() =>
        new StringBuilder().Append(str1).Append(str2).Append(str3).Append(str4).Append(str5).ToString();

    [Benchmark]
    public string StringBuilder2() =>
        new StringBuilder(str1.Length + str2.Length + str3.Length + str4.Length + str5.Length).Append(str1).Append(str2)
            .Append(str3).Append(str4).Append(str5).ToString();
}