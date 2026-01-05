# Longest Path With Different Adjacent Characters

**Pattern:** Tree DP (DFS) on parent array

## Question (in my own words)
Given parent[] describing a rooted tree (0 is root) and string s of node labels, return the length of the longest path where adjacent nodes have different characters.

## Best approach
Build adjacency list from parent. DFS returns the longest downward chain starting at node that satisfies constraint. For each child, get chain length; if s[child]!=s[node], it can extend. Keep the top two child chains to potentially form a path through current: 1 + best1 + best2. Track global maximum.

## Complexity
- Time: O(n)
- Space: O(n)

> LeetCode: `int LongestPath(int[] parent, string s)` (LC 2246).

## C# Solution
See `Solution.cs`.
