# Split Array Largest Sum

**Pattern:** Binary search on answer (max subarray sum)

## Question (in my own words)
Split nums into m non-empty continuous subarrays. Minimize the largest subarray sum and return it.

## Best approach
Binary search answer X between max(nums) and sum(nums). Feasibility: greedily form subarrays with sum<=X; count how many parts needed. If parts<=m, X works (try smaller), else increase.

## Complexity
- Time: O(n log(sum))
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
