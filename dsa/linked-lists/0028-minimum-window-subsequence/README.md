# Minimum Window Subsequence

**Pattern:** DP on strings (subsequence window)

## Question (in my own words)
Given strings s1 and s2, return the minimum-length substring of s1 such that s2 is a subsequence of that substring. If none, return empty.

## Best approach
DP where dp[j] is the start index in s1 of a window ending at current i that matches s2[0..j]. Initialize dp[0] when chars match. Update backwards for each i. When dp[m-1] != -1, we found a valid window ending at i; keep the shortest.

## Complexity
- Time: O(n*m)
- Space: O(m)

> **Note:** This is a string DP problem (LeetCode 727). It appears under Linked Lists in your guide, but solution is DP.

## C# Solution (LeetCode signature)
See `Solution.cs`.
