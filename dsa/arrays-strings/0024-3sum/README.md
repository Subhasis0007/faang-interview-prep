# 3Sum

**Pattern:** Sorting + two pointers

## Question (in my own words)
Return all unique triplets [a,b,c] such that a+b+c=0.

## Best approach
Sort. Fix i, then use two pointers l=i+1 and r=n-1 to find pairs summing to -nums[i]. Skip duplicates for i, l, r to ensure uniqueness.

## Complexity
- Time: O(n^2)
- Space: O(1) extra (excluding output)

## C# Solution (LeetCode signature)
See `Solution.cs`.
