namespace _7._1
{
    internal class Program
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                //现将整数x转换成字符串
                string s = x.ToString();

                int i = 0;
                int j = s.Length - 1;
                while (i < j)
                {
                    if (s[i] != s[j]) return false;
                    i++;
                    j--;
                }

                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
