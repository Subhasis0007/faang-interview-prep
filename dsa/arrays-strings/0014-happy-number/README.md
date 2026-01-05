# Happy Number

**Pattern:** Cycle detection (Floyd)

## Question (in my own words)
A number is happy if repeatedly replacing it by the sum of squares of its digits eventually reaches 1. Return true if n is happy.

## Best approach
The process eventually enters a cycle. Use Floyd’s cycle detection: slow moves 1 step, fast moves 2 steps. If fast reaches 1 -> happy; if slow==fast -> cycle -> not happy.

## Complexity
- Time: O(k) (small; digits shrink)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
