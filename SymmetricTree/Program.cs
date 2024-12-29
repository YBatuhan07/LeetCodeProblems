namespace SymmetricTree
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

        bool Dfs(TreeNode root1, TreeNode root2)
        {
            if (root1 is null && root2 is null)
                return true;

            if (root1?.val != root2?.val)
                return false;

            return Dfs(root1?.left, root2?.right) &&
                   Dfs(root1?.right, root2?.left);
        }

        public bool IsSymmetric(TreeNode root)
        {
            return Dfs(root.left, root.right);

        }

        private static void Main(string[] args)
        {
            var program = new Program();

            var Tree1 = new TreeNode(1,
                new TreeNode(2, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(4), new TreeNode(3))
            );
            Console.WriteLine("Answer = Symmetric,  Result =" + (program.IsSymmetric(Tree1) ? "Symmetric" : "Not Symmetric"));

            var Tree2 = new TreeNode(1,
                new TreeNode(2, null, new TreeNode(3)),
                new TreeNode(2, null, new TreeNode(3))
            );
            Console.WriteLine("Answer = Not Symmetric,  Result =" + (program.IsSymmetric(Tree2) ? "Symmetric" : "Not Symmetric"));

            var Tree3 = new TreeNode(1);
            Console.WriteLine("Answer = Symmetric,  Result =" + (program.IsSymmetric(Tree3) ? "Symmetric" : "Not Symmetric"));

        }
    }
}