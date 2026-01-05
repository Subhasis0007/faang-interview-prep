# Swim in Rising Water

**Pattern:** Binary search on time + BFS/DFS reachability

## Question (in my own words)
Given grid elevations, you can move 4-dir. At time t you can enter cells with value <= t. Return minimum t to reach bottom-right.

## Best approach
Binary search t between max(start,end) and max cell. Feasibility: BFS/DFS from (0,0) visiting cells with elevation<=t. If can reach end, try smaller t.

## Complexity
- Time: O(n^2 log(maxVal))
- Space: O(n^2)


## C# Solution (LeetCode signature)
See `Solution.cs`.
