using BenchmarkDotNet.Attributes;

namespace Palindrom;

[MemoryDiagnoser]
[ThreadingDiagnoser]
[HtmlExporter, MarkdownExporter, CsvExporter]
public class PalindromBenchmark
{
    [Params("", "a", "ab", "aba", "Aba", "#1AzZa1#", "1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1")]
    public string Input { get; set; } = default!;

    [Benchmark]
    public bool ReverseTest()
    {
        return Palindrom.IsPalindromReverse(Input);
    }
    
    [Benchmark]
    public bool LoopTest()
    {
        return Palindrom.IsPalindromLoop(Input);
    }
    
    [Benchmark]
    public bool SpanTest()
    {
        return Palindrom.IsPalindromSpan(Input);
    }
}