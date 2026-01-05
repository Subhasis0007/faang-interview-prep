# Find the Duplicate Number

**Pattern:** Floyd cycle detection on array

## Question (in my own words)
Array nums of size n+1 with values in [1,n]. There is one repeated number. Find it without modifying array and with O(1) extra space.

## Best approach
Treat indices as nodes and nums[i] as next pointer. Duplicate creates a cycle. Use Floyd's cycle detection to find intersection, then reset one pointer to start to find cycle entry.

## Complexity
- Time: O(n)
- Space: O(1)


## C# Solution (LeetCode signature)
See `Solution.cs`.
