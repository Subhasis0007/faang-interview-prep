# Largest Rectangle in Histogram

**Pattern:** Monotonic increasing stack

## Question (in my own words)
Given heights of histogram bars, return the area of the largest rectangle.

## Best approach
Use stack of indices with increasing heights. When current height is smaller, pop bars and compute area where popped bar is the smallest height: height * (rightIndex - leftIndex - 1). Append sentinel 0 height at end to flush stack.

## Complexity
- Time: O(n)
- Space: O(n)

## C# Solution (LeetCode signature)
See `Solution.cs`.
