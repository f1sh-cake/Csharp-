namespace _6._2
{
    internal class Program
    {
        // 冒泡排序：打印每一轮结束后的数组状态，统计总轮数与总比较次数，并验证"已有序数组第一轮就退出"

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void BubbleSort(int[] a)
        {
            //统计总比较次数
            int rounds = 0;
            int compared = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                //本轮是否交换
                bool swapped = false;

                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    compared++;
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref a[j], ref a[j + 1]);
                        swapped = true;
                    }
                }
                rounds++;
                Console.WriteLine($"第{rounds}轮已结束:{string.Join(' ', a)}");

                if (!swapped)
                {
                    break;
                }
            }
            Console.WriteLine($"进行了{rounds}轮，比较了{compared}次");

        }
        static void Main(string[] args)
        {
            int[] a = { 5, 2, 1, 6, 9, 7, 6, 3, };
            BubbleSort(a);
        }
    }
}
