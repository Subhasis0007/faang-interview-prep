# Super Egg Drop

**Pattern:** DP on moves (dp[m][k] coverage)

## Question (in my own words)
Given k eggs and n floors, return minimum moves to find critical floor in worst case.

## Best approach
Use optimized DP: dp[e] = max floors that can be tested with e eggs and current moves. Recurrence when adding one move: dp[e] = dp[e] + dp[e-1] + 1. Increase moves until dp[k] >= n.

## Complexity
- Time: O(k * moves) (moves ~ O(log n) to O(sqrt n))
- Space: O(k)


## C# Solution (LeetCode signature)
See `Solution.cs`.
