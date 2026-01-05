using System;
using System.Collections.Generic;
using System.Text;

public class Codec
{
    // Encodes a list of strings to a single string.
    public string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();
        foreach (var s in strs)
        {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public IList<string> Decode(string s)
    {
        var res = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#') j++;

            int len = int.Parse(s.Substring(i, j - i));
            j++; // move past '#'

            res.Add(s.Substring(j, len));
            i = j + len;
        }

        return res;
    }
}
