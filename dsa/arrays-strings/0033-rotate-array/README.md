# Rotate Array

**Pattern:** Array reversal

## Question (in my own words)
Rotate an array to the right by k steps in-place.

## Best approach
Use reverse trick: k%=n; reverse whole array, reverse first k, reverse remaining n-k. In-place and O(n).

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
