namespace _2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //统计并输出 1 到 100 中能被 3 和 5 同时整除的数，最后输出这样的数一共有几个。
            int count = 0;
            for(int i =1;i<=100;i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    count++;
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine($"一共有{count}");
        }
    }
}
