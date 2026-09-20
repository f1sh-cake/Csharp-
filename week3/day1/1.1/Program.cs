namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 个成绩存进数组（输入校验 0-100），
            //再统一求总分、平均分（两位小数）、最高分（`Math.Max`）、最低分、及格人数

            int[] scores = new int[5];
            int sum = 0;
            double aver = 0;
            int max = 0;
            int min = 100;
            int passNum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"请输入第{i + 1}个成绩:");
                scores[i] = int.Parse(Console.ReadLine());

                while (scores[i] < 0 || scores[i] > 100)
                {
                    Console.Write("输入无效，请重新输入:");
                    scores[i] = int.Parse(Console.ReadLine());
                }

                sum += scores[i];

                if (scores[i]>=60)
                {
                    passNum++;
                }

                max = Math.Max(max, scores[i]);
                min = Math.Min(min, scores[i]);

            }

            aver = (double)sum/scores.Length;

            Console.WriteLine($"总分为{sum},平均分为{aver:F2},最高分为{max},最低分为{min}，及格人数为{passNum}");
        }
    }
}