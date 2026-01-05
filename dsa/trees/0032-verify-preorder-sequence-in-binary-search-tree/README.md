# Verify Preorder Sequence in Binary Search Tree

**Pattern:** Monotonic stack + lower bound

## Question (in my own words)
Given an array preorder, return true if it can represent the preorder traversal of a BST with distinct values.

## Best approach
Use a stack to simulate traversal. Maintain a lower bound `low`. For each value x: if x < low, invalid. While stack not empty and x > stack.peek, pop and update low to popped value (we are moving to right subtree). Push x. If never violates, valid.

## Complexity
- Time: O(n)
- Space: O(n)

> **Note:** This is LeetCode 255 (premium). Signature often `bool VerifyPreorder(int[] preorder)`.

## C# Solution (LeetCode signature)
See `Solution.cs`.
