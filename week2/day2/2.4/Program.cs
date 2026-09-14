namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入年份和月份，输出该月天数。其中 2 月要按闰年判断——闰年 29 天，平年 28 天。
            int year = 0;
            int month = 0;

            Console.Write("enter a year:");
            year = int.Parse(Console.ReadLine());
            Console.Write("enter a month:");
            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30days");
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    {
                        Console.WriteLine("29days");
                    }
                    else
                    {
                        Console.WriteLine("28days");
                    }
                    break;
                default:
                    Console.WriteLine("输入无效");
                    break;

            }

        }
    }
}
