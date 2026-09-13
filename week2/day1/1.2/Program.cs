namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入年份，判断是闰年还是平年
            Console.Write("enter a year:");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("leap year");
            else
                Console.WriteLine("common year");
            
        }
    }
}
