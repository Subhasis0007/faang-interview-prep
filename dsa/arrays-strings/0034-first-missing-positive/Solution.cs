public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            while (nums[i] >= 1 && nums[i] <= n)
            {
                int correct = nums[i] - 1;
                if (nums[correct] == nums[i]) break;

                int tmp = nums[i];
                nums[i] = nums[correct];
                nums[correct] = tmp;
            }
        }

        for (int i = 0; i < n; i++)
            if (nums[i] != i + 1) return i + 1;

        return n + 1;
    }
}
