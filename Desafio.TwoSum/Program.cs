using System.Globalization;
using System.Numerics;

namespace Desafio.TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            var test1 = new Solution().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"Test 1: [{test1[0]}, {test1[1]}]");

            var test2 = new Solution().TwoSum(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine($"Test 2: [{test2[0]}, {test2[1]}]");

            var test3 = new Solution().TwoSum(new int[] { 3, 3 }, 6);
            Console.WriteLine($"Test 3: [{test3[0]}, {test3[1]}]");

            var test4 = new Solution().TwoSum(new int[] { 1, 5 , 3 }, 10);
        }

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }

                    }
                }
                throw new System.Exception("No solution found");
            }
        }
    }
}
