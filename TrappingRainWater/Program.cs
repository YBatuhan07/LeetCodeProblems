namespace TrappingRainWater
{
    internal class Program
    {
        public static int Trap(int[] height)
        {
            if (height == null || height.Length < 3)
                return 0;

            int n = height.Length;
            int[] leftMax = new int[n];
            int[] rightMax = new int[n];

            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            rightMax[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            int water = 0;
            for (int i = 0; i < n; i++)
            {
                water += Math.Max(0, Math.Min(leftMax[i], rightMax[i]) - height[i]);
            }

            return water;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Answer: 6 , Result: " + Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
            Console.WriteLine("Answer: 9 , Result: " + Trap(new int[] { 4, 2, 0, 3, 2, 5 }));
            Console.WriteLine("Answer: 0 , Result: " + Trap(new int[] { 1, 1, 1, 1, 1 }));
            Console.WriteLine("Answer: 3 , Result: " + Trap(new int[] { 2, 0, 1, 2 }));
            Console.WriteLine("Answer: 7 , Result: " + Trap(new int[] { 3, 0, 2, 0, 4 }));
        
        }
    }
}
