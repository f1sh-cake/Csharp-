namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算 n 的阶乘。
            int n = 0;
            long result = 1;

            Console.Write("enter an int:");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("invalid");
            }
            else
            {
                while (n > 1)
                {
                    result *= n;
                    n--;
                }
                Console.WriteLine($"n! = {result}");
            }
        }
    }
}
