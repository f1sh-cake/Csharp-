namespace _4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个正整数，用 while 判断它是几位数。
            
            //计数
            int count = 1;     //计数

            Console.Write("输入一个正整数：");
            int num = int.Parse(Console.ReadLine());

            while (num / 10 != 0)
            {
                num /= 10;
                count++;
            }

            Console.WriteLine($"输入的为{count}位数");
        }
    }
}
