# string-without-memory-allocations-dotnet

[![.NET](https://github.com/fernandezja/string-without-memory-allocations-dotnet/actions/workflows/CI-dotnet.yml/badge.svg)](https://github.com/fernandezja/string-without-memory-allocations-dotnet/actions/workflows/CI-dotnet.yml)

### Benchmark summary .NET 6 (baseline) & .NET 7

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.1281/21H2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2  [AttachedDebugger]
  .NET 6.0 : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


|                             Method |      Job |  Runtime |      Mean |     Error |     StdDev |    Median | Ratio | RatioSD |   Gen0 | Allocated | Alloc Ratio |
|----------------------------------- |--------- |--------- |----------:|----------:|-----------:|----------:|------:|--------:|-------:|----------:|------------:|
|                    Option1ToString | .NET 6.0 | .NET 6.0 | 28.759 ns | 1.8332 ns |  5.2598 ns | 27.226 ns |  1.00 |    0.00 | 0.0344 |     144 B |        1.00 |
|                      Option2CopyTo | .NET 6.0 | .NET 6.0 | 41.111 ns | 2.6935 ns |  7.4636 ns | 39.530 ns |  1.47 |    0.38 | 0.0363 |     152 B |        1.06 |
| Option3ReadOnlyMemoryCharGetChunks | .NET 6.0 | .NET 6.0 |  8.672 ns | 0.4047 ns |  1.1414 ns |  8.296 ns |  0.31 |    0.06 |      - |         - |        0.00 |
|                    Option1ToString | .NET 7.0 | .NET 7.0 | 30.577 ns | 1.9726 ns |  5.5637 ns | 29.540 ns |  1.10 |    0.27 | 0.0344 |     144 B |        1.00 |
|                      Option2CopyTo | .NET 7.0 | .NET 7.0 | 41.931 ns | 3.7643 ns | 11.0400 ns | 40.218 ns |  1.52 |    0.53 | 0.0363 |     152 B |        1.06 |
| Option3ReadOnlyMemoryCharGetChunks | .NET 7.0 | .NET 7.0 |  8.307 ns | 0.2452 ns |  0.6834 ns |  8.270 ns |  0.30 |    0.05 |      - |         - |        0.00 |

