public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int first = int.MaxValue;
        int second = int.MaxValue;

        foreach (var x in nums)
        {
            if (x <= first) first = x;
            else if (x <= second) second = x;
            else return true;
        }

        return false;
    }
}
