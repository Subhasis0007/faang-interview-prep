# First Missing Positive

**Pattern:** Cyclic placement / index hashing

## Question (in my own words)
Given an unsorted integer array, find the smallest missing positive integer in O(n) time and O(1) extra space.

## Best approach
Place each value x (1..n) at index x-1 by swapping until every valid value is in its correct position. Then scan for first index i where nums[i] != i+1.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
