namespace _6._1
{
    internal class Program
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                for(int i  = 0; i < nums.Length-1; i++)
                {
                    for (int j = i+1;j < nums.Length; j++)
                    {
                        if(nums[i]+nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
                return new int[0];
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            
        }
    }
}
