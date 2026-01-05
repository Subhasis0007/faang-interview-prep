# Valid Triangle Number

**Pattern:** Sorting + two pointers

## Question (in my own words)
Given array nums, return the number of triplets that can form a triangle. For sides a<=b<=c, need a+b>c.

## Best approach
Sort. Fix the largest side c at index k, then use two pointers i=0, j=k-1: if nums[i]+nums[j]>nums[k], then all i..j-1 with j work, add (j-i), j--; else i++. This counts in O(n^2).

## Complexity
- Time: O(n^2)
- Space: O(1) extra (ignoring sort)

## C# Solution (LeetCode signature)
See `Solution.cs`.
