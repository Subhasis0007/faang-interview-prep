# Word Pattern

**Pattern:** Hash maps / bijection

## Question (in my own words)
Given a pattern string and a space-separated string s, check if s follows the same pattern with a one-to-one mapping.

## Best approach
Split s into words. Ensure pattern length equals number of words. Use two dictionaries: char->word and word->char to enforce bijection.

## Complexity
- Time: O(n) words
- Space: O(n)

## C# Solution (LeetCode signature)
See `Solution.cs`.
