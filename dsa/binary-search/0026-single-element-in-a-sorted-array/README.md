# Single Element in a Sorted Array

**Pattern:** Binary search using pair index property

## Question (in my own words)
In a sorted array where every element appears twice except one element which appears once, find that single element in O(log n).

## Best approach
Binary search on indices. Pairs start at even index before the single element. Ensure mid is even; if nums[mid]==nums[mid+1], single is to the right; else to the left (including mid).

## Complexity
- Time: O(log n)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
