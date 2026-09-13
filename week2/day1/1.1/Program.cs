namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个整数，输出它是正数、负数还是零。
            Console.Write("enter an integer:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("is positive");
            }
            else if (num == 0)
            {
                Console.WriteLine("is zero");
            }
            else
            {
                Console.WriteLine("is negative");
            }
        }
    }
}
