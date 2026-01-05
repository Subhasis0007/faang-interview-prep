using System.Text;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var sb = new StringBuilder();
        while (columnNumber > 0)
        {
            columnNumber--; // make it 0-indexed
            int rem = columnNumber % 26;
            sb.Insert(0, (char)('A' + rem));
            columnNumber /= 26;
        }
        return sb.ToString();
    }
}
