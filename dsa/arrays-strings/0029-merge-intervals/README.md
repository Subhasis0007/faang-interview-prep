# Merge Intervals

**Pattern:** Sorting + sweep/merge

## Question (in my own words)
Given intervals, merge all overlapping intervals and return the merged intervals.

## Best approach
Sort by start. Iterate and extend the current merged interval if next overlaps (next.start <= cur.end), otherwise push cur and start new.

## Complexity
- Time: O(n log n)
- Space: O(n) for output

## C# Solution (LeetCode signature)
See `Solution.cs`.
