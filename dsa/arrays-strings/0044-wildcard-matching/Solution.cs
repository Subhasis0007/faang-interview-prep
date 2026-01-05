public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int i = 0, j = 0;
        int star = -1;
        int match = 0;

        while (i < s.Length)
        {
            if (j < p.Length && (p[j] == '?' || p[j] == s[i]))
            {
                i++; j++;
            }
            else if (j < p.Length && p[j] == '*')
            {
                star = j;
                match = i;
                j++;
            }
            else if (star != -1)
            {
                j = star + 1;
                match++;
                i = match;
            }
            else
            {
                return false;
            }
        }

        // consume remaining '*' in pattern
        while (j < p.Length && p[j] == '*') j++;

        return j == p.Length;
    }
}
