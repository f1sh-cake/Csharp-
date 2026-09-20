namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习 2：6 个整数逆序输出（倒着遍历）+ 输出下标为偶数的元素之和

            int evenSum = 0;
            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"请输入第{i + 1}个数:");
                array[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += array[i];
                }
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"第{i+1}个数为:{array[i]}");
            }
            Console.WriteLine($"下标为偶数的元素之和为{evenSum}");

        }
    }
}
