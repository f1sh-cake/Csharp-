namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用 while 求 1 到 100 的和，和 Day 3 的 for 写法对照一下，体会两种循环的差别
            int i = 1;
            int sum = 0;

            while(i<=100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
