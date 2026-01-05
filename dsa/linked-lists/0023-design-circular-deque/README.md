# Design Circular Deque

**Pattern:** Fixed-size array + head + count

## Question (in my own words)
Implement circular deque supporting insert/delete front/rear and get front/rear in O(1).

## Best approach
Use array, head points to front, count. Front index=head, rear index=(head+count-1)%k. InsertFront: head=(head-1+k)%k then write. InsertLast: write at (head+count)%k. DeleteFront increments head, DeleteLast just decrements count.

## Complexity
- Time: O(1) per op
- Space: O(k)

> **Note:** LeetCode expects class `MyCircularDeque`.

## C# Solution (LeetCode signature)
See `Solution.cs`.
