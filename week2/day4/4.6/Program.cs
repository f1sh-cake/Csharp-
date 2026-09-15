namespace _4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用 break 写——循环输入整数，遇到负数就停止，最后输出已经输入的正数个数。
            int count = 0;

            while (true)
            {
                Console.Write("enter a int(input negatively exit):");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    break;
                }
                if (num > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"共输入{count}个正数");
        }
    }
}
