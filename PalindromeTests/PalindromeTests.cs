namespace PalindromeTests;

public class PalindromeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("", ExpectedResult = true)]
    [TestCase("a", ExpectedResult = true)]
    [TestCase("ab", ExpectedResult = false)]
    [TestCase("aba", ExpectedResult = true)]
    [TestCase("Aba", ExpectedResult = true)]
    [TestCase("0", ExpectedResult = true)]
    [TestCase("01", ExpectedResult = false)]
    [TestCase("010", ExpectedResult = true)]
    [TestCase("#123AzZa321#", ExpectedResult = true)]
    [TestCase("1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1", ExpectedResult = true)]
    [TestCase("1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1", ExpectedResult = true)]
    public bool ReverseTest(string input)
    {
        return Palindrome.Palindrome.IsPalindromReverse(input);
    }

    [TestCase("", ExpectedResult = true)]
    [TestCase("a", ExpectedResult = true)]
    [TestCase("ab", ExpectedResult = false)]
    [TestCase("aba", ExpectedResult = true)]
    [TestCase("Aba", ExpectedResult = true)]
    [TestCase("0", ExpectedResult = true)]
    [TestCase("01", ExpectedResult = false)]
    [TestCase("010", ExpectedResult = true)]
    [TestCase("#123AzZa321#", ExpectedResult = true)]
    [TestCase("1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1", ExpectedResult = true)]
    [TestCase("1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1", ExpectedResult = true)]
    public bool LoopTest(string input)
    {
        return Palindrome.Palindrome.IsPalindromLoop(input);
    }

    [TestCase("", ExpectedResult = true)]
    [TestCase("a", ExpectedResult = true)]
    [TestCase("ab", ExpectedResult = false)]
    [TestCase("aba", ExpectedResult = true)]
    [TestCase("Aba", ExpectedResult = true)]
    [TestCase("0", ExpectedResult = true)]
    [TestCase("01", ExpectedResult = false)]
    [TestCase("010", ExpectedResult = true)]
    [TestCase("#123AzZa321#", ExpectedResult = true)]
    [TestCase("1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1", ExpectedResult = true)]
    [TestCase("1+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+11+ěščřžýáíéÉÍÁÝŽŘČŠĚ+1", ExpectedResult = true)]
    public bool SpanTest(string input)
    {
        return Palindrome.Palindrome.IsPalindromSpan(input);
    }
}