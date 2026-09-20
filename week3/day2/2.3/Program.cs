namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] scores = { { 80, 90, 70, 100 }, { 60, 60, 60, 60 }, { 95, 85, 75, 65 } };（3 名学生 × 4 科）
            //输出每位学生的平均分（按行求平均，两位小数）
            //输出每科的平均分（按列求平均，两位小数）
            //输出总分最高的学生序号与总分（用 Math.Max 比较，序号用 1 开始）
            int[,] scores = { { 80, 90, 70, 100 }, { 60, 60, 60, 60 }, { 95, 85, 75, 65 } };

            //总分最高的总分


            int max = 0;
            int maxId = 0;

            //输出每位学生的平均分
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                int sumOfEachStudent = 0;
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    sumOfEachStudent += scores[i, j];

                }

                Console.WriteLine($"第{i + 1}位学生的平均分为{((double)sumOfEachStudent / scores.GetLength(1)):F2}");

                if (sumOfEachStudent > max)
                {
                    max = sumOfEachStudent;
                    maxId = i;
                }
            }
            Console.WriteLine($"总分最高的学生序号为{maxId+1},总分为{max}");

            //输入每科的平均分
            for (int j = 0; j < scores.GetLength(1); j++)
            {
                int sumOfEachCourse = 0;
                for (int i = 0; i < scores.GetLength(0); i++)
                {
                    sumOfEachCourse += scores[i, j];
                }
                Console.WriteLine($"第{j + 1}门学科的平均分为{((double)sumOfEachCourse / scores.GetLength(0)):F2}");
            }
        }
    }
}
