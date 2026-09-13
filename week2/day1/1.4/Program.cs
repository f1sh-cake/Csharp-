namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入两个整数，用 if 输出较大的那个。
            Console.Write("enter first int:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter second int:");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 >= num2)
                Console.WriteLine($"{num1} is bigger");
            else
                Console.WriteLine($"{num2} is bigger");
        }
    }
}
