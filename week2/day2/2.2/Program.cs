namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用 switch 做简易菜单——输入两个数和一个选项（1 加法、2 减法、3 退出），根据选项输出结果。
            Console.Write("输入第一个数：");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("第二个数：");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("输入一个选项（1 加法、2 减法、3 退出）");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine($"{num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1 - num2}");
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("输入无效");
                    break;
            }

        }
    }
}
