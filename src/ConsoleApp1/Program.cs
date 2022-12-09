using BenchmarkDotNet.Running;
using ConsoleApp1;

Console.WriteLine("Benchmarks! > string-without-memory-allocations-dotnet");
Console.WriteLine("------------------------------------------------------");
var summary = BenchmarkRunner.Run<VerifyBenchmarks>();

Console.ReadKey();