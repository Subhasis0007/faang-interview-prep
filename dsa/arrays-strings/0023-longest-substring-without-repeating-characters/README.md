# Longest Substring Without Repeating Characters

**Pattern:** Sliding window

## Question (in my own words)
Return the length of the longest substring without repeating characters.

## Best approach
Maintain a window [left..right]. Store last seen index of each character. If current char was seen inside window, move left to lastSeen+1. Track max length.

## Complexity
- Time: O(n)
- Space: O(min(n, alphabet))

## C# Solution (LeetCode signature)
See `Solution.cs`.
