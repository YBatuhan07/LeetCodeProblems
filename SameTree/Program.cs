namespace SameTree;

internal class Program
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if(p == null && q == null) return true;

        if(p == null || q == null) return false;

        if(p.val != q.val) return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }

    private static void Main(string[] args)
    {

        TreeNode tree1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));

        TreeNode tree2 = new TreeNode(1, new TreeNode(2), new TreeNode(3));

        TreeNode tree3 = new TreeNode(1, new TreeNode(2));

        Console.WriteLine("Answer: true, Result: " + IsSameTree(tree1, tree2)); 
        Console.WriteLine("Answer: false, Result: " + IsSameTree(tree1, tree3));

    }
}