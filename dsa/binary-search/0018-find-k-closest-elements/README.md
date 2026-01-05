# Find K Closest Elements

**Pattern:** Binary search on window left boundary

## Question (in my own words)
Given a sorted array arr, return the k closest integers to x (in ascending order).

## Best approach
Binary search left boundary l in [0, n-k]. Compare distances x-arr[mid] and arr[mid+k]-x. If left side is farther, shift right. Finally return arr[l..l+k-1].

## Complexity
- Time: O(log(n-k) + k)
- Space: O(k) for output


## C# Solution (LeetCode signature)
See `Solution.cs`.
