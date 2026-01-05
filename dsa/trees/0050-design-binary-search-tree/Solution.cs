using System;
using System.Collections.Generic;

public class BinarySearchTree
{
    public class Node
    {
        public int Val;
        public Node Left;
        public Node Right;
        public Node(int val) { Val = val; }
    }

    public Node Root { get; private set; }

    public void Insert(int val)
    {
        Root = Insert(Root, val);
    }

    private Node Insert(Node node, int val)
    {
        if (node == null) return new Node(val);
        if (val < node.Val) node.Left = Insert(node.Left, val);
        else if (val > node.Val) node.Right = Insert(node.Right, val);
        // if equal, ignore duplicates (policy choice)
        return node;
    }

    public bool Contains(int val)
    {
        var cur = Root;
        while (cur != null)
        {
            if (val == cur.Val) return true;
            cur = val < cur.Val ? cur.Left : cur.Right;
        }
        return false;
    }

    public void Delete(int val)
    {
        Root = Delete(Root, val);
    }

    private Node Delete(Node node, int val)
    {
        if (node == null) return null;

        if (val < node.Val) node.Left = Delete(node.Left, val);
        else if (val > node.Val) node.Right = Delete(node.Right, val);
        else
        {
            // node to delete
            if (node.Left == null) return node.Right;
            if (node.Right == null) return node.Left;

            // two children: replace with inorder successor (min on right)
            var succ = Min(node.Right);
            node.Val = succ.Val;
            node.Right = Delete(node.Right, succ.Val);
        }
        return node;
    }

    private Node Min(Node node)
    {
        while (node.Left != null) node = node.Left;
        return node;
    }

    public IList<int> Inorder()
    {
        var res = new List<int>();
        Inorder(Root, res);
        return res;
    }

    private void Inorder(Node node, List<int> res)
    {
        if (node == null) return;
        Inorder(node.Left, res);
        res.Add(node.Val);
        Inorder(node.Right, res);
    }
}
