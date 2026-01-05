# Maximum Product Subarray

**Pattern:** DP (track max/min ending here)

## Question (in my own words)
Find the contiguous subarray with the largest product.

## Best approach
Because negatives flip sign, track both maxProd and minProd ending at current index. Update using current value, current*maxProd, current*minProd.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
