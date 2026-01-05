# Sort Colors

**Pattern:** Dutch National Flag (3-way partition)

## Question (in my own words)
Sort an array containing 0s, 1s, and 2s in-place.

## Best approach
Maintain three regions with pointers: [0..low-1]=0, [low..mid-1]=1, [high+1..end]=2. Scan mid: swap 0 to low, swap 2 to high, advance appropriately.

## Complexity
- Time: O(n)
- Space: O(1)

## C# Solution (LeetCode signature)
See `Solution.cs`.
