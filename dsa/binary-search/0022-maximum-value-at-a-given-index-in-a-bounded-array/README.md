# Maximum Value at a Given Index in a Bounded Array

**Pattern:** Binary search on value + arithmetic series

## Question (in my own words)
Array length n, positive ints, adjacent difference <= 1, sum <= maxSum. Maximize value at index.

## Best approach
Binary search value x at index. Compute minimal possible array sum given peak x: for left side length L and right side length R, the sum decreases by 1 each step until hitting 1. Use arithmetic series formulas. If requiredSum <= maxSum, x is feasible.

## Complexity
- Time: O(log maxSum)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
