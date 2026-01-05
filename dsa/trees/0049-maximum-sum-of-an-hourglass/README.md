# Maximum Sum of an Hourglass

**Pattern:** Brute force scan (fixed pattern)

## Question (in my own words)
Given an integer matrix grid, return the maximum sum of an hourglass (3x3 with middle of second row).

## Best approach
For each top-left (i,j) of a 3x3 window, compute hourglass sum: grid[i][j..j+2] + grid[i+1][j+1] + grid[i+2][j..j+2]. Track maximum.

## Complexity
- Time: O(m*n)
- Space: O(1)

> Note: This is a grid problem (not a tree). Matches LeetCode `int MaxSum(int[][] grid)` (LC 2428).

## C# Solution
See `Solution.cs`.
