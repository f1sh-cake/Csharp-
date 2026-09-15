namespace _4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用 continue 输出 1 到 50 中所有不能被 3 整除的数。
            for(int i = 0;i<=50;i++)
            {
                //特殊情况先踢出去,避免大量嵌套
                if (i % 3 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
