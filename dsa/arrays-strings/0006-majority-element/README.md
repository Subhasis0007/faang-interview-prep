# Majority Element

**Pattern:** Boyer-Moore voting

## Question (in my own words)
Find element appearing more than n/2 times.

## Best approach
Boyer–Moore Voting: keep a candidate and counter; increment if same, decrement otherwise; when counter hits 0, change candidate.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution
See `Solution.cs`.
