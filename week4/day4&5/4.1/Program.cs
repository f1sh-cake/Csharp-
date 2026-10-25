
namespace _4._1
{
    internal class Program
    {
        // 学生最大人数
        const int MAX_STUDENTS = 10;

        // 菜单选项枚举
       enum MenuOption
        {
            Invalid=-1,
            Exit = 0,
            AddStudent = 1,
            ShowAll = 2,
            Search = 3,
            Delete = 4,
            UpdateScore = 5,
            ShowRanking = 6,
        }

        // 打印菜单
        static void PrintMenu()
        {
            Console.WriteLine("\n------ 学生成绩管理系统 ------");
            Console.WriteLine("0--退出");
            Console.WriteLine("1--添加学生");
            Console.WriteLine("2--显示所有学生");
            Console.WriteLine("3--查询信息");
            Console.WriteLine("4--删除学生信息");
            Console.WriteLine("5--修改成绩");
            Console.WriteLine("6--打印名次表");
            Console.Write("请输入选项：");
        }

        // 读取菜单选项
        static MenuOption ReadChoice()
        {
            if (int.TryParse(Console.ReadLine(), out int choice)
                && choice >= 0 && choice <= 6)
            {
                return (MenuOption)choice;
            }

            return MenuOption.Invalid;
        }

        // 读取非空姓名
        static string ReadName()
        {
            while (true)
            {
                string name = (Console.ReadLine() ?? "").Trim();

                if (name != "")
                {
                    return name;
                }

                Console.Write("姓名不能为空，请重新输入：");
            }
        }

        // 检查姓名是否已经存在
        static bool NameExists(string[] names, int count, string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (names[i] == name)
                {
                    return true;
                }
            }

            return false;
        }

        // 读取不重复的姓名
        static string ReadUniqueName(string[] names, int count)
        {
            while (true)
            {
                Console.Write("请输入姓名：");
                string name = ReadName();

                if (!NameExists(names, count, name))
                {
                    return name;
                }

                Console.WriteLine("该姓名已存在，请重新输入！");
            }
        }

