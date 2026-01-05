# Set Matrix Zeroes

**Pattern:** In-place markers (first row/col)

## Question (in my own words)
If an element is 0, set its entire row and column to 0 in-place.

## Best approach
Use first row and first column as marker storage. Track if first row/col originally had zeros. Mark zeros, then apply markers, then zero first row/col if needed.

## Complexity
- Time: O(m*n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
