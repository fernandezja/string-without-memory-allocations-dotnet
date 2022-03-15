# string-without-memory-allocations-dotnet

#### Summary

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.200
Host     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT



|                             Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |  Gen 0 | Allocated |
|----------------------------------- |---------:|---------:|---------:|---------:|------:|--------:|-------:|----------:|
|                    Option1ToString | 22.29 ns | 0.474 ns | 1.011 ns | 22.04 ns |  1.00 |    0.00 | 0.0325 |     136 B |
|                      Option2CopyTo | 43.98 ns | 1.353 ns | 3.772 ns | 42.88 ns |  1.93 |    0.16 | 0.0669 |     280 B |
| Option3ReadOnlyMemoryCharGetChunks | 17.06 ns | 1.188 ns | 3.483 ns | 15.88 ns |  0.87 |    0.14 |      - |         - |

