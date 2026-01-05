# Longest Consecutive Sequence

**Pattern:** HashSet

## Question (in my own words)
Given an unsorted array, return the length of the longest consecutive elements sequence. Must be O(n).

## Best approach
Put all numbers in a HashSet. For each number that is a sequence start (num-1 not in set), walk forward num+1, num+2... counting length. Track maximum.

## Complexity
- Time: O(n) expected
- Space: O(n)

## C# Solution (LeetCode signature)
See `Solution.cs`.
