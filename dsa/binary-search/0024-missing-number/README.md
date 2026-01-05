# Missing Number

**Pattern:** XOR / math

## Question (in my own words)
Given an array containing n distinct numbers in range [0,n], return the one missing number.

## Best approach
XOR all indices 0..n and all array values. Pairs cancel, leaving missing value. (Also possible with sum formula.)

## Complexity
- Time: O(n)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
