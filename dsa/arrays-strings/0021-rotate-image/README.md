# Rotate Image

**Pattern:** Matrix in-place (transpose + reverse)

## Question (in my own words)
Rotate an n x n matrix by 90 degrees clockwise in-place.

## Best approach
Transpose the matrix (swap across diagonal), then reverse each row. Both operations are in-place.

## Complexity
- Time: O(n^2)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
