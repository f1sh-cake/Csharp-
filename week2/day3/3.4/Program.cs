namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个整数 n，输出 1 到 n，并求 1 到 n 的和。
            Console.Write("enter an int:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1;  i <= n;i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"sum is {sum}");

        }
    }
}
