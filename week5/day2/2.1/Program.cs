namespace _2._1
{
    internal class Program
    {
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                //记录不一样的元素个数
                int unique = 1;

                int[] exceptedNums = new int[nums.Length];

                //nums第一个值可以无脑赋给exceptiedNums
                exceptedNums[0] = nums[0];

                int i = 0;

                for (int j = i; j < nums.Length - 1; j++)
                {
                    if (nums[j + 1] != nums[i])
                    { 
                        i = j + 1;
                        exceptedNums[unique] = nums[i];
                        unique++;
                    }
                }

                for(int k = 0;k<exceptedNums.Length;k++)
                {
                    nums[k] = exceptedNums[k];
                }

                return unique;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

