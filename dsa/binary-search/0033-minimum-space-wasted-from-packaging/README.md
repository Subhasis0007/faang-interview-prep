# Minimum Space Wasted From Packaging

**Pattern:** Sort + prefix sums + per supplier binary search

## Question (in my own words)
Given package sizes and box sizes per supplier, choose one supplier to minimize wasted space. Waste = sum(boxUsed - package). Return min waste mod 1e9+7, or -1.

## Best approach
Sort packages and build prefix sums. For each supplier, sort their boxes. If largest box < largest package, skip supplier. Greedily assign smallest possible box size to ranges of packages using upper bound on packages. Compute waste for each range using prefix sums. Take min across suppliers.

## Complexity
- Time: O((p + totalBoxes) log p)
- Space: O(p)


## C# Solution (LeetCode signature)
See `Solution.cs`.
