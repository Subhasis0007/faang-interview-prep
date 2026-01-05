# Merge Sorted Array

**Pattern:** Three pointers from end

## Question (in my own words)
Merge nums2 into nums1 in-place; nums1 has extra space at end.

## Best approach
Fill nums1 from the end using three pointers (i=m-1, j=n-1, k=m+n-1). Place the larger of nums1[i] and nums2[j] into nums1[k].

## Complexity
- Time: O(m+n)
- Space: O(1)

## C# Solution
See `Solution.cs`.
