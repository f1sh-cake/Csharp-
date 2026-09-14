namespace _2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //分别求 1 到 100 中所有偶数的和、所有奇数的和，最后都输出。
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum += i;
                }
                else
                {
                    evenSum += i;
                }
            }
            Console.WriteLine($"evensum is {evenSum}");
            Console.WriteLine($"oddsum is {oddSum}");
        }
    }
}
