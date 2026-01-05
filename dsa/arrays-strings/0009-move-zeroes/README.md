# Move Zeroes

**Pattern:** Two pointers compaction

## Question (in my own words)
Move all zeros to end while keeping relative order of non-zeros.

## Best approach
Compact non-zero elements to the front (write pointer). Then fill remaining positions with 0.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution
See `Solution.cs`.
