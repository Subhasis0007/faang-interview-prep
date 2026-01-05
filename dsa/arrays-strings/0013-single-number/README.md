# Single Number

**Pattern:** Bit manipulation (XOR)

## Question (in my own words)
Given a non-empty array where every element appears twice except for one, find the single one.

## Best approach
Use XOR: a^a=0 and a^0=a. XORing all numbers cancels pairs leaving the unique number.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
