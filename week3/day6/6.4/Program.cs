namespace _6._4
{
    internal class Program
    {
        //输入一句话，Split 拆成单词数组（用 RemoveEmptyEntries），用冒泡按单词长度升序排序，再用 string.Join(" ", words) 输出。

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.Write("please enter a sentense:");
            string s1 = Console.ReadLine();
            if (s1.Length == 0)
            {
                Console.WriteLine("输入为空");
                return;
            }
            string[] words = s1.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //控制轮数
            for (int i = 0; i < words.Length - 1; i++)
            {
                //判断本轮是否交换过
                bool isSwapped = false;

                for (int j = 0; j < words.Length - 1 - i; j++)
                {
                    if (words[j].Length > words[j + 1].Length)
                    {
                        Swap(ref words[j], ref words[j + 1]);
                        isSwapped = true;
                    }
                }

                //该轮没交换则退出
                if (!isSwapped)
                {
                    break;
                }
            }

            //拼装句子
            string s2 = string.Join(" ", words);
            Console.WriteLine($"重组后为{s2}");
        }
    }
}