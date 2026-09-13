namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入姓名及他的三科分数，中间用空格隔开：");
            string student = Console.ReadLine();
            string[] infor = student.Split(' ');
            string name = infor[0];
            double score1 = double.Parse(infor[1]);
            double score2 = double.Parse(infor[2]);
            double score3 = double.Parse(infor[3]);

            Console.WriteLine($"max is {Math.Max(Math.Max(score1, score2), score3)}");
            Console.WriteLine($"min is {Math.Min(Math.Min(score1,score2),score3)}");
            Console.WriteLine($"total is {score1 + score2 + score3}");
            Console.WriteLine($"aver is {(score1 + score2 + score3)/3.0:F2}");
            
        }
    }
}
