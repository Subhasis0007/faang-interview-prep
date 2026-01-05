public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int write = 0;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != 0) nums[write++] = nums[i];

        while (write < nums.Length)
            nums[write++] = 0;
    }
}
