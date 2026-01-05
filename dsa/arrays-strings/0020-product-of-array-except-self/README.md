# Product of Array Except Self

**Pattern:** Prefix/Suffix products

## Question (in my own words)
Return an array answer where answer[i] is the product of all nums except nums[i], without division.

## Best approach
Compute prefix products into output. Then traverse from the end with a running suffix product and multiply into output. O(1) extra space besides output.

## Complexity
- Time: O(n)
- Space: O(1) extra

## C# Solution (LeetCode signature)
See `Solution.cs`.
