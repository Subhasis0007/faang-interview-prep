# Excel Sheet Column Title

**Pattern:** Base conversion (1-indexed base-26)

## Question (in my own words)
Given an integer columnNumber, return its corresponding Excel column title (1->A, 26->Z, 27->AA).

## Best approach
This is like base-26 but 1-indexed. Decrement columnNumber by 1 each step, take remainder mod 26 to get character, and divide by 26.

## Complexity
- Time: O(log26 n)
- Space: O(log n) for output

## C# Solution (LeetCode signature)
See `Solution.cs`.
