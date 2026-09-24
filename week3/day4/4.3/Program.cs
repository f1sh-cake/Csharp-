namespace _4._3
{
    internal class Program
    {
        //把 Day 2 的矩阵打印改成 static void PrintMatrix(int[,] m)（参数是二维数组），
        //在 Main 里分别传一个 3x3 和一个 2x4 的矩阵进去，两份输出共用同一段方法代码

        //录入元素
        static void Input2DArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"请输入第{i + 1}行，第{j + 1}列的元素:");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //打印元素
        static void Print2DArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("请输入矩阵行数：");
            int raw1 = int.Parse(Console.ReadLine());
            Console.Write("请输入矩阵列数：");
            int column1 = int.Parse(Console.ReadLine());
            int[,] a = new int[raw1, column1];
            Input2DArray(a);
            Print2DArray(a);
            Console.Write("请输入矩阵行数：");
            int raw2 = int.Parse(Console.ReadLine());
            Console.Write("请输入矩阵列数：");
            int column2 = int.Parse(Console.ReadLine());
            int[,] b = new int[raw2, column2];
            Input2DArray(b);
            Print2DArray(b);
        }
    }
}
