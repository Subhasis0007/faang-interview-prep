# Binary Search

**Pattern:** Classic binary search

## Question (in my own words)
Given a sorted array nums and a target, return its index if found; otherwise return -1.

## Best approach
Use two pointers l and r. While l<=r, compute mid, compare nums[mid] to target, and narrow the search space accordingly.

## Complexity
- Time: O(log n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
