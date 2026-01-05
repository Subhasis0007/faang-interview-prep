# Arranging Coins

**Pattern:** Binary search on answer

## Question (in my own words)
You have n coins and build a staircase with k full rows where row i has i coins. Return the number of full rows.

## Best approach
Binary search k in [0,n]. Check if k*(k+1)/2 <= n using long. Find max k satisfying predicate.

## Complexity
- Time: O(log n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
