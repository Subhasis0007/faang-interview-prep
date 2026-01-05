# Best Time to Buy and Sell Stock

**Pattern:** Single pass min-so-far

## Question (in my own words)
Max profit from one buy and one sell.

## Best approach
Track minimum price seen so far; update best profit with price - minPrice each day.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution
See `Solution.cs`.
