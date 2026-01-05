# The Skyline Problem

**Pattern:** Sweep line + multiset (max-heap)

## Question (in my own words)
Given buildings [Li,Ri,Hi], return the skyline key points.

## Best approach
Create events: entering (x, -h) and leaving (x, +h). Sort by x then height. Maintain a multiset of active heights (SortedDictionary height->count). Current max height changes produce key points.

## Complexity
- Time: O(n log n)
- Space: O(n)


## C# Solution (LeetCode signature)
See `Solution.cs`.
