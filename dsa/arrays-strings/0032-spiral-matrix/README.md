# Spiral Matrix

**Pattern:** Layered traversal

## Question (in my own words)
Return all elements of a matrix in spiral order.

## Best approach
Maintain boundaries: top, bottom, left, right. Traverse top row, right column, bottom row (if any), left column (if any), then shrink boundaries and repeat.

## Complexity
- Time: O(m*n)
- Space: O(1) extra (excluding output)

## C# Solution (LeetCode signature)
See `Solution.cs`.
