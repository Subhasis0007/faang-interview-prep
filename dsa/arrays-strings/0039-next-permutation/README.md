# Next Permutation

**Pattern:** Permutation manipulation

## Question (in my own words)
Rearrange numbers into the next lexicographically greater permutation. If not possible, rearrange as the lowest possible order.

## Best approach
Find first index i from right where nums[i] < nums[i+1]. If found, find j from right where nums[j] > nums[i], swap i and j. Then reverse suffix i+1..end to get minimal suffix.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
