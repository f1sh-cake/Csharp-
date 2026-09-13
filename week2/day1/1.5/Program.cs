namespace _1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个整数，判断能否同时被 3 和 5 整除。
            Console.Write("enter a int:");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine($"{num}能同时被 3 和 5 整除");
            else
                Console.WriteLine($"{num}不能同时被 3 和 5 整除");
        }
    }
}
