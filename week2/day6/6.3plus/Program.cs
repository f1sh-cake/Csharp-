namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //菜单程序（switch + while）。
            //要求：循环显示菜单（至少包含加法、减法、退出），选 0 退出。
            //给菜单程序加上除法选项，并处理"除数为 0"的情况。

            while (true)
            {
                Console.Write("1-加法，2-减法，3-除法，0退出：");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }

                if (choice != 1 && choice != 2 && choice != 3)
                {
                    Console.WriteLine("输入无效！");
                    continue;
                }

                Console.Write("输入第一个数：");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("输入第二个数：");
                int num2 = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                        break;
                    case 3:
                        if (num2 == 0)
                        {
                            Console.WriteLine("式子不合法！");
                        }
                        else
                        {
                            Console.WriteLine($"{num1}/{num2}= {(double)num1 / num2:F2}");
                        }
                        break;
                }

            }

        }
    }
}
