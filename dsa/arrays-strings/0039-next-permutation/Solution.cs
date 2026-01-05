public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int i = n - 2;

        while (i >= 0 && nums[i] >= nums[i + 1]) i--;

        if (i >= 0)
        {
            int j = n - 1;
            while (nums[j] <= nums[i]) j--;
            Swap(nums, i, j);
        }

        Reverse(nums, i + 1, n - 1);
    }

    private void Swap(int[] a, int i, int j)
    {
        int tmp = a[i];
        a[i] = a[j];
        a[j] = tmp;
    }

    private void Reverse(int[] a, int l, int r)
    {
        while (l < r)
        {
            Swap(a, l, r);
            l++; r--;
        }
    }
}
