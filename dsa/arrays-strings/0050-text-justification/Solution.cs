using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var res = new List<string>();
        int i = 0;

        while (i < words.Length)
        {
            int lineLen = words[i].Length;
            int j = i + 1;

            while (j < words.Length && lineLen + 1 + words[j].Length <= maxWidth)
            {
                lineLen += 1 + words[j].Length;
                j++;
            }

            int wordCount = j - i;
            bool isLastLine = j == words.Length;

            if (wordCount == 1 || isLastLine)
            {
                // left-justify
                var sb = new StringBuilder();
                sb.Append(words[i]);
                for (int k = i + 1; k < j; k++)
                {
                    sb.Append(' ');
                    sb.Append(words[k]);
                }
                // pad to maxWidth
                int remaining = maxWidth - sb.Length;
                if (remaining > 0) sb.Append(' ', remaining);
                res.Add(sb.ToString());
            }
            else
            {
                // full-justify
                int totalWordsLen = 0;
                for (int k = i; k < j; k++) totalWordsLen += words[k].Length;

                int totalSpaces = maxWidth - totalWordsLen;
                int gaps = wordCount - 1;
                int baseSpaces = totalSpaces / gaps;
                int extra = totalSpaces % gaps;

                var sb = new StringBuilder();
                for (int k = i; k < j; k++)
                {
                    sb.Append(words[k]);
                    if (k == j - 1) break;

                    int spaces = baseSpaces + (extra > 0 ? 1 : 0);
                    if (extra > 0) extra--;
                    sb.Append(' ', spaces);
                }
                res.Add(sb.ToString());
            }

            i = j;
        }

        return res;
    }
}
