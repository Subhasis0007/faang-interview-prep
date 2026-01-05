# Alien Dictionary

**Pattern:** Topological sort (Kahn BFS)

## Question (in my own words)
Given a sorted list of words in an alien language, return a string representing the characters' order. If invalid, return empty.

## Best approach
Build a directed graph between the first differing chars of adjacent words (a->b means a comes before b). Initialize indegrees for all seen chars. Handle invalid case where a longer word comes before its prefix. Then perform Kahn's BFS topological sort to produce an order if all chars processed.

## Complexity
- Time: O(total characters + edges)
- Space: O(chars + edges)

## C# Solution (LeetCode signature)
See `Solution.cs`.
