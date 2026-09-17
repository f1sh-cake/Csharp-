namespace _7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入上半部分行数 n
            //双重循环打印共 2n - 1 行居中菱形，n = 3 时是 1 / 3 / 5 / 3 / 1 个星号
            //先在纸上写出 n = 3、n = 4 每行的空格数与星号数，把规律写进注释再写代码
            //打印完输出总行数、总星号数，并用 Math.Pow 算理论值 n² +(n - 1)² 做"校验通过 / 不一致"对比

            Console.Write("请输入上半行行数n:");
            int n = int.Parse(Console.ReadLine());

            int count = 0;


            for(int i = 1;i<=2*n-1;i++)
            {
                int space = Math.Abs(n - i);
                int star = 2 * n - 1 - 2 * space;
                for (int j = 1;j<=space;j++)
                {
                    Console.Write(' ');
                }
                for(int j = 1;j<=star;j++)
                {
                    Console.Write("*");
                }
                count += star;
                Console.WriteLine();
            }

            Console.WriteLine($"总行数为{2*n-1}");
            Console.WriteLine($"共有{count}颗*");
            if (count == Math.Pow(n, 2) + Math.Pow(n - 1, 2))
            {
                Console.WriteLine("校验通过！");
            }
            else Console.WriteLine("不一致");
        }
    }
}
