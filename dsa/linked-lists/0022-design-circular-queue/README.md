# Design Circular Queue

**Pattern:** Fixed-size array + head + count

## Question (in my own words)
Implement a circular queue with operations enQueue, deQueue, Front, Rear, IsEmpty, IsFull.

## Best approach
Use int[] data, head index, count. Rear index = (head + count - 1) % k. enQueue writes at (head+count)%k. deQueue advances head.

## Complexity
- Time: O(1) per op
- Space: O(k)

> **Note:** LeetCode expects class `MyCircularQueue`.

## C# Solution (LeetCode signature)
See `Solution.cs`.
