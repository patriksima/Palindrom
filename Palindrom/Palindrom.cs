namespace Palindrom;

public static class Palindrom
{
    public static bool IsPalindromReverse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }

        var reversed = new string(input.Reverse().ToArray());
        return input.Equals(reversed, StringComparison.InvariantCultureIgnoreCase);
    }

    public static bool IsPalindromLoop(string input)
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

    public static unsafe bool IsPalindromSpan(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }
        
        var bytes = input.AsSpan();
        var len = bytes.Length;
        var i = 0;
        var j = len - 1;

        fixed (char* bp = bytes)
        {
            while(i < j)
            {
                var l = char.ToLowerInvariant(bp[i]);
                var r = char.ToLowerInvariant(bp[j]);
                if ((l ^ r) != 0)
                {
                    return false;
                }

                i++;
                j--;
            }
        }

        return true;
    }
}