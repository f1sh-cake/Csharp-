namespace _5._3
{
    internal class Program
    {
        //返回最大值的下标，用 out 把最大值本身带出来
        static int MaxIndex(int[] a, out int maxValue)
        {
            if (a.Length == 0)
            {
                maxValue = 0;
                return -1;
            }
            int maxIndex = 0;
            maxValue = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > maxValue)
                {
                    maxValue = a[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 9 };

            int maxValue;
            int maxIndex = MaxIndex(a, out maxValue);

            if (maxIndex == -1)
            {
                Console.WriteLine("该数组为空数组");
            }
            else Console.WriteLine($"最大值下标为{maxIndex},最大值为{maxValue}");
        }
    }
}
