namespace _1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个成绩（0-100），输出等级：90+ 为 A，80+ 为 B，70+ 为 C，60+ 为 D，其余为 F。
            Console.Write("enter a score:");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90) Console.WriteLine("A");
            else if (score >= 80) Console.WriteLine("B");
            else if (score >= 70) Console.WriteLine("C");
            else if (score >= 60) Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
