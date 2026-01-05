# Minimum Days to Make m Bouquets

**Pattern:** Binary search on answer (days)

## Question (in my own words)
Given bloomDay, need to make m bouquets each of k adjacent flowers. Return minimum days, or -1 if impossible.

## Best approach
If m*k > n, impossible. Binary search days between minBloom and maxBloom. Feasibility: scan bloomDay, count consecutive bloomed (<=day). Each time count reaches k, make bouquet and reset. If bouquets>=m, day works.

## Complexity
- Time: O(n log range)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
