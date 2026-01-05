# Trapping Rain Water

**Pattern:** Two pointers (leftMax/rightMax)

## Question (in my own words)
Given an elevation map (array heights), compute how much water can be trapped after raining.

## Best approach
Use two pointers from both ends with leftMax and rightMax. Move the side with smaller current height; water added is leftMax-height[left] or rightMax-height[right]. This works because trapped water at a position is limited by the smaller boundary.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
