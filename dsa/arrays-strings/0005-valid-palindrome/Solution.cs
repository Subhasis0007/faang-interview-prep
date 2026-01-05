using System;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            while (i < j && !char.IsLetterOrDigit(s[i])) i++;
            while (i < j && !char.IsLetterOrDigit(s[j])) j--;

            if (i < j)
            {
                char a = char.ToLowerInvariant(s[i]);
                char b = char.ToLowerInvariant(s[j]);
                if (a != b) return false;
                i++; j--;
            }
        }
        return true;
    }
}
