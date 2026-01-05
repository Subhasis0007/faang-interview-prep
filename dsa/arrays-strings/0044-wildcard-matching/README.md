# Wildcard Matching

**Pattern:** Greedy two pointers with backtracking

## Question (in my own words)
Wildcard match where '?' matches any single char and '*' matches any sequence (including empty). Return if pattern matches entire string.

## Best approach
Greedy scan with pointers i (s) and j (p). When chars match or p[j]=='?', advance both. When p[j]=='*', record star position and match index, advance j. On mismatch, if we had a previous star, backtrack: set j=star+1 and increase match index (i=++match). Else fail. This is O(m+n) typical and O(1) space.

## Complexity
- Time: O(m+n) average (worst-case O(m*n) but accepted)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
