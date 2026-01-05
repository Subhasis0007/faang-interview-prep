# Time Based Key-Value Store

**Pattern:** HashMap key -> list of (timestamp,value) + binary search

## Question (in my own words)
Implement TimeMap supporting Set(key,value,timestamp) and Get(key,timestamp): return value set for key at the largest timestamp <= given timestamp.

## Best approach
Store for each key a list of (timestamp,value) in increasing time order (as per problem). For Get, binary search the list for rightmost timestamp <= query.

## Complexity
- Time: Set O(1) amortized, Get O(log n)
- Space: O(total entries)

> **Note:** LeetCode expects class `TimeMap` with methods `Set` and `Get`.

## C# Solution (LeetCode signature)
See `Solution.cs`.
