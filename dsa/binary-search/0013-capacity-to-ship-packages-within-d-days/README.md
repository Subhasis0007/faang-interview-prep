# Capacity To Ship Packages Within D Days

**Pattern:** Binary search on answer (capacity)

## Question (in my own words)
Given weights and days, find the minimal ship capacity to ship all packages in order within given days.

## Best approach
Binary search capacity from max(weights) to sum(weights). Feasibility check: simulate loading sequentially; count days needed with this capacity. If daysNeeded <= days, capacity works, try smaller; else increase.

## Complexity
- Time: O(n log(sum))
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
