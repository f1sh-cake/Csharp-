
namespace _7._2
{
    internal class Program
    {
        // 定义学生最大人数
        const int MAX_STUDENTS = 10;

        // 打印菜单
        static void PrintMenu()
        {
            Console.WriteLine("0--退出");
            Console.WriteLine("1--添加学生");
            Console.WriteLine("2--显示所有学生");
            Console.WriteLine("3--「功能待实现」");
            Console.WriteLine("4--「功能待实现」");
            Console.WriteLine("5--「功能待实现」");
            Console.WriteLine("6--「功能待实现」");
            Console.Write("请输入选项：");
        }

        // 读取选项
        static int ReadChoice()
        {
            if (int.TryParse(Console.ReadLine(), out int choice)
                && choice >= 0 && choice <= 6)
            {
                return choice;
            }

            return -1;
        }

        // 功能1：添加学生
        static void AddStudent(string[] names, int[] scores, ref int count)
        {
            // 判断是否满员
            if (count >= names.Length)
            {
                Console.WriteLine("已满员！");
                return;
            }

            // 输入并检查姓名
            string name;

            while (true)
            {
                Console.Write("请输入姓名：");
                name = (Console.ReadLine() ?? "").Trim();

                if (name == "")
                {
                    Console.WriteLine("姓名不能为空，请重新输入！");
                    continue;
                }

                bool isSame = false;

                for (int i = 0; i < count; i++)
                {
                    if (name == names[i])
                    {
                        isSame = true;
                        break;
                    }
                }

                if (isSame)
                {
                    Console.WriteLine("该姓名已存在，请重新输入！");
                    continue;
                }

                break;
            }

            // 输入并检查成绩
            int score;

            while (true)
            {
                Console.Write($"请输入{name}的成绩：");

                if (int.TryParse(Console.ReadLine(), out score)
                    && score >= 0 && score <= 100)
                {
                    break;
                }

                Console.WriteLine("成绩无效，请输入0到100之间的整数！");
            }

            // 写入数组
            names[count] = name;
            scores[count] = score;
            count++;

            Console.WriteLine($"添加成功！姓名：{name}，成绩：{score}");
            Console.WriteLine($"当前学生人数：{count}");
        }

        // 计算平均分
        static double Average(int[] scores, int count)
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += scores[i];
            }

            return (double)sum / count;
        }

        // 计算最高分
        static int Max(int[] scores, int count)
        {
            int max = scores[0];

            for (int i = 1; i < count; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                }
            }

            return max;
        }

        // 计算最低分
        static int Min(int[] scores, int count)
        {
            int min = scores[0];

            for (int i = 1; i < count; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
            }

            return min;
        }

        // 功能2：显示所有学生
        static void ShowAll(string[] names, int[] scores, int count)
        {
            // 没有学生时直接返回
            if (count == 0)
            {
                Console.WriteLine("暂无数据");
                return;
            }

            // 输出列表
            Console.WriteLine("\n学生列表");
            Console.WriteLine("------------------------------");
            Console.WriteLine("姓名".PadRight(12)+"成绩");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(names[i].PadRight(12) + scores[i]);
            }

            Console.WriteLine("------------------------------");

            // 输出统计结果
            Console.WriteLine($"平均分：{Average(scores, count):F2}");
            Console.WriteLine($"最高分：{Max(scores, count)}");
            Console.WriteLine($"最低分：{Min(scores, count)}");
        }

        static void Main(string[] args)
        {
            string[] names = new string[MAX_STUDENTS];
            int[] scores = new int[MAX_STUDENTS];

            // 已录入的学生人数
            int count = 0;

            bool isAgain = true;

            while (isAgain)
            {
                PrintMenu();

                switch (ReadChoice())
                {
                    case 0:
                        Console.WriteLine("已退出");
                        isAgain = false;
                        break;

                    case 1:
                        AddStudent(names, scores, ref count);
                        break;

                    case 2:
                        ShowAll(names, scores, count);
                        break;

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("功能待实现");
                        break;

                    default:
                        Console.WriteLine("输入不合法，请重新输入！");
                        break;
                }
            }
        }
    }
}
