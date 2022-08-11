using BenchmarkDotNet.Attributes;

namespace Palindrome;

[MemoryDiagnoser]
[ThreadingDiagnoser]
[HtmlExporter, MarkdownExporter, CsvExporter]
public class PalindromeBenchmark
{
    [Params("", "a", "ab", "aba", "Aba", "#1AzZa1#", "1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1")]
    public string Input { get; set; } = default!;

    [Benchmark]
    public bool ReverseTest()
    {
        return Palindrome.IsPalindromReverse(Input);
    }
    
    [Benchmark]
    public bool LoopTest()
    {
        return Palindrome.IsPalindromLoop(Input);
    }
    
    [Benchmark]
    public bool SpanTest()
    {
        return Palindrome.IsPalindromSpan(Input);
    }
}