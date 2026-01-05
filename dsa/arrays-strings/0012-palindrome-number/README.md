# Palindrome Number

**Pattern:** Math / two pointers via reverse-half

## Question (in my own words)
Given an integer x, return true if x is a palindrome (reads same forward and backward). Do it without converting to string.

## Best approach
Negative numbers are not palindromes; numbers ending in 0 are palindromes only if the number is 0. Reverse only half of the digits to avoid overflow. Compare the first half with the reversed second half.

## Complexity
- Time: O(log10 n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
