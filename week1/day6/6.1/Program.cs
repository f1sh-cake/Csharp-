namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*综合练习：学生成绩统计——
             * 输入姓名和三科成绩
             * 输出总分
             * 平均分（保留两位小数）、
            最高分（`Math.Max` 嵌套）、
            最低分（`Math.Min` 嵌套）*/

            Console.Write("enter student's name:");
            string name = Console.ReadLine();
            Console.Write("enter student's first score:");
            int score1 = int.Parse(Console.ReadLine());
            Console.Write("enter student's second score:");
            int score2 = int.Parse(Console.ReadLine());
            Console.Write("enter student's third score:");
            int score3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"name is {name}");
            Console.WriteLine($"总分为：{score1 + score2 + score3}");
            Console.WriteLine($"aver is {(score1 + score2 + score3) / 3.0:F2}");
            Console.WriteLine($"最高分是：{Math.Max(Math.Max(score1, score2),score3)}");
            Console.WriteLine($"最低分是：{Math.Min(Math.Min(score1,score2),score3)}");

        }
    }
}
