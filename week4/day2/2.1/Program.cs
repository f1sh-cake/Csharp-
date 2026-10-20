
namespace _2._1
{
    internal class Program
    {
        // 定义学生最大人数
        const int MAX_STUDENTS = 10;

        // 打印菜单
        static void PrintMenu()
        {
            Console.WriteLine("------菜单------");
            Console.WriteLine("0--退出");
            Console.WriteLine("1--添加学生");
            Console.WriteLine("2--显示所有学生");
            Console.WriteLine("3--查询信息");
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
            Console.WriteLine("姓名".PadRight(12) + "成绩");

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

        //按名字找
        static void SearchAsName(string[] names, int[] scores, int count)
        {
            Console.Write("请输入要查询的姓名：");
            string target = Console.ReadLine();
            target = target.Trim();

            //找到的id位置
            int idIndex = -1;

            for (int i = 0; i < count; i++)
            {
                if (names[i] == target)
                {
                    idIndex = i;
                    break;
                }
            }

            if (idIndex==-1)
            {
                Console.WriteLine("未找到");
            }
            else
            {
                Console.WriteLine($"成功找到");
                Console.WriteLine($"姓名为{names[idIndex]}");
                Console.WriteLine($"成绩为{scores[idIndex]}");
                switch (scores[idIndex])
                {
                    case >= 90:
                        Console.WriteLine("等级为A");
                        break;
                    case >= 80:
                        Console.WriteLine("等级为B");
                        break;
                    case >= 70:
                        Console.WriteLine("等级为C");
                        break;
                    case >= 60:
                        Console.WriteLine("等级为D");
                        break;
                    case >= 0:
                        Console.WriteLine("等级为E");
                        break;
                    default:
                        Console.WriteLine("出现故障");
                        break;
                }

                double differences = scores[idIndex] - Average(scores, count);

                if (differences < 0)
                    Console.WriteLine($"比平均分低{Math.Abs(differences):F2}");
                else if (differences > 0)
                    Console.WriteLine($"比平均分高{differences:F2}");
                else
                    Console.WriteLine("该学生成绩等于平均分");
            }
        }

        //按分数段找
        static void SearchAsScores(string[] names, int[] scores, int count)
        {
            bool isSuccessful = false;
            int max = 0;
            int min = 0;
            while (!isSuccessful)
            {
                Console.Write("请输入最大值：");
                if (int.TryParse(Console.ReadLine(), out max)
                    && max <= 100
                    && max >= 0)
                {
                    while (true)
                    {
                        Console.Write("请输入最小值：");
                        if (int.TryParse(Console.ReadLine(), out min)
                            && min >= 0
                            && min <= max)
                        {
                            isSuccessful = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("输入无效，请重新输入");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("输入无效，请重新输入");
                }
            }

            //该区间内找到人数
            int hits = 0;

            for (int i = 0; i < count; i++)
            {
                if (scores[i] >= min && scores[i] <= max)
                {
                    Console.WriteLine($"{names[i].PadRight(10)}{scores[i]}");
                    hits++;
                }
            }

            if (hits == 0)
            {
                Console.WriteLine("改分数区间内无人");
            }
            else
            {
                Console.WriteLine($"该区间内共计{hits}人");
            }
        }

        //功能3：查询
        static void SearchFlow(string[] names, int[] scores, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("该列表为空");
                return;
            }
            Console.WriteLine("按姓名查询(1)or按分数段查询(2)：");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int ans) && (ans == 1 || ans == 2))
                {
                    if (ans == 1) SearchAsName(names, scores, count);
                    else SearchAsScores(names, scores, count);
                }
                else
                {
                    Console.WriteLine("输入无效，请重新输入");
                    continue;
                }

                //输入有效退出
                break;
            }
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
                        SearchFlow(names, scores, count);
                        break;
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
