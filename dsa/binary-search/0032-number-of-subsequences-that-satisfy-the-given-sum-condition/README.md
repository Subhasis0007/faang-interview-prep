# Number of Subsequences That Satisfy the Given Sum Condition

**Pattern:** Sort + two pointers + powers of 2

## Question (in my own words)
Count non-empty subsequences where min+max <= target. Return count modulo 1e9+7.

## Best approach
Sort. Use two pointers l,r. If nums[l]+nums[r] <= target then all subsets of elements between l and r with nums[l] as min are valid: add 2^(r-l). Move l++. Else r--. Precompute powers of 2.

## Complexity
- Time: O(n log n)
- Space: O(n)


## C# Solution (LeetCode signature)
See `Solution.cs`.
