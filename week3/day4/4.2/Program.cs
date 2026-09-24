namespace _4._2
{
    internal class Program
    {
        ////5 个成绩存进数组（输入校验 0-100），
        //再统一求总分、平均分（两位小数）、最高分（`Math.Max`）、最低分、及格人数

        // 输入第 index 位成绩，含 0-100 输入校验，非法重输
        static int InputScores(int index)
        {
            int score = 0;
            bool isAgain = true;
            do
            {
                Console.Write($"请输入第{index}位的成绩：");
                score = int.Parse( Console.ReadLine() );
                if (score >= 0 && score <= 100) isAgain = false;
                else Console.WriteLine("非法输入，请重输！");
            } while (isAgain);
            return score;
        }

        //求总分
        static int GetSum(int[]a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }

        // 平均分
        static double GetAver(int[]a)
        {
            return (double)GetSum(a)/a.Length;
        }

        //求最高分
        static int FindMax(int[]a)
        {
            int max = a[0];
            foreach (int i in a)
            {
                max = Math.Max(max, i);
            }
            return max;
        }

        //求及格人数（>=60）
        static int GetPassnum(int[]a)
        {
            int passnum = 0;
            foreach(int i in a)
            {
                if(i>=60) passnum++;
            }
            return passnum;
        }

        // 输出一份统计报告（内部调用上面几个方法）
        static void PrintReport(int[] a)
        {
            Console.WriteLine($"总分为{GetSum(a)}");
            Console.WriteLine($"平均分为{GetAver(a):F2}");
            Console.WriteLine($"最高分为{FindMax(a)}");
            Console.WriteLine($"及格人数为{GetPassnum(a)}");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[5];
            for(int i = 0;i<5;i++)
            {
                scores[i] = InputScores(i + 1);
            }
            PrintReport(scores);
        }
    }
}
