# Search a 2D Matrix

**Pattern:** Binary search on flattened matrix

## Question (in my own words)
Matrix rows are sorted and each row's first element is greater than previous row's last. Determine if target exists.

## Best approach
Treat matrix as a sorted 1D array of length m*n. Binary search index mid, map to matrix[mid/n][mid%n].

## Complexity
- Time: O(log(m*n))
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
