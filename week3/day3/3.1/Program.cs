namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一句话，再输入一个目标字符（用 char.Parse(Console.ReadLine()) 或取输入串的 [0]）
            //用 foreach 数出出现次数
            //用 IndexOf / LastIndexOf 输出第一次和最后一次出现的下标；没出现要输出"未出现"而不是 - 1 直接当索引用
            //进阶：用 IndexOf(c, 起点) 循环，把所有出现位置按 0,4,7 的格式输出
            
            Console.Write("请输入一句话：");
            string input = Console.ReadLine();
            Console.Write("输入你的目标字符：");
            char target = char.Parse(Console.ReadLine());

            //记录target出现次数
            int count = 0;
            foreach (char x in input)
            {
                if (x == target) count++;
            }
            Console.WriteLine($"共出现{count}次");

            int firstAppearPos = input.IndexOf(target);
            int lastAppearPos = input.LastIndexOf(target);

            if (firstAppearPos == -1)
            {
                Console.WriteLine("没找到");
            }
            else
            {
                Console.WriteLine($"第一次找到的位置在{firstAppearPos},最后一次找到的位置在{lastAppearPos}");
            }

            int pos = firstAppearPos;
            bool isFirst = true;

            while(pos!=-1)
            {
                if(!isFirst)
                {
                    Console.Write(",");
                }
                Console.Write($"{pos}");
                pos = input.IndexOf(target, pos + 1);
                isFirst = false;
            }
        }
    }
}
