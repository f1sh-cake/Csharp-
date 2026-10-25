
using System;

namespace _4._2
{
    internal class Program
    {
        // 最大角色数量
        const int MAX_CHARACTERS = 20;

        // 菜单选项
        enum MenuOption
        {
            Invalid = -1,
            Exit = 0,
            Add = 1,
            ShowAll = 2,
            Search = 3,
            Update = 4,
            Delete = 5,
            Sort = 6,
            Report = 7
        }

        // 属性选项
        enum AttributeOption
        {
            Attack = 1,
            Defense = 2
        }

        // 角色类型
        enum RoleType
        {
            Output,
            Tank,
            Balanced
        }

        // 三个平行数组
        static string[] names = new string[MAX_CHARACTERS];
        static int[] attack = new int[MAX_CHARACTERS];
        static int[] defense = new int[MAX_CHARACTERS];

        // 当前有效人数
        static int count = 0;

        // ==================== 基础计算 ====================

        // 计算战力
        static int Power(int attack, int defense)
        {
            return attack * 2 + defense;
        }

        // 获取指定角色的战力
        static int GetPower(int index)
        {
            return Power(attack[index], defense[index]);
        }

        // 获取角色类型
        static RoleType GetRoleType(int attack, int defense)
        {
            if (attack >= defense * 2)
                return RoleType.Output;

            if (defense >= attack * 2)
                return RoleType.Tank;

            return RoleType.Balanced;
        }

        // 将角色类型转换成中文
        static string GetRoleTypeName(RoleType role)
        {
            switch (role)
            {
                case RoleType.Output:
                    return "输出";

                case RoleType.Tank:
                    return "坦克";

                default:
                    return "均衡";
            }
        }

        // 获取指定角色的中文类型
        static string GetRoleName(int index)
        {
            return GetRoleTypeName(
                GetRoleType(attack[index], defense[index]));
        }

        // ==================== 输入与查找 ====================

        // 打印菜单
        static void PrintMenu()
        {
            Console.WriteLine("\n===== 角色战力管理台 =====");
            Console.WriteLine("1. 录入角色");
            Console.WriteLine("2. 查看全部");
            Console.WriteLine("3. 查询角色");
            Console.WriteLine("4. 修改属性");
            Console.WriteLine("5. 删除角色");
            Console.WriteLine("6. 按战力排序");
            Console.WriteLine("7. 统计报告");
            Console.WriteLine("0. 退出");
            Console.Write("请输入选项：");
        }

        // 读取菜单选项
        static MenuOption ReadChoice()
        {
            if (int.TryParse(Console.ReadLine(), out int choice)
                && choice >= 0 && choice <= 7)
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
                    return name;

                Console.Write("姓名不能为空，请重新输入：");
            }
        }

        // 按姓名查找，找到返回下标，找不到返回 -1
        static int FindCharacter(string target)
        {
            for (int i = 0; i < count; i++)
            {
                if (names[i] == target)
                    return i;
            }

            return -1;
        }

        // 判断姓名是否重复
        static bool NameExists(string name)
        {
            return FindCharacter(name) != -1;
        }

        // 读取不重复的姓名
        static string ReadUniqueName()
        {
            while (true)
            {
                Console.Write("请输入角色姓名：");
                string name = ReadName();

                if (!NameExists(name))
                    return name;

                Console.WriteLine("该角色姓名已存在，请重新输入！");
            }
        }

