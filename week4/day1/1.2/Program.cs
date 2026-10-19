
namespace _1._2
{
    //签名固定：static void AddStudent(string[] names, int[] scores, ref int count)。
    //流程：满员判定 → 读姓名（Trim + 非空，失败重问）→ 重名检查 → 读成绩（TryParse + 0–100，失败重问）→ 写入两个数组 → count++ → 打印确认。
    internal class Program
    {
        // 定义学生最大人数
        const int MAX_STUDENTS = 10;

        // 打印菜单
        static void PrintMenu()
        {
            Console.WriteLine("0--退出");
            Console.WriteLine("1--添加学生");
            Console.WriteLine("2--「功能待实现」");
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
            // 1. 判断是否满员
            if (count >= names.Length)
            {
                Console.WriteLine("已满员！");
                return;
            }

            // 2. 读取并检查姓名
            string name;

            while (true)
            {
                Console.Write("请输入姓名：");
                name = Console.ReadLine() ?? "";
                name = name.Trim();

                // 判断姓名是否为空
                if (name == "")
                {
                    Console.WriteLine("姓名不能为空，请重新输入！");
                    continue;
                }

                // 检查是否重名
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

                // 姓名合法且没有重名
                break;
            }

            // 3. 读取并检查成绩
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

            // 4. 写入数组
            names[count] = name;
            scores[count] = score;

            // 5. 人数加一
            count++;

            // 6. 打印确认
            Console.WriteLine($"添加成功！姓名：{name}，成绩：{score}");
            Console.WriteLine($"当前学生人数：{count}");
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
