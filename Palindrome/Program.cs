using BenchmarkDotNet.Running;
using Palindrome;

var summary = BenchmarkRunner.Run<PalindromeBenchmark>();

Console.WriteLine(summary.Reports.Length);