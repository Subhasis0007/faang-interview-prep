# Remove Duplicates from Sorted Array

**Pattern:** Slow/fast pointers

## Question (in my own words)
In-place remove duplicates in sorted array, return new length.

## Best approach
Maintain write index for unique elements. Scan with read index; when value changes, write it to next position.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution
See `Solution.cs`.
