//题 ① 成绩排名表
//1. 输入学生人数 N（1–10，用 TryParse 校验），再逐行输入「姓名 + 3 科成绩」，姓名存字符串数组、成绩存 int[,]
//2. 输出每人总分与平均分（两位小数）
//3. 用冒泡按总分降序排出榜单——交换时姓名和整行成绩必须一起搬

namespace _7._1
{

    internal class Program
    {
        //录入成绩
        static void InputData(string[] name, int[,] score)
        {
            for (int i = 0; i < score.GetLength(0); i++)
            {
                Console.Write($"第{i + 1}个人为:");
                name[i] = Console.ReadLine();
                Console.Write("他的三科成绩分别为：");
                for (int j = 0; j < 3; j++)
                {
                    score[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //求每人总分
        static void GetEachSum(int[,] score)
        {
            for (int i = 0; i < score.GetLength(0); i++)
            {
                score[i, 3] = 0;
                for (int j = 0; j < 3; j++)
                {
                    score[i, 3] += score[i, j];
                }
            }
        }

        //输出每人总分
        static void ShowEachSum(int[,] score)
        {
            for (int i = 0; i < score.GetLength(0); i++)
            {
                Console.WriteLine($"第{i + 1}位的总分为{score[i, 3]}：");
            }
        }

        //输出每人平均分
        static void ShowEachAver(int[,] score)
        {
            for (int i = 0; i < score.GetLength(0); i++)
            {
                Console.WriteLine($"第{i + 1}位的平均分为{score[i, 3] / 3.0:F2}");
            }
        }

        //用冒泡按总分降序排出榜单——交换时姓名和整行成绩必须一起搬
        static void Sort(string[] name, int[,] score)
        {
            for (int i = 0; i < score.GetLength(0) - 1; i++)
            {
                bool isSwapped = false;
                for (int j = 0; j < score.GetLength(0) - i - 1; j++)
                {

                    if (score[j, 3] < score[j + 1, 3])
                    {

                        isSwapped = true;

                        //交换分数
                        for (int k = 0; k < 4; k++)
                        {
                            int tempScore = score[j, k];
                            score[j, k] = score[j + 1, k];
                            score[j + 1, k] = tempScore;
                        }

                        //交换姓名
                        string temp2 = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = temp2;

                    }
                }

                if (!isSwapped)
                {
                    break;
                }
            }

            //输出排序后的榜单
            for (int i = 0; i < score.GetLength(0); i++)
            {
                Console.WriteLine($"排名第{i + 1}的学生为{name[i]},他的总分为{score[i, 3]}");
            }

        }

        static void Main(string[] args)
        {
            //学生人数
            Console.Write("请输入学生人数N(1-10)：");
            if (int.TryParse(Console.ReadLine(), out int StuNum) && (StuNum <= 10 && StuNum >= 1))
            {
                Console.Write("请逐行输入姓名+三科成绩：");
            }
            else
            {
                Console.WriteLine("输入无效！");
                return;
            }

            string[] name = new string[StuNum];
            int[,] score = new int[StuNum, 4];

            InputData(name, score);
            GetEachSum(score);
            ShowEachSum(score);
            ShowEachAver(score);
            Sort(name, score);
        }
    }
}



