# Minimum Window Substring

**Pattern:** Sliding window with counts

## Question (in my own words)
Return the minimum window substring of s that contains all characters of t (including duplicates). If none, return empty.

## Best approach
Use two pointers. Maintain required counts of t, and current window counts. Expand right until window covers all required chars; then shrink left to minimize while still valid. Track best window.

## Complexity
- Time: O(|s| + |t|)
- Space: O(alphabet)

## C# Solution (LeetCode signature)
See `Solution.cs`.
