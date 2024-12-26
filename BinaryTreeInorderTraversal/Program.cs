namespace BinaryTreeInorderTraversal;

public class Program
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

    public static IList<int> InorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while (stack.Count != 0 || root != null)
        {
            if (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            else
            {
                root = stack.Pop();
                result.Add(root.val);
                root = root.right;
            }
        }
        return result;
    }

    private static void Main(string[] args)
    {
        TreeNode tree1 = new TreeNode(1);
        TreeNode tree2 = new TreeNode(1, new TreeNode(2));
        TreeNode tree3 = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));
        TreeNode tree4 = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))), new TreeNode(3, null, new TreeNode(8, null, new TreeNode(9)))
        );
        InorderTraversal(tree1);
        InorderTraversal(tree2);
        InorderTraversal(tree3);
        InorderTraversal(tree4);
    }
}