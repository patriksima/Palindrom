using BenchmarkDotNet.Running;
using Palindrom;

var summary = BenchmarkRunner.Run<PalindromBenchmark>();

Console.WriteLine(summary.Reports.Length);