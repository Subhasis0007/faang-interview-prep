# Text Justification

**Pattern:** Greedy line packing + spacing

## Question (in my own words)
Given words and maxWidth, format text fully justified: each line has exactly maxWidth chars, spaces distributed as evenly as possible. Last line is left-justified.

## Best approach
Greedily take as many words as fit in a line. If last line or line has 1 word, left-justify: single spaces between words and pad end. Otherwise distribute extra spaces: baseSpaces = totalSpaces/(gaps), extra = totalSpaces%(gaps). The left gaps get one more space.

## Complexity
- Time: O(total characters)
- Space: O(maxWidth) per line

## C# Solution (LeetCode signature)
See `Solution.cs`.
