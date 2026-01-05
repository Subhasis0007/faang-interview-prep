# Minimum Skips to Arrive at Meeting On Time

**Pattern:** DP (min total distance-time with skips) + rounding

## Question (in my own words)
You travel along roads with distances dist[i] at constant speed. After each road except last, if you do not skip, you must wait until the next integer hour. Find min skips so total time <= hoursBefore.

## Best approach
DP where dp[j] is minimal "time" measured in distance-units (speed * hours) after processing i roads with j skips. Transition: take road i, then either round up to next multiple of speed (no skip, for i < n-1) or keep exact (skip). Use large INF. Answer is min j such that dp[j] <= hoursBefore*speed.

## Complexity
- Time: O(n^2)
- Space: O(n)


## C# Solution (LeetCode signature)
See `Solution.cs`.
