# Search Insert Position

**Pattern:** Lower bound

## Question (in my own words)
Given a sorted array and a target, return the index if found. Otherwise return the index where it would be inserted in order.

## Best approach
Binary search for the first position where nums[pos] >= target (lower bound). Return left at the end.

## Complexity
- Time: O(log n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