        // 读取 1～100 的整数
        static int ReadAttribute(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out int value)
                    && value >= 1 && value <= 100)
                {
                    return value;
                }

                Console.WriteLine("输入无效，请输入1～100之间的整数！");
            }
        }

        // 读取 y/n 确认
        static bool Confirm(string message)
        {
            while (true)
            {
                Console.Write($"{message}（y/n）：");

                string input = (Console.ReadLine() ?? "")
                    .Trim()
                    .ToLower();

                if (input == "y")
                    return true;

                if (input == "n")
                    return false;

                Console.WriteLine("输入无效，请输入 y 或 n！");
            }
        }

        // 统一的角色查找流程
        // 空姓名时重输，不存在时返回 -1
        static int FindCharacterByInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string target = (Console.ReadLine() ?? "").Trim();

                if (target == "")
                {
                    Console.WriteLine("姓名不能为空，请重新输入！");
                    continue;
                }

                int index = FindCharacter(target);

                if (index == -1)
                {
                    Console.WriteLine("查无此人！");
                }

                return index;
            }
        }

        // 检查是否为空列表
        static bool IsEmpty()
        {
            if (count == 0)
            {
                Console.WriteLine("暂无数据");
                return true;
            }

            return false;
        }

        // ==================== 统计计算 ====================

        // 计算平均战力
        static double AveragePower()
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += GetPower(i);
            }

            return (double)sum / count;
        }

        // 获取最高战力
        static int GetMaxPower()
        {
            int max = GetPower(0);

            for (int i = 1; i < count; i++)
            {
                if (GetPower(i) > max)
                    max = GetPower(i);
            }

            return max;
        }

        // 获取最低战力
        static int GetMinPower()
        {
            int min = GetPower(0);

            for (int i = 1; i < count; i++)
            {
                if (GetPower(i) < min)
                    min = GetPower(i);
            }

            return min;
        }

        // 计算名次：1 + 战力比自己高的人数
        static int GetRank(int index)
        {
            int rank = 1;
            int currentPower = GetPower(index);

            for (int i = 0; i < count; i++)
            {
                if (GetPower(i) > currentPower)
                    rank++;
            }

            return rank;
        }

        // 输出指定战力的所有角色姓名
        static void PrintNamesByPower(int targetPower)
        {
            bool first = true;

            for (int i = 0; i < count; i++)
            {
                if (GetPower(i) == targetPower)
                {
                    if (!first)
                        Console.Write("、");

                    Console.Write(names[i]);
                    first = false;
                }
            }

            Console.WriteLine();
        }

        // ==================== 功能1：录入角色 ====================

        static void AddCharacter()
        {
            if (count >= MAX_CHARACTERS)
            {
                Console.WriteLine("角色已满，无法继续录入！");
                return;
            }

            string name = ReadUniqueName();
            int newAttack = ReadAttribute("请输入攻击力（1～100）：");
            int newDefense = ReadAttribute("请输入防御力（1～100）：");

            names[count] = name;
            attack[count] = newAttack;
            defense[count] = newDefense;
            count++;

            Console.WriteLine("录入成功！");
            Console.WriteLine($"姓名：{name}");
            Console.WriteLine($"攻击：{newAttack}");
            Console.WriteLine($"防御：{newDefense}");
            Console.WriteLine($"战力：{Power(newAttack, newDefense)}");
            Console.WriteLine(
                $"类型：{GetRoleTypeName(GetRoleType(newAttack, newDefense))}");
            Console.WriteLine($"当前人数：{count}");
        }

        // ==================== 功能2：查看全部 ====================

        static void ShowAll()
        {
            if (IsEmpty())
                return;

            Console.WriteLine("\n---------------- 角色列表 ----------------");
            Console.WriteLine(
                "姓名".PadRight(12) +
                "攻击".PadRight(8) +
                "防御".PadRight(8) +
                "战力".PadRight(8) +
                "类型");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(
                    names[i].PadRight(12) +
                    attack[i].ToString().PadRight(8) +
                    defense[i].ToString().PadRight(8) +
                    GetPower(i).ToString().PadRight(8) +
                    GetRoleName(i));
            }

            Console.WriteLine("------------------------------------------");
        }

        // ==================== 功能3：查询角色 ====================

        static void SearchCharacter()
        {
            if (IsEmpty())
                return;

            int index = FindCharacterByInput("请输入要查询的角色姓名：");

            if (index == -1)
                return;

            int power = GetPower(index);
            double average = AveragePower();
            double difference = power - average;

            Console.WriteLine("\n===== 查询结果 =====");
            Console.WriteLine($"姓名：{names[index]}");
            Console.WriteLine($"攻击：{attack[index]}");
            Console.WriteLine($"防御：{defense[index]}");
            Console.WriteLine($"战力：{power}");
            Console.WriteLine($"类型：{GetRoleName(index)}");
            Console.WriteLine($"名次：{GetRank(index)}");
            Console.WriteLine($"平均战力：{average:F2}");

            if (difference > 0)
                Console.WriteLine($"高于平均战力：{difference:F2}");
            else if (difference < 0)
                Console.WriteLine($"低于平均战力：{Math.Abs(difference):F2}");
            else
                Console.WriteLine("战力等于平均战力");
        }

        // ==================== 功能4：修改属性 ====================

        static void UpdateCharacter()
        {
            if (IsEmpty())
                return;

            int index = FindCharacterByInput("请输入要修改的角色姓名：");

            if (index == -1)
                return;

            Console.WriteLine(
                $"当前属性：攻击 {attack[index]}，防御 {defense[index]}");

            AttributeOption option;

            while (true)
            {
                Console.WriteLine("1. 修改攻击力");
                Console.WriteLine("2. 修改防御力");
                Console.Write("请选择属性：");

                if (int.TryParse(Console.ReadLine(), out int choice)
                    && (choice == 1 || choice == 2))
                {
                    option = (AttributeOption)choice;
                    break;
                }

                Console.WriteLine("输入无效，请输入1或2！");
            }

            int oldValue;
            int newValue;

            if (option == AttributeOption.Attack)
            {
                oldValue = attack[index];
                newValue = ReadAttribute("请输入新的攻击力（1～100）：");
            }
            else
            {
                oldValue = defense[index];
                newValue = ReadAttribute("请输入新的防御力（1～100）：");
            }

            if (!Confirm("确认修改"))
            {
                Console.WriteLine("已取消修改！");
                return;
            }

            int oldPower = GetPower(index);

            // 根据所选属性统一写回
            if (option == AttributeOption.Attack)
                attack[index] = newValue;
            else
                defense[index] = newValue;

            Console.WriteLine("修改成功！");
            Console.WriteLine(
                $"属性：{(option == AttributeOption.Attack ? "攻击力" : "防御力")}");
            Console.WriteLine($"数值：{oldValue} → {newValue}");
            Console.WriteLine($"战力：{oldPower} → {GetPower(index)}");
            Console.WriteLine($"新类型：{GetRoleName(index)}");
        }

        // ==================== 功能5：删除角色 ====================

        static void DeleteCharacter()
        {
            if (IsEmpty())
                return;

            int index = FindCharacterByInput("请输入要删除的角色姓名：");

            if (index == -1)
                return;

            Console.WriteLine(
                $"待删除角色：{names[index]}，攻击：{attack[index]}，" +
                $"防御：{defense[index]}，战力：{GetPower(index)}");

            if (!Confirm("确认删除"))
            {
                Console.WriteLine("已取消删除！");
                return;
            }

            // 三个数组同步前移
            for (int i = index; i < count - 1; i++)
            {
                names[i] = names[i + 1];
                attack[i] = attack[i + 1];
                defense[i] = defense[i + 1];
            }

            count--;

            // 清空末尾
            names[count] = "";
            attack[count] = 0;
            defense[count] = 0;

            Console.WriteLine("删除成功！");
            Console.WriteLine($"当前人数：{count}");

            ShowAll();
        }

        // ==================== 排序辅助方法 ====================

        // 交换两个整数
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 交换两个字符串
        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        // 同步交换三个数组中的角色
        static void SwapCharacter(int i, int j)
        {
            Swap(ref names[i], ref names[j]);
            Swap(ref attack[i], ref attack[j]);
            Swap(ref defense[i], ref defense[j]);
        }

        // 判断两个角色是否需要交换
        static bool ShouldSwap(int i, int j)
        {
            int powerI = GetPower(i);
            int powerJ = GetPower(j);

            if (powerI < powerJ)
                return true;

            if (powerI == powerJ
                && string.CompareOrdinal(names[i], names[j]) > 0)
            {
                return true;
            }

            return false;
        }

        // ==================== 功能6：按战力排序 ====================

        static void SortCharacters()
        {
            if (IsEmpty())
                return;

            for (int i = 0; i < count - 1; i++)
            {
                bool isSwapped = false;

                for (int j = 0; j < count - i - 1; j++)
                {
                    if (ShouldSwap(j, j + 1))
                    {
                        SwapCharacter(j, j + 1);
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                    break;
            }

            Console.WriteLine("排序完成！");
            ShowAll();
        }

        // ==================== 功能7：统计报告 ====================

        static void ShowReport()
        {
            if (IsEmpty())
                return;

            int maxPower = GetMaxPower();
            int minPower = GetMinPower();

            int outputCount = 0;
            int tankCount = 0;
            int balancedCount = 0;

            for (int i = 0; i < count; i++)
            {
                RoleType role = GetRoleType(attack[i], defense[i]);

                switch (role)
                {
                    case RoleType.Output:
                        outputCount++;
                        break;

                    case RoleType.Tank:
                        tankCount++;
                        break;

                    case RoleType.Balanced:
                        balancedCount++;
                        break;
                }
            }

            Console.WriteLine("\n===== 统计报告 =====");
            Console.WriteLine($"角色人数：{count}");
            Console.WriteLine($"平均战力：{AveragePower():F2}");

            Console.Write($"最高战力：{maxPower}，角色：");
            PrintNamesByPower(maxPower);

            Console.Write($"最低战力：{minPower}，角色：");
            PrintNamesByPower(minPower);

            Console.WriteLine($"输出角色人数：{outputCount}");
            Console.WriteLine($"坦克角色人数：{tankCount}");
            Console.WriteLine($"均衡角色人数：{balancedCount}");
        }

        // ==================== 主程序 ====================

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                PrintMenu();

                switch (ReadChoice())
                {
                    case MenuOption.Exit:
                        Console.WriteLine("已退出角色战力管理台！");
                        isRunning = false;
                        break;

                    case MenuOption.Add:
                        AddCharacter();
                        break;

                    case MenuOption.ShowAll:
                        ShowAll();
                        break;

                    case MenuOption.Search:
                        SearchCharacter();
                        break;

                    case MenuOption.Update:
                        UpdateCharacter();
                        break;

                    case MenuOption.Delete:
                        DeleteCharacter();
                        break;

                    case MenuOption.Sort:
                        SortCharacters();
                        break;

                    case MenuOption.Report:
                        ShowReport();
                        break;

                    default:
                        Console.WriteLine("输入不合法，请重新输入！");
                        break;
                }
            }
        }
    }
}
