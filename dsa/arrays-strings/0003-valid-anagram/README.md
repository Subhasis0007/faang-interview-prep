# Valid Anagram

**Pattern:** Frequency count

## Question (in my own words)
Check if two strings are anagrams (same char counts).

## Best approach
Count characters. For lowercase English letters, use int[26] for O(1) space. Increment for s, decrement for t, verify all zeros.

## Complexity
- Time: O(n)
- Space: O(1) / O(k)

## C# Solution
See `Solution.cs`.
