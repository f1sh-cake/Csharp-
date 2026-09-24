namespace _4._1
{
    internal class Program
    {

        //返回较大值
        static int FindMax(int a,int b)
        {
            return a > b ? a : b;
        }

        //返回是否是偶数
        static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        //返回平均值（数组当参数）
        static double Aver(int[]array)
        {
            int sum = 0;
            foreach(int x in array)
            {
                sum += x;
            }
            return (double)sum/array.Length;
        }

        //static void PrintTitle(string text, int width)void，用 PadRight(width, '=') 补到指定宽度
        static void PrintTitle(string text,int width)
        {
            Console.WriteLine(text.PadRight(width,'='));
        }

        static void Main(string[] args)
        {
           
        }
    }
}
