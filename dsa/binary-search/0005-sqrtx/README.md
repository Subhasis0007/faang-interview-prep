# Sqrt(x)

**Pattern:** Binary search for floor sqrt

## Question (in my own words)
Given a non-negative integer x, return the integer part (floor) of sqrt(x).

## Best approach
Binary search mid in [0,x]. Use long for mid*mid. Maintain answer when mid*mid <= x.

## Complexity
- Time: O(log x)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
