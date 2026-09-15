namespace _4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //反复输入整数，直到输入 0 停止，最后输出这些数的和与个数。
            //提示：用 while (true) + if (n == 0) break;，这是 break 最实用的场景。
            int sum = 0;
            int count = 0;
            while (true)
            {
                Console.Write("enter a num(0 exit):");
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                sum += num;
                count++;
            }
            Console.WriteLine($"sum is {sum}");
            Console.WriteLine($"count is {count}");
        }
    }
}
