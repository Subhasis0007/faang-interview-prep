# Insert Delete GetRandom O(1)

**Pattern:** Array + HashMap index

## Question (in my own words)
Implement RandomizedSet supporting Insert, Remove, GetRandom in average O(1).

## Best approach
Store values in a List<int> and positions in Dictionary<int,int>. For Remove, swap element with last in list, update index, then pop last. GetRandom uses Random on list.

## Complexity
- Time: O(1) average per op
- Space: O(n)

> **Note:** LeetCode expects class `RandomizedSet` with methods `Insert`, `Remove`, `GetRandom`.

## C# Solution (LeetCode signature)
See `Solution.cs`.
