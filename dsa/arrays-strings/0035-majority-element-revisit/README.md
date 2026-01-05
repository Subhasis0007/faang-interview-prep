# Majority Element (Revisit)

**Pattern:** Boyer–Moore Voting

## Question (in my own words)
Find the element that appears more than n/2 times in the array (guaranteed to exist).

## Best approach
Boyer–Moore: maintain a candidate and a counter. Same value increments, different decrements; when counter reaches 0, pick new candidate. Final candidate is majority.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
