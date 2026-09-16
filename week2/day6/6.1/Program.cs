namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //找出 100-999 之间的所有水仙花数，并输出总个数。(原数 = 百位³ + 十位³ + 个位³)

            int count = 0;
            for (int i = 100; i <= 999; i++)
            {
                int hundreds = i / 100;
                int tens = i % 100 / 10;
                int ones = i % 10;
                if (i == Math.Pow(hundreds, 3) + Math.Pow(tens, 3) + Math.Pow(ones, 3))
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
