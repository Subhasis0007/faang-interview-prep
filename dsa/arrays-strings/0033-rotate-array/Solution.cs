public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        if (n == 0) return;
        k %= n;
        if (k == 0) return;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    private void Reverse(int[] a, int l, int r)
    {
        while (l < r)
        {
            int tmp = a[l];
            a[l] = a[r];
            a[r] = tmp;
            l++; r--;
        }
    }
}
