# Longest Common Prefix

**Pattern:** Horizontal scan

## Question (in my own words)
Find longest common prefix among array of strings.

## Best approach
Start with prefix = first string. For each next string, shrink prefix until it matches the start of that string.

## Complexity
- Time: O(total chars)
- Space: O(1)

## C# Solution
See `Solution.cs`.
