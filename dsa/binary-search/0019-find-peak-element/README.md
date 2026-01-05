# Find Peak Element

**Pattern:** Binary search on slope

## Question (in my own words)
Return an index of a peak element (greater than its neighbors). You may assume nums[-1]=nums[n]= -∞.

## Best approach
Binary search mid. If nums[mid] < nums[mid+1], peak lies to the right; else peak lies to the left (including mid). Converges to a peak.

## Complexity
- Time: O(log n)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
