namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数 n，校验 1–50，非法用 do-while 一直重输
            //for 循环 i 从 1 到 n，输入第 i 位同学成绩，校验 0–100，非法用 while 重输这一位
            //每输入一位立刻打印等级：90–100 A，80–89 B，70–79 C，60–69 D，60 以下 F
            //全部输入完输出：人数、总分、平均分（两位小数）、最高分、最低分、及格人数、及格率（百分比格式）

            //人数
            int studentNum = 0;
            //总分
            int total = 0;
            //平均分
            float aver = 0;
            //最高分最低分
            int max = 0;
            int min = 100;
            //及格人数
            int passNum = 0;
            //及格率
            float passRate = 0;

            do
            {
                Console.Write("请输入班级人数（1-50）:");
                studentNum = int.Parse(Console.ReadLine());
            } while (studentNum <= 0 || studentNum > 50);

            for (int i = 1; i <= studentNum; i++)
            {
                int score = 0;
                do
                {
                    Console.Write($"请输入第{i}位同学的成绩：");
                    score = int.Parse(Console.ReadLine());
                } while (score < 0 || score > 100);
                total += score;

                if (score >= 90) Console.WriteLine("A");
                else if (score >= 80) Console.WriteLine("B");
                else if (score >= 70) Console.WriteLine("C");
                else if (score >= 60) Console.WriteLine("D");
                else Console.WriteLine("F");

                if (score >= 60) passNum++;

                if (score > max) max = score;
                if (score < min) min = score;

            }

            aver = (float)total / studentNum;
            passRate = (float)passNum / studentNum;

            Console.WriteLine($"人数为{studentNum}");
            Console.WriteLine($"总分为{total}");
            Console.WriteLine($"平均分为{aver:F2}");
            Console.WriteLine($"最高分为{max}");
            Console.WriteLine($"最低分为{min}");
            Console.WriteLine($"及格人数为{passNum}");
            Console.WriteLine($"及格率为{passRate:P}");
        }
    }
}
