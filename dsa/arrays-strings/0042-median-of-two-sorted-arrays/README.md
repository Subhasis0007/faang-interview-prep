# Median of Two Sorted Arrays

**Pattern:** Binary search on partition

## Question (in my own words)
Given two sorted arrays nums1 and nums2, return the median of the combined sorted array in O(log(min(m,n))).

## Best approach
Binary search the cut position in the smaller array so that left parts of both arrays contain half the elements. Ensure maxLeft <= minRight across the partition. Median is maxLeft (odd) or avg(maxLeft, minRight) (even).

## Complexity
- Time: O(log(min(m,n)))
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
