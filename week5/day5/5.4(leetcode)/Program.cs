namespace _5._4_leetcode_
{
    internal class Program
    {
        public class Solution
        {
            public bool CanJump(int[] nums)
            {
                //记录能到达的最远位置
                int maxReach = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if(i>maxReach) return false;

                    //当前坐标能到达后计算该坐标地最远reach并进行比较更新
                    maxReach = Math.Max(maxReach, i + nums[i]);

                    //如果maxReach已经超过了最大坐标(nums.Length-1),则判对退出
                    if (maxReach >= nums.Length - 1) return true;
                }

                return true;

            }
        }
    }
}
