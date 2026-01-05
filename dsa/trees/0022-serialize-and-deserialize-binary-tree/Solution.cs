using System;
using System.Collections.Generic;
using System.Text;

public class Codec
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        var sb = new StringBuilder();
        SerializeDfs(root, sb);
        return sb.ToString();
    }

    private void SerializeDfs(TreeNode node, StringBuilder sb)
    {
        if (node == null)
        {
            sb.Append("#,");
            return;
        }
        sb.Append(node.val);
        sb.Append(',');
        SerializeDfs(node.left, sb);
        SerializeDfs(node.right, sb);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var tokens = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
        int idx = 0;
        return DeserializeDfs(tokens, ref idx);
    }

    private TreeNode DeserializeDfs(string[] tokens, ref int idx)
    {
        if (idx >= tokens.Length) return null;
        string t = tokens[idx++];
        if (t == "#") return null;

        var node = new TreeNode(int.Parse(t));
        node.left = DeserializeDfs(tokens, ref idx);
        node.right = DeserializeDfs(tokens, ref idx);
        return node;
    }
}
