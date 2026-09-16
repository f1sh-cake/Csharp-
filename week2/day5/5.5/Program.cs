namespace _5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用双重循环打印一个直角三角形的星号图案（5 行）。
            for(int i = 1;i<=5;i++)
            {
                for(int j = 1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
