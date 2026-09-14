namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //求 1 到 100 的和，最后输出结果。
            int sum = 0;
            for (int i =1;i<=100;i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
