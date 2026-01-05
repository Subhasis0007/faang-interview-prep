public class Solution
{
    public int MaxArea(int[] height)
    {
        int l = 0, r = height.Length - 1;
        int best = 0;

        while (l < r)
        {
            int h = height[l] < height[r] ? height[l] : height[r];
            int area = h * (r - l);
            if (area > best) best = area;

            if (height[l] < height[r]) l++;
            else r--;
        }

        return best;
    }
}
