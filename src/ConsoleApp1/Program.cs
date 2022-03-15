// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using ConsoleApp1;
using System.Text;

Console.WriteLine(" benchmarks!");
var summary = BenchmarkRunner.Run<VerifyBenchmarks>();

Console.ReadKey();