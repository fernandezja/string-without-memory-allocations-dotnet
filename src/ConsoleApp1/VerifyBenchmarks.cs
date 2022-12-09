using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [MemoryDiagnoser]
    //ClrJob(baseline: true), CoreJob, MonoJob, CoreRtJob]
    //[RPlotExporter, RankColumn]
    public class VerifyBenchmarks
    {
        private const string PHRASE  = "The Force is strong with you!";
        private StringBuilder _sb = new();

        public VerifyBenchmarks()
        {

            _sb.Append($"[{DateTime.UtcNow}] [{Environment.CurrentManagedThreadId}] {PHRASE}");

        }
        
        [Benchmark(Baseline = true)]
        public void Option1ToString()
        {
            var option1 = _sb.ToString();
        }

        [Benchmark]
        public void Option2CopyTo()
        {
            var option2Buffer = new char[128];
            
            _sb.CopyTo(sourceIndex: 0,
                      destination: option2Buffer.AsSpan(),
                      count: _sb.Length);

        }

        [Benchmark]
        public void Option3ReadOnlyMemoryCharGetChunks()
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.getchunks?view=net-6.0

            foreach (ReadOnlyMemory<char> chunk in _sb.GetChunks())
            {
                var span = chunk.Span;
            }
        }
    }
}