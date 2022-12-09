# string-without-memory-allocations-dotnet

### Summary .NET 7.0.0 (7.0.22.51805)

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.1281/21H2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

|                             Method |     Mean |    Error |   StdDev | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|----------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
|                    Option1ToString | 25.36 ns | 0.542 ns | 1.095 ns |  1.00 |    0.00 | 0.0344 |     144 B |        1.00 |
|                      Option2CopyTo | 39.84 ns | 0.815 ns | 1.428 ns |  1.57 |    0.08 | 0.0669 |     280 B |        1.94 |
| Option3ReadOnlyMemoryCharGetChunks | 14.68 ns | 0.337 ns | 0.544 ns |  0.58 |    0.03 |      - |         - |        0.00 |


### Summary .NET 6.0.2 (6.0.222.6406)

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

