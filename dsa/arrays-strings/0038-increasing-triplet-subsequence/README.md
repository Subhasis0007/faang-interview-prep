# Increasing Triplet Subsequence

**Pattern:** Greedy

## Question (in my own words)
Return true if there exists an increasing subsequence of length 3.

## Best approach
Keep two best candidates: first and second. For each x: if x<=first, set first=x; else if x<=second, set second=x; else we found x>second>first => triplet exists.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
