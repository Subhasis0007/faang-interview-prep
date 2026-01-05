# Encode and Decode Strings

**Pattern:** Length-prefixed encoding

## Question (in my own words)
Design an algorithm to encode a list of strings to a single string and decode it back.

## Best approach
Use length-prefix framing: for each string add "<len>#<string>". During decode, parse length until #, then read that many characters. Works even if strings contain #.

## Complexity
- Time: Encode/Decode O(total chars)
- Space: O(total chars)

## C# Solution (LeetCode signature)
See `Solution.cs`.
