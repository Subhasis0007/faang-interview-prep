public class Solution
{
    public void SortColors(int[] nums)
    {
        int low = 0, mid = 0, high = nums.Length - 1;

        while (mid <= high)
        {
            if (nums[mid] == 0)
            {
                Swap(nums, low, mid);
                low++; mid++;
            }
            else if (nums[mid] == 2)
            {
                Swap(nums, mid, high);
                high--;
            }
            else
            {
                mid++;
            }
        }
    }

    private void Swap(int[] a, int i, int j)
    {
        int tmp = a[i];
        a[i] = a[j];
        a[j] = tmp;
    }
}
