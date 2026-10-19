namespace _1._1
{
    //定义 MAX_STUDENTS + 两个数组 + count；
    //写 PrintMenu() 打印 7 个选项；
    //写 ReadChoice()（读一行 → TryParse 成功返回，失败返回 -1，交给 default 处理）；
    //每个选项只打印「功能待实现」，case 0 退出。
    internal class Program
    {
        //打印菜单
        static void PrintMenu()
        {
            Console.WriteLine("0--退出");
            Console.WriteLine("1--「功能待实现」");
            Console.WriteLine("2--「功能待实现」");
            Console.WriteLine("3--「功能待实现」");
            Console.WriteLine("4--「功能待实现」");
            Console.WriteLine("5--「功能待实现」");
            Console.WriteLine("6--「功能待实现」");
            Console.Write("请输入选项：");
        }

        //读取选项
        static int ReadChoice()
        {
            //TryParse 成功返回，失败返回 - 1
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= 6)
            {
                return choice;
            }
                return -1;
        }

        static void Main(string[] args)
        {
            //定义学生最大人数
            const int MAX_STUDENTS = 10;

            string[] students = new string[MAX_STUDENTS];
            int[] scores = new int[MAX_STUDENTS];

            //已录入的人数
            int count = 0;

            //是否继续
            bool isAgain = true;

            while (isAgain)
            {
                //打印菜单
                PrintMenu();

                switch (ReadChoice())
                {
                    case 0:
                        Console.WriteLine("已退出");
                        isAgain = false;
                        break;
                    case 1:
                        Console.WriteLine("功能待实现");
                        break;
                    case 2:
                        Console.WriteLine("功能待实现");
                        break;
                    case 3:
                        Console.WriteLine("功能待实现");
                        break;
                    case 4:
                        Console.WriteLine("功能待实现");
                        break;
                    case 5:
                        Console.WriteLine("功能待实现");
                        break;
                    case 6:
                        Console.WriteLine("功能待实现");
                        break;
                    default:
                        Console.WriteLine("输入不合法，请重新输入：");
                        break;
                }
            }
        }
    }
}