        // 读取合法成绩
        static int ReadScore(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out int score)
                    && score >= 0 && score <= 100)
                {
                    return score;
                }

                Console.WriteLine("成绩无效，请输入0到100之间的整数！");
            }
        }

        // 读取确认选项
        static bool Confirm(string message)
        {
            while (true)
            {
                Console.Write($"{message} (y/n)：");

                string input = (Console.ReadLine() ?? "")
                    .Trim()
                    .ToLower();

                if (input == "y")
                {
                    return true;
                }

                if (input == "n")
                {
                    return false;
                }

                Console.WriteLine("输入无效，请输入 y 或 n！");
            }
        }

        // 计算平均分
        static double Average(int[] scores, int count)
        {
            if (count == 0)
            {
                return 0;
            }

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
            if (count == 0)
            {
                return 0;
            }

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
            if (count == 0)
            {
                return 0;
            }

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

        // 功能1：添加学生
        static void AddStudent(
            string[] names, int[] scores, ref int count)
        {
            if (count >= names.Length)
            {
                Console.WriteLine("已满员！");
                return;
            }

            string name = ReadUniqueName(names, count);
            int score = ReadScore($"请输入{name}的成绩：");

            names[count] = name;
            scores[count] = score;
            count++;

            Console.WriteLine($"添加成功！姓名：{name}，成绩：{score}");
            Console.WriteLine($"当前学生人数：{count}");
        }

        // 功能2：显示所有学生
        static void ShowAll(string[] names, int[] scores, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("暂无数据");
                return;
            }

            Console.WriteLine("\n学生列表");
            Console.WriteLine("------------------------------");
            Console.WriteLine("姓名".PadRight(12) + "成绩");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(names[i].PadRight(12) + scores[i]);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"平均分：{Average(scores, count):F2}");
            Console.WriteLine($"最高分：{Max(scores, count)}");
            Console.WriteLine($"最低分：{Min(scores, count)}");
        }

        // 按姓名查找学生，返回下标；没找到返回 -1
        static int FindStudent(string[] names, int count)
        {
            Console.Write("请输入要查找的姓名：");
            string target = (Console.ReadLine() ?? "").Trim();

            if (target == "")
            {
                return -1;
            }

            for (int i = 0; i < count; i++)
            {
                if (names[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        // 获取成绩等级
        static string GetGrade(int score)
        {
            switch (score)
            {
                case >= 90:
                    return "A";
                case >= 80:
                    return "B";
                case >= 70:
                    return "C";
                case >= 60:
                    return "D";
                default:
                    return "E";
            }
        }

        // 功能3：按姓名查询
        static void SearchAsName(
            string[] names, int[] scores, int count)
        {
            int index = FindStudent(names, count);

            if (index == -1)
            {
                Console.WriteLine("查无此人");
                return;
            }

            int score = scores[index];
            double difference = score - Average(scores, count);

            Console.WriteLine("查询成功");
            Console.WriteLine($"姓名：{names[index]}");
            Console.WriteLine($"成绩：{score}");
            Console.WriteLine($"等级：{GetGrade(score)}");

            if (difference < 0)
            {
                Console.WriteLine($"比平均分低：{Math.Abs(difference):F2}");
            }
            else if (difference > 0)
            {
                Console.WriteLine($"比平均分高：{difference:F2}");
            }
            else
            {
                Console.WriteLine("该学生成绩等于平均分");
            }
        }

        // 功能3：按分数段查询
        static void SearchAsScores(
            string[] names, int[] scores, int count)
        {
            int max;
            int min;

            while (true)
            {
                max = ReadScore("请输入最高分：");

                min = ReadScore("请输入最低分：");

                if (min <= max)
                {
                    break;
                }

                Console.WriteLine("最低分不能高于最高分，请重新输入！");
            }

            int hits = 0;

            for (int i = 0; i < count; i++)
            {
                if (scores[i] >= min && scores[i] <= max)
                {
                    Console.WriteLine(
                        $"{names[i].PadRight(12)}{scores[i]}");
                    hits++;
                }
            }

            if (hits == 0)
            {
                Console.WriteLine("该分数区间内无人");
            }
            else
            {
                Console.WriteLine($"该区间内共计{hits}人");
            }
        }

        // 功能3：查询流程
        static void SearchFlow(
            string[] names, int[] scores, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("该列表为空");
                return;
            }

            while (true)
            {
                Console.Write("按姓名查询(1)或按分数段查询(2)：");

                if (!int.TryParse(Console.ReadLine(), out int ans)
                    || (ans != 1 && ans != 2))
                {
                    Console.WriteLine("输入无效，请重新输入！");
                    continue;
                }

                if (ans == 1)
                {
                    SearchAsName(names, scores, count);
                }
                else
                {
                    SearchAsScores(names, scores, count);
                }

                return;
            }
        }

        // 功能4：删除学生
        static void Delete(
            string[] names, int[] scores, ref int count)
        {
            if (count == 0)
            {
                Console.WriteLine("该列表为空");
                return;
            }

            int index = FindStudent(names, count);

            if (index == -1)
            {
                Console.WriteLine("查无此人，无需删除");
                return;
            }

            if (!Confirm($"确认删除 {names[index]}（{scores[index]}）"))
            {
                Console.WriteLine("已取消删除");
                return;
            }

            // 将后面的学生依次向前移动
            for (int i = index; i < count - 1; i++)
            {
                names[i] = names[i + 1];
                scores[i] = scores[i + 1];
            }

            count--;

            // 清理最后一个有效位置之外的旧数据
            names[count] = "";
            scores[count] = 0;

            Console.WriteLine("删除成功");
            ShowAll(names, scores, count);
        }

        // 功能5：修改成绩
        static void UpdateScore(
            string[] names, int[] scores, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("该列表为空");
                return;
            }

            int index = FindStudent(names, count);

            if (index == -1)
            {
                Console.WriteLine("查无此人");
                return;
            }

            Console.WriteLine(
                $"{names[index]}当前成绩：{scores[index]}");

            int newScore = ReadScore("请输入新成绩：");

            if (!Confirm("确认修改成绩"))
            {
                Console.WriteLine("已取消修改");
                return;
            }

            scores[index] = newScore;

            Console.WriteLine(
                $"{names[index]}的成绩已修改为{scores[index]}");

            ShowAll(names, scores, count);
        }

        // 交换两个整数
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 功能6：按成绩降序打印名次表
        static void ShowRankingByIndex(
            string[] names, int[] scores, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("该列表为空");
                return;
            }

            // 保存学生原始下标，不直接修改原数组
            int[] order = new int[count];

            for (int i = 0; i < count; i++)
            {
                order[i] = i;
            }

            // 对下标数组进行冒泡排序
            for (int i = 0; i < count - 1; i++)
            {
                bool isSwapped = false;

                for (int j = 0; j < count - i - 1; j++)
                {
                    if (scores[order[j]] < scores[order[j + 1]])
                    {
                        Swap(ref order[j], ref order[j + 1]);
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                {
                    break;
                }
            }

            Console.WriteLine("\n------ 排名表 ------");

            for (int i = 0; i < count; i++)
            {
                int index = order[i];

                Console.WriteLine(
                    $"{i + 1}. {names[index]}，成绩：{scores[index]}");
            }
        }

        // 主程序
        static void Main(string[] args)
        {
            string[] names = new string[MAX_STUDENTS];
            int[] scores = new int[MAX_STUDENTS];

            int count = 0;
            bool isAgain = true;

            while (isAgain)
            {
                PrintMenu();

                MenuOption choice = ReadChoice();

                switch (choice)
                {
                    case MenuOption.Exit:
                        Console.WriteLine("已退出");
                        isAgain = false;
                        break;

                    case MenuOption.AddStudent:
                        AddStudent(names, scores, ref count);
                        break;

                    case MenuOption.ShowAll:
                        ShowAll(names, scores, count);
                        break;

                    case MenuOption.Search:
                        SearchFlow(names, scores, count);
                        break;

                    case MenuOption.Delete:
                        Delete(names, scores, ref count);
                        break;

                    case MenuOption.UpdateScore:
                        UpdateScore(names, scores, count);
                        break;

                    case MenuOption.ShowRanking:
                        ShowRankingByIndex(names, scores, count);
                        break;

                    default:
                        Console.WriteLine("输入不合法，请重新输入！");
                        break;
                }
            }
        }
    }
}
