namespace _1._1
{
    internal class Program
    {
        public class Solution
        {
            public int Reverse(int x)
            {
                long reverted = 0;
                while (x != 0)
                {
                    reverted = reverted * 10 + x % 10;
                    x /= 10;
                }

                if(reverted>int.MaxValue||reverted<int.MinValue)
                {
                    return 0;
                }

                return (int)reverted;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
