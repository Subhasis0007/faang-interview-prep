# Container With Most Water

**Pattern:** Two pointers

## Question (in my own words)
Given heights, find max water container area between two lines.

## Best approach
Use two pointers at ends. Area is min(height[l],height[r])*(r-l). Move the pointer with smaller height inward because it limits area.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
