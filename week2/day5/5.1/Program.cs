namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //打印九九乘法表（双重循环）
            for (int i = 1;i<=9;i++)
            {
                for(int j = 1;j<=i;j++)
                {
                    Console.Write($"{j}*{i}={i * j}\t" );
                }
                Console.WriteLine();
            }
        }
    }
}
