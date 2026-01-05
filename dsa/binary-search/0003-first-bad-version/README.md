# First Bad Version

**Pattern:** Binary search for first true in monotonic predicate

## Question (in my own words)
Versions 1..n, once a version is bad, all later are bad. Find the first bad version using isBadVersion API.

## Best approach
Binary search on [1,n] for the first version where isBadVersion(mid) is true. Use left<right template to converge.

## Complexity
- Time: O(log n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
