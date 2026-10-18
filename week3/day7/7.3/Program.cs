
namespace _7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一行空格分隔的数字：");
            string s = Console.ReadLine();

            if (s == null)
            {
                Console.WriteLine("输入无效！");
                return;
            }

            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string x in words)
            {
                if (int.TryParse(x, out int num))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"已跳过 {x}");
                }
            }

            Console.WriteLine($"合法数字个数：{count}");
        }
    }
}
