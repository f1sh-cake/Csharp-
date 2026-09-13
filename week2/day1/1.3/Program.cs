namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个整数，判断奇偶。
            Console.Write("enter an integer:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
