# Two Sum

**Pattern:** HashMap

## Question (in my own words)
Return indices of two numbers that add up to target.

## Best approach
Scan once while storing (value → index) in a dictionary. For each x, check if target-x already exists.

## Complexity
- Time: O(n)
- Space: O(n)

## C# Solution
See `Solution.cs`.
