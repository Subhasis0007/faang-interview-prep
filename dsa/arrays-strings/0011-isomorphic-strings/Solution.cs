public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        // ASCII-safe; for full Unicode you can use Dictionary<char,char>
        int[] mapST = new int[256];
        int[] mapTS = new int[256];

        for (int i = 0; i < s.Length; i++)
        {
            int a = s[i];
            int b = t[i];

            if (mapST[a] == 0 && mapTS[b] == 0)
            {
                mapST[a] = b;
                mapTS[b] = a;
            }
            else
            {
                if (mapST[a] != b || mapTS[b] != a) return false;
            }
        }
        return true;
    }
}
