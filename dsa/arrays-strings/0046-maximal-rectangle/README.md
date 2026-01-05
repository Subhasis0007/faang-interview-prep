# Maximal Rectangle

**Pattern:** Histogram per row + monotonic stack

## Question (in my own words)
Given a binary matrix of '0' and '1', return the area of the largest rectangle containing only '1's.

## Best approach
Treat each row as base of a histogram: heights[j] increases if matrix[i][j]=='1' else resets to 0. For each row, compute largest rectangle in histogram (LC84) using a stack. Take max over rows.

## Complexity
- Time: O(rows*cols)
- Space: O(cols)

## C# Solution (LeetCode signature)
See `Solution.cs`.
