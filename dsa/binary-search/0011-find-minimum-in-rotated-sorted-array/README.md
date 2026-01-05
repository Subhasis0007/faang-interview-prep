# Find Minimum in Rotated Sorted Array

**Pattern:** Binary search on pivot

## Question (in my own words)
Given a rotated sorted array with distinct values, find the minimum element.

## Best approach
Binary search with l<r. Compare nums[mid] with nums[r]. If nums[mid] > nums[r], min is right of mid; else min is at mid or left side.

## Complexity
- Time: O(log n)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
