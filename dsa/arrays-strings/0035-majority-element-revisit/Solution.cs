public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (var x in nums)
        {
            if (count == 0)
            {
                candidate = x;
                count = 1;
            }
            else if (x == candidate) count++;
            else count--;
        }

        return candidate;
    }
}
