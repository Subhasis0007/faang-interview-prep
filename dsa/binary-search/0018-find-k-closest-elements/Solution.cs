using System.Collections.Generic;

public class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        int n = arr.Length;
        int l = 0, r = n - k;

        while (l < r)
        {
            int mid = l + (r - l) / 2;
            // if x is closer to arr[mid+k] than arr[mid], shift window right
            if (x - arr[mid] > arr[mid + k] - x)
                l = mid + 1;
            else
                r = mid;
        }

        var res = new List<int>(k);
        for (int i = l; i < l + k; i++) res.Add(arr[i]);
        return res;
    }
}
