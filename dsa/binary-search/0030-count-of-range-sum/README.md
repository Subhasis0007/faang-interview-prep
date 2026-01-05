# Count of Range Sum

**Pattern:** Prefix sums + divide & conquer (merge sort count)

## Question (in my own words)
Count the number of range sums in nums that lie in [lower, upper].

## Best approach
Compute prefix sums. Use merge sort on prefix sums and count for each left half value how many right half prefix sums satisfy lower<=right-left<=upper using two pointers. Then merge halves.

## Complexity
- Time: O(n log n)
- Space: O(n)


## C# Solution (LeetCode signature)
See `Solution.cs`.
