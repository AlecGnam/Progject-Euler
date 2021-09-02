using BenchmarkDotNet.Running;
using System;

namespace BenchMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NameParserBenchmarks>();
        }
    }
}
