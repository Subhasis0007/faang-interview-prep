# Stream of Characters

**Pattern:** Reversed Trie + rolling buffer

## Question (in my own words)
Design StreamChecker: given words, as characters stream in, query(letter) returns true if any word is a suffix of the stream so far.

## Best approach
Build a trie of reversed words. Maintain a buffer of recent characters up to max word length. For each query, traverse trie from newest to oldest char; if we hit an end node => suffix word matched. Complexity per query is O(maxWordLen).

## Complexity
- Time: Build O(total chars), Query O(maxWordLen)
- Space: O(total chars)

## C# Solution (LeetCode signature)
See `Solution.cs`.
