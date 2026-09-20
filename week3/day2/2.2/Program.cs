namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义 3 行 4 列的数组，用初始化器填入：{1,-2,0,3}、{4,-5,6,0}、{-7,8,9,-10}
            //只用一次 foreach，同时算出：总和、平均值（两位小数）、正数个数、负数个数、零的个数
            //输出这五项
            int[,] a = new int[3, 4]
            {
                {  1, -2, 0,  3 },
                {  4, -5, 6,  0},
                { -7,  8 ,9,-10}
            };

            int sum = 0;
            double aver = 0;
            int positive = 0;
            int negative = 0;
            int zero = 0;

            foreach (int i in a)
            {
                sum += i;
                if (i > 0) positive++;
                else if (i < 0) negative++;
                else zero++;
            }
            aver = (double)sum / a.Length;
            Console.WriteLine($"sum is {sum},aver is {aver:F2},positive is {positive},negative is {negative},zero is {zero}");
        }
    }
}
