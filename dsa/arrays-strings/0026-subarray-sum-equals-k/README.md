# Subarray Sum Equals K

**Pattern:** Prefix sum + hash map

## Question (in my own words)
Count the total number of continuous subarrays whose sum equals k.

## Best approach
Let prefix sum be ps. For each ps, number of earlier prefixes with value ps-k contributes to count. Maintain dictionary of prefix sums -> frequency.

## Complexity
- Time: O(n)
- Space: O(n)

## C# Solution (LeetCode signature)
See `Solution.cs`.
