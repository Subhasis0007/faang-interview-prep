# Regular Expression Matching

**Pattern:** 2D DP (string DP)

## Question (in my own words)
Implement regex matching with ' . ' and '*'. ' . ' matches any char. '*' matches zero or more of the preceding element. Return if pattern matches entire string.

## Best approach
DP where dp[i][j] means first i chars of s match first j chars of p. Transitions: if p[j-1] is normal or ' . ' then dp[i][j]=dp[i-1][j-1] if chars match. If p[j-1]=='*', then either treat as zero occurrence (dp[i][j-2]) or if preceding char matches s[i-1], consume one char (dp[i-1][j]).

## Complexity
- Time: O(m*n)
- Space: O(m*n)

## C# Solution (LeetCode signature)
See `Solution.cs`.
