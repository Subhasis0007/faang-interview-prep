# Design Skiplist

**Pattern:** Probabilistic layered linked list

## Question (in my own words)
Design a Skiplist with operations Search, Add, Erase (average O(log n)).

## Best approach
Maintain multiple forward pointers per node at random levels. Search proceeds top-down. Insert keeps update[] predecessors per level, then splices in new node. Erase uses update[] to bypass node levels. Use random level generation with probability 0.5.

## Complexity
- Time: Average O(log n) per op
- Space: O(n)

> **Note:** LeetCode expects class `Skiplist` with methods `bool Search(int)`, `void Add(int)`, `bool Erase(int)`.

## C# Solution (LeetCode signature)
See `Solution.cs`.
