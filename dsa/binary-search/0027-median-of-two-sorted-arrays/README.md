# Median of Two Sorted Arrays

**Pattern:** Binary search on partition

## Question (in my own words)
Return the median of two sorted arrays in O(log(min(m,n))).

## Best approach
Binary search the partition index i in the smaller array so that left parts have (m+n+1)/2 elements. Ensure maxLeft <= minRight across arrays. Compute median from boundary values.

## Complexity
- Time: O(log(min(m,n)))
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
