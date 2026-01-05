using System.Collections.Generic;

public class Solution
{
    public int PathSum(TreeNode root, int targetSum)
    {
        var map = new Dictionary<long, int>();
        map[0] = 1;
        return Dfs(root, 0, targetSum, map);
    }

    private int Dfs(TreeNode node, long prefix, int target, Dictionary<long, int> map)
    {
        if (node == null) return 0;

        prefix += node.val;
        int count = 0;
        long need = prefix - target;
        if (map.TryGetValue(need, out int f)) count += f;

        map[prefix] = map.TryGetValue(prefix, out int cur) ? cur + 1 : 1;
        count += Dfs(node.left, prefix, target, map);
        count += Dfs(node.right, prefix, target, map);

        // backtrack
        map[prefix]--;
        if (map[prefix] == 0) map.Remove(prefix);

        return count;
    }
}
