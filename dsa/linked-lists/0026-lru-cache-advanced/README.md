# LRU Cache (Advanced Implementation)

**Pattern:** HashMap + custom doubly linked list

## Question (in my own words)
Design an LRU cache with O(1) Get/Put. (Advanced: implement your own doubly linked list nodes.)

## Best approach
Maintain dictionary key->node for O(1) access. Keep a custom doubly linked list with sentinel head/tail: head.next=MRU, tail.prev=LRU. On Get/Put, move node to front. On overflow, remove tail.prev.

## Complexity
- Time: O(1) per operation
- Space: O(capacity)

> **Note:** LeetCode expects class `LRUCache(int capacity)`, `int Get(int key)`, `void Put(int key, int value)`.

## C# Solution (LeetCode signature)
See `Solution.cs`.
