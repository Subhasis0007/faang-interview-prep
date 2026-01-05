# Smallest Rectangle Enclosing Black Pixels

**Pattern:** Binary search on boundaries

## Question (in my own words)
Given a binary image and coordinates (x,y) of a black pixel, return the area of the smallest axis-aligned rectangle enclosing all black pixels.

## Best approach
Binary search left/right columns and top/bottom rows using monotonic predicates: whether a row/column contains any black pixel. Find first true boundary on each side. Area = (right-left)*(bottom-top).

## Complexity
- Time: O(m log n + n log m)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
