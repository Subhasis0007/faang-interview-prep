# Search a 2D Matrix II

**Pattern:** Staircase search (top-right)

## Question (in my own words)
Each row and column is sorted ascending. Determine if target exists.

## Best approach
Start at top-right. If current > target, move left; if current < target, move down. This eliminates a row/column each step.

## Complexity
- Time: O(m+n)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
