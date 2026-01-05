# Find the Duplicate Number

**Pattern:** Floyd cycle detection on array

## Question (in my own words)
Given an array nums containing n+1 integers where each integer is in [1,n], there is only one repeated number. Find the duplicate without modifying array and using O(1) extra space.

## Best approach
Treat nums as a linked list where next(i)=nums[i]. Duplicate creates a cycle. Use Floyd’s algorithm to find meeting point, then reset one pointer to start to find cycle entry (the duplicate).

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
