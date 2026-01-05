# Guess Number Higher or Lower

**Pattern:** Binary search using provided API

## Question (in my own words)
You guess a number between 1 and n. API guess(num) tells if your guess is higher, lower, or correct. Find the picked number.

## Best approach
Binary search on range [1,n]. Use guess(mid) to move left or right until found.

## Complexity
- Time: O(log n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
