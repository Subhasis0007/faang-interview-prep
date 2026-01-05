# LRU Cache

**Pattern:** HashMap + Doubly linked list

## Question (in my own words)
Design an LRU cache supporting Get and Put in O(1).

## Best approach
Use Dictionary key->LinkedListNode for O(1) lookup, and a LinkedList storing most-recent at front. On Get/Put, move node to front. On capacity overflow, remove from back (least-recent).

## Complexity
- Time: O(1) per op
- Space: O(capacity)

> **Note:** LeetCode expects a class `LRUCache` with constructor and `Get/Put` methods.

## C# Solution (LeetCode signature)
See `Solution.cs`.
