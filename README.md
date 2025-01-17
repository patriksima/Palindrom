﻿# Palindrome

Performance test of several methods to check the input string for palindrome.

A palindrome is a word, number, phrase, or other sequence of characters which reads the same backward as forward, such as madam or racecar.

1) **ReverseTest** method uses string.Reverse()
2) **LoopTest** method uses loop for a index
3) **SpanTest** method uses unsafe context, readonly span and pointers in while loop

A **simple loop** seems to be the best solution in terms of performance:

``` csharp
public bool IsPalindromeLoop(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        return true;
    }

    var j = input.Length - 1;

    for (var i = 0; i < input.Length / 2; i++)
    {
        var left = input[i];
        var right = input[j - i];
        if (char.ToLowerInvariant(left) != char.ToLowerInvariant(right))
        {
            return false;
        }
    }

    return true;
}
```

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores
.NET SDK=6.0.303
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT


```
|      Method |                Input |       Mean |     Error |     StdDev |     Median | Completed Work Items | Lock Contentions |  Gen 0 | Allocated |
|------------ |--------------------- |-----------:|----------:|-----------:|-----------:|---------------------:|-----------------:|-------:|----------:|
| **ReverseTest** |                     **** |   **2.007 ns** | **0.0160 ns** |  **0.0149 ns** |   **2.006 ns** |                    **-** |                **-** |      **-** |         **-** |
|    LoopTest |                      |   2.231 ns | 0.0208 ns |  0.0194 ns |   2.228 ns |                    - |                - |      - |         - |
|    SpanTest |                      |   2.182 ns | 0.0653 ns |  0.0802 ns |   2.173 ns |                    - |                - |      - |         - |
| **ReverseTest** |             **#1AzZa1#** | **240.768 ns** | **3.1385 ns** |  **3.9692 ns** | **241.112 ns** |                    **-** |                **-** | **0.0305** |     **192 B** |
|    LoopTest |             #1AzZa1# |  18.957 ns | 0.2280 ns |  0.2021 ns |  18.936 ns |                    - |                - |      - |         - |
|    SpanTest |             #1AzZa1# |  21.154 ns | 0.1880 ns |  0.1468 ns |  21.156 ns |                    - |                - |      - |         - |
| **ReverseTest** | **1+ěšč(...)ČŠĚ+1 [22]** | **478.518 ns** | **8.9228 ns** | **16.0897 ns** | **470.760 ns** |                    **-** |                **-** | **0.0706** |     **448 B** |
|    LoopTest | 1+ěšč(...)ČŠĚ+1 [22] | 326.415 ns | 5.3685 ns |  4.4830 ns | 327.455 ns |                    - |                - |      - |         - |
|    SpanTest | 1+ěšč(...)ČŠĚ+1 [22] | 328.454 ns | 1.8821 ns |  1.6685 ns | 328.244 ns |                    - |                - |      - |         - |
| **ReverseTest** |                  **Aba** | **161.541 ns** | **1.5774 ns** |  **1.4755 ns** | **161.722 ns** |                    **-** |                **-** | **0.0279** |     **176 B** |
|    LoopTest |                  Aba |   7.285 ns | 0.0304 ns |  0.0238 ns |   7.283 ns |                    - |                - |      - |         - |
|    SpanTest |                  Aba |   7.902 ns | 0.1121 ns |  0.1048 ns |   7.853 ns |                    - |                - |      - |         - |
| **ReverseTest** |                    **a** | **114.406 ns** | **0.8297 ns** |  **0.7761 ns** | **114.578 ns** |                    **-** |                **-** | **0.0267** |     **168 B** |
|    LoopTest |                    a |   3.429 ns | 0.0276 ns |  0.0258 ns |   3.419 ns |                    - |                - |      - |         - |
|    SpanTest |                    a |   3.889 ns | 0.0681 ns |  0.0637 ns |   3.889 ns |                    - |                - |      - |         - |
| **ReverseTest** |                   **ab** | **129.687 ns** | **1.7197 ns** |  **1.5245 ns** | **129.663 ns** |                    **-** |                **-** | **0.0279** |     **176 B** |
|    LoopTest |                   ab |   6.754 ns | 0.0978 ns |  0.0816 ns |   6.730 ns |                    - |                - |      - |         - |
|    SpanTest |                   ab |   6.877 ns | 0.0468 ns |  0.0415 ns |   6.875 ns |                    - |                - |      - |         - |
| **ReverseTest** |                  **aba** | **128.894 ns** | **1.5863 ns** |  **1.4839 ns** | **128.895 ns** |                    **-** |                **-** | **0.0279** |     **176 B** |
|    LoopTest |                  aba |   6.529 ns | 0.0649 ns |  0.0542 ns |   6.515 ns |                    - |                - |      - |         - |
|    SpanTest |                  aba |   6.812 ns | 0.0727 ns |  0.0680 ns |   6.772 ns |                    - |                - |      - |         - |
