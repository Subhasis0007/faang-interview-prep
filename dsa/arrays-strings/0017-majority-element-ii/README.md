# Majority Element II

**Pattern:** Boyer–Moore voting (two candidates)

## Question (in my own words)
Return all elements that appear more than ⌊n/3⌋ times in an integer array.

## Best approach
There can be at most 2 such elements. Use Boyer–Moore extension to find up to two candidates, then do a second pass to verify actual counts.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
