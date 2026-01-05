# Valid Perfect Square

**Pattern:** Binary search on value space

## Question (in my own words)
Given a positive integer num, return true if it is a perfect square without using built-in sqrt.

## Best approach
Binary search x in [1, num]. Compare x*x with num using long to avoid overflow.

## Complexity
- Time: O(log num)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
