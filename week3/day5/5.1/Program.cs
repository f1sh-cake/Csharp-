namespace _5._1
{
    internal class Program
    {
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        static int Max(int a, int b, int c)
        {
            return Max(Max(a, b), c);
        }

        // 复用 Day 1 的数组遍历
        static int Max(int[] a)
        {
            int max = a[0];
            foreach (int i in a)
            {
                if (i > max) max = i;
            }
            return max;
        }

        static double Max(double[] a)
        {
            double max = a[0];
            foreach (double i in a)
            {
                if (i > max) max = i;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Max(3, 5));
            Console.WriteLine(Max(3.5, 2.7));
            Console.WriteLine(Max(4, 9, 2));
            Console.WriteLine(Max(new int[] { 3, 9, 2 }));
            Console.WriteLine(Max(new double[] { 1.5, 0.5, 2.25 }));
        }
    }
}
