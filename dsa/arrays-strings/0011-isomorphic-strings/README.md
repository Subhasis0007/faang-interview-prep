# Isomorphic Strings

**Pattern:** Hash maps / bijection

## Question (in my own words)
Given two strings s and t, determine if they are isomorphic: characters in s can be replaced to get t with a one-to-one mapping (no two chars map to same char).

## Best approach
Track mapping both ways. For each position i, ensure s[i] maps to t[i] consistently and t[i] maps back to s[i]. Use two int arrays of size 256 for O(1) lookups.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
