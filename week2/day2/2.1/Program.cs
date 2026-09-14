namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入 1-7，输出对应的星期名称（用 switch，default 处理无效输入）。
            Console.Write("please enter a weekday:");
            int weekday = int.Parse(Console.ReadLine());
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("mon");
                    break;
                case 2:
                    Console.WriteLine("tue");
                    break;
                case 3:
                    Console.WriteLine("wed");
                    break;
                case 4:
                    Console.WriteLine("thur");
                    break;
                case 5:
                    Console.WriteLine("fri");
                    break;
                case 6:
                    Console.WriteLine("sat");
                    break;
                case 7:
                    Console.WriteLine("sun");
                    break;
                default:
                    Console.WriteLine("输入无效");
                    break;
            }
        }
    }
}
