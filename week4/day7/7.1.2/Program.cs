namespace _7._1._2
{
    internal class Program
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                //负数不是
                if (x < 0) return false;

                //末尾为 0 的非零整数
                if (x%10==0&&x!=0) return false;

                int reverted = 0;

                while(x>reverted)
                {
                    //取x末尾
                    reverted=reverted*10+x%10;
                    //x去掉末尾数
                    x /= 10;
                }

                return reverted == x || reverted / 10 == x;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
