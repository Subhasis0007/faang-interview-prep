# Minimum Interval to Include Each Query

**Pattern:** Sort + min-heap

## Question (in my own words)
Given intervals and queries, for each query return the length of the smallest interval that contains it, or -1.

## Best approach
Sort intervals by start. Sort queries with original indices. Sweep queries increasing: push all intervals with start<=q into a min-heap prioritized by interval length; also store end. Pop heap while top end<q. Then top length is answer or -1.

## Complexity
- Time: O((n+q) log n)
- Space: O(n)

## C# Solution (LeetCode signature)
See `Solution.cs`.
