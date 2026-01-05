# Koko Eating Bananas

**Pattern:** Binary search on speed (answer space)

## Question (in my own words)
Koko eats bananas at speed k per hour. Given piles and h hours, find minimum k so she finishes in time.

## Best approach
Binary search k from 1..maxPile. For a candidate speed, compute total hours = sum(ceil(pile/k)). If hours <= h, try smaller k; else increase k.

## Complexity
- Time: O(n log maxPile)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
