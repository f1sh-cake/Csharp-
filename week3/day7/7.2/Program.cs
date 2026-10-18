namespace _7._2
{
    //输入一句英文（含大小写和多余空格），
    //输出：词数、最长单词（并列取第一个）、平均词长（两位小数）、回文单词列表（忽略大小写）、按词长升序排序后的整句。
    //验收：不许用 Dictionary 之类的容器；排序手写冒泡；回文判断要能复用到"每个单词"上。
    //自测："Level up your java Skills" → 词数 5；最长 Skills（6）；平均词长 4.20；回文词 Level；排序后 up your java Level Skills。
    internal class Program
    {
        //判断是否回文
        static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int head = 0;
            int tail = s.Length - 1;

            while (head < tail)
            {
                if (s[head] != s[tail])
                {
                    return false;
                }
                head++;
                tail--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("请输入一句英文：");
            string s = Console.ReadLine();

            if (s == null)
            {
                Console.WriteLine("输入无效！");
                return;
            }

            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if(words.Length == 0)
            {
                Console.WriteLine("输入无效！");
                return;
            }

            //输出词数
            Console.WriteLine($"单词数为{words.Length}");

            //输出最长单词
            string max = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > max.Length)
                {
                    max = words[i];
                }
            }
            Console.WriteLine($"最长单词为{max}");

            //输出平均词长
            int wordsLengthSum = 0;
            foreach (string word in words)
            {
                wordsLengthSum += word.Length;
            }
            Console.WriteLine($"平均字长为：{wordsLengthSum / (float)words.Length:F2}");

            //输出回文单词列表
            Console.WriteLine("回文单词如下：");
            for (int i = 0;i<words.Length;i++)
            {
                if (IsPalindrome(words[i]))
                {
                    Console.WriteLine(words[i]);
                }
            }

            //按词长升序排序后的整句
            for(int i = 0; i < words.Length-1;i++)
            {
                bool isSwapped = false;

                for (int j = 0; j < words.Length-1-i; j++)
                {
                    if(words[j].Length > words[j+1].Length)
                    {
                        isSwapped = true;

                        string temp = words[j];
                        words[j] = words[j+1];
                        words[j+1] = temp;
                    }
                }

                if(!isSwapped)
                {
                    break;
                }
            }

            s = string.Join(" ", words);
            Console.WriteLine(s);
        }
    }
}
