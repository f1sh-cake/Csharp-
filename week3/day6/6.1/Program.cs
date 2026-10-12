namespace _6._1
{
    internal class Program
    {
        //数组工具箱（方法版）：
        //写 `Max` / `Min` / `Sum` / `Reverse` 四个方法，

        static int Max(int[] a)
        {
            int max = a[0];
            foreach (int i in a)
            {
                if (i > max) max = i;
            }
            return max;
        }

        static int Min(int[] a)
        {
            int min = a[0];
            foreach (int i in a)
            {
                if (i < min) min = i;
            }
            return min;
        }

        static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }

        static void Reverse(int[] a)
        {
            int i = 0;
            int j = a.Length - 1;

            while (i < j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j]= temp;
                i++;
                j--;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
