namespace _1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //长度 5 的数组，输入 5 个整数
            //输入目标值 target
            //for +bool 标志位找第一次出现的位置：找到输出下标并 break，找不到输出 - 1
            //再输出出现次数（这一轮不能 break，要完整遍历）
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"请输入第{i + 1}个数:");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("请输入你要找的值:");
            int target = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    isFound = true;
                    Console.WriteLine($"找到了，第一次出现在第{i + 1}个");
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("-1-没找到！");
            }
            else
            {
                int foundTimes = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == target)
                    {
                        foundTimes++;
                    }
                }
                Console.WriteLine($"共出现了{foundTimes}次");
            }
        }

    }
}
