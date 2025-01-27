namespace MaximumDepthOfBinaryTree
{
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

        public int maxDepth = 0;

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftMaxDepth = MaxDepth(root.left);
            int rightMaxDepth = MaxDepth(root.right);

            return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
        }

        private static void Main(string[] args)
        {
            Program program = new Program();

            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3));

            TreeNode root2 = new TreeNode(1,
                new TreeNode(2),
                new TreeNode(3));

            Console.WriteLine("Answer: 2, Result: " + program.MaxDepth(root2));
            Console.WriteLine("Answer: 3, Result: " + program.MaxDepth(root));
        }
    }
}