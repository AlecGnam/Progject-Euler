using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchMarks
{
    [MemoryDiagnoser]
    public class NameParserBenchmarks
    {
        [Benchmark(Baseline = true)]
        public void ProjectEuler4()
        {
            Project4.Program p = new Project4.Program();
            int answer = Project4.Program.GetNumber(p);
            
        }
    }
}
