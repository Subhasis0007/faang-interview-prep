# Design Binary Search Tree

**Pattern:** OOP design + BST operations

## Question (in my own words)
Design a Binary Search Tree with core operations (insert, search, delete, inorder traversal).

## Best approach
Implement a `BinarySearchTree` class with an inner `Node`. Insert/search are standard BST. Delete handles 0/1/2 children (replace with inorder successor). Provide an inorder traversal method to validate ordering.

## Complexity
- Time: Average O(log n) per op (worst O(n) if skewed)
- Space: O(h) recursion stack for recursive operations

> This is a design/low-level design item (not a single LeetCode problem). Implementation below is a clean BST class.

## C# Solution
See `Solution.cs`.
