namespace _3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一句带多余空格的文本
            //用 Trim() 去掉首尾空格
            //用 while +Replace 把连续空格压成单个空格：while (s.Contains("  ")) { s = s.Replace("  ", " "); 轮数++; }
            //输出清洗后的句子、单词个数（Split(' ', StringSplitOptions.RemoveEmptyEntries).Length）、以及"清洗用了几轮"

            Console.Write("输入一句带多余空格的文本：");
            string s = Console.ReadLine();
            s = s.Trim();

            //记录清洗轮数
            int count = 0;

            while(s.Contains("  "))
            {
                s = s.Replace("  ", " ");
                count++;
            }

            string[] words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int wordsNum = words.Length;

            Console.WriteLine($"清洗后的句子为{s},单词个数为{wordsNum},清洗用了{count}轮");
        }
    }
}
