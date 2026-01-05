# Insert Interval

**Pattern:** Intervals + merge sweep

## Question (in my own words)
Given non-overlapping intervals sorted by start, insert a new interval and merge if necessary.

## Best approach
Add all intervals ending before newInterval starts. Then merge all overlapping intervals into newInterval. Add merged interval. Finally add the remaining intervals.

## Complexity
- Time: O(n)
- Space: O(n) for output

## C# Solution (LeetCode signature)
See `Solution.cs`.
