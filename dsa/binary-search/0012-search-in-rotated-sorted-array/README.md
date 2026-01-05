# Search in Rotated Sorted Array

**Pattern:** Binary search with sorted half detection

## Question (in my own words)
Given a rotated sorted array with distinct values, return index of target or -1.

## Best approach
Binary search. At each mid, determine which half [l..mid] or [mid..r] is sorted. Decide if target lies in sorted half; otherwise search the other half.

## Complexity
- Time: O(log n)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
