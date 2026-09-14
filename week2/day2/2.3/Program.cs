namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入月份 1-12，输出该月天数（1/3/5/7/8/10/12 月是 31 天，4/6/9/11 月是 30 天，2 月按 28 天）。
            Console.Write("enter a month:");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 2:
                    Console.WriteLine("28 days");
                    break;
                default:
                    Console.WriteLine("输入无效");
                    break;
            }
        }
    }
}
