namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. int[,] m = new int[3, 3];
            //2.双重 for 输入 9 个整数，提示写成"第 i 行第 j 列"
            //3.按矩阵格式打印（每行 3 个，用, 4 对齐，行末换行）
            //4.输出：主对角线之和（i == j）、副对角线之和（i + j == 行数 - 1）、全部元素之和
            int[,] m = new int[3, 3];


            //输入数据
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"第{i + 1}行，第{j + 1}列:");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //打印数据
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j],4}");
                }
                Console.WriteLine();
            }

            //主对角线之和&副对角线之和
            int mainDiagonalSum = 0;
            int antiDiagonalSum = 0;
            int sum = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0;j<m.GetLength(1);j++)
                {
                    if(i == j)
                    {
                        mainDiagonalSum += m[i, j];
                    }
                    if(i+j==m.GetLength(0)-1)
                    {
                        antiDiagonalSum += m[i, j];
                    }
                    sum += m[i, j];
                }
            }

            Console.WriteLine($"mainDiagonalSum is{mainDiagonalSum},antidiagonal sum is {antiDiagonalSum},sum is {sum}");

        }
    }
}
