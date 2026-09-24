namespace _5._2
{
    internal class Program
    {
        //把 Day 4 的 ReadScore 改成用 int.TryParse + out 做校验，
        //要求：输入 abc 不崩、输入 101 提示超范围、输入 88 正常通过，并且方法里不许再出现 int.Parse
        static int InputScores(int index)
        {
            while (true)
            {
                Console.Write($"请输入第{index}位的成绩：");
                if (int.TryParse(Console.ReadLine(), out int score))
                {
                    if (score >= 0 && score <= 100)
                    {
                        return score;
                    }
                    else Console.WriteLine("超范围，请重新输入！");
                }
                else Console.WriteLine("非法输入，请重输！");
            }
        }
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            for (int i = 0; i < 5; i++)
            {
                scores[i] = InputScores(i + 1);
            }
        }

    }
}