public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return string.Empty;

        string prefix = strs[0];
        for (int i = 1; i < strs.Length && prefix.Length > 0; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0) return string.Empty;
            }
        }
        return prefix;
    }
}
