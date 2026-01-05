# Group Anagrams

**Pattern:** Hashing / canonical form

## Question (in my own words)
Group strings that are anagrams of each other and return the groups.

## Best approach
Use a dictionary keyed by a canonical representation. Safest: sort characters of each string to form the key, then append to that group.

## Complexity
- Time: O(n * k log k) where k is avg length
- Space: O(n*k)

## C# Solution (LeetCode signature)
See `Solution.cs`.
