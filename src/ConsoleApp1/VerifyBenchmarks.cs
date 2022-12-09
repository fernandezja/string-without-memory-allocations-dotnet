using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net70)]
    //ClrJob(baseline: true), CoreJob, MonoJob, CoreRtJob]
    //[RPlotExporter, RankColumn]
    public class VerifyBenchmarks
    {
        private StringManager _stringManager = new();

        
        [Benchmark(Baseline = true)]
        public void Option1ToString()
        {
            var option1 = _stringManager.Option1ToString();
        }

        
        [Benchmark]
        public void Option2CopyTo()
        {
            var option2 = _stringManager.Option2CopyTo();
        }

        
        [Benchmark]
        public void Option3ReadOnlyMemoryCharGetChunks()
        {
            var option3 = _stringManager.Option3ReadOnlyMemoryCharGetChunks();
        }
    }
}