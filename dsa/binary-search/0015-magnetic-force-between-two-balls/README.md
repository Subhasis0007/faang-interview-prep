# Magnetic Force Between Two Balls

**Pattern:** Binary search on answer (minimum distance)

## Question (in my own words)
Place m balls in positions to maximize the minimum pairwise distance. Return that maximum minimum distance.

## Best approach
Sort positions. Binary search distance d. Feasibility: greedily place first ball at first position, then place next at earliest position >= last+d. If can place m balls, d is feasible.

## Complexity
- Time: O(n log range)
- Space: O(1) extra


## C# Solution (LeetCode signature)
See `Solution.cs`.
