namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random 生成 5 个 1–100 的整数存进数组（只创建一次）
            //输出数组内容
            //输出最大值、最小值、平均分（两位小数）
            //输出比平均值大的元素个数
            //输出最大值与平均值的差（Math.Abs，两位小数）
            Random rand = new Random();
            int[] randArray = new int[5];

            int sum = 0;
            int aboveAverNum = 0;

            for (int i = 0;i<randArray.Length;i++)
            {
                randArray[i] = rand.Next(1,101);
                sum += randArray[i];
            }

            double averScore = (double)sum/randArray.Length;

            int max = randArray[0];
            int min = randArray[0];

            for (int i = 0;i<randArray.Length;i++)
            {
                Console.WriteLine(randArray[i]);
                max = Math.Max(max, randArray[i]);
                min = Math.Min(min, randArray[i]);
                if (randArray[i] >averScore)
                {
                    aboveAverNum++;
                }
            }

            Console.WriteLine($"max is {max},min is {min}, averScore is {averScore:F2},aboveAverScore is {aboveAverNum},max-averScore is {Math.Abs(max - averScore):F2}");
        }
    }
}